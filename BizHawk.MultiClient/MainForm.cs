﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BizHawk.Core;
using BizHawk.Emulation.Consoles.Sega;
using BizHawk.Emulation.Consoles.TurboGrafx;

namespace BizHawk.MultiClient
{
    public partial class MainForm : Form
    {
        private Control renderTarget;
		private RetainedViewportPanel retainedPanel;
        
        private bool EmulatorPaused = false;

        public MainForm(string[] args)
        {
            Global.MainForm = this;
            Global.Config = ConfigService.Load<Config>("config.ini");

            InitializeComponent();

			if (Global.Direct3D != null)
				renderTarget = new ViewportPanel();
			else renderTarget = retainedPanel = new RetainedViewportPanel();

            renderTarget.Dock = DockStyle.Fill;
            renderTarget.BackColor = Color.Black;
            Controls.Add(renderTarget);
            Database.LoadDatabase("gamedb.txt");

			if (Global.Direct3D != null)
			{
				Global.RenderPanel = new Direct3DRenderPanel(Global.Direct3D, renderTarget);
			}
			else
			{
				Global.RenderPanel = new SysdrawingRenderPanel(retainedPanel);
			}

            Load += (o, e) =>
                {
                    AllowDrop = true;
                    DragEnter += FormDragEnter;
                    DragDrop += FormDragDrop;
                };

            Closing += (o, e) =>
               {
                   CloseGame();
                   ConfigService.Save("config.ini", Global.Config);
               };

            ResizeBegin += (o, e) =>
            {
                if (Global.Sound != null) Global.Sound.StopSound();
            };

            ResizeEnd += (o, e) =>
            {
                if (Global.RenderPanel != null) Global.RenderPanel.Resized = true;
                if (Global.Sound != null) Global.Sound.StartSound();
            };

            InitControls();
            Global.Emulator = new NullEmulator();
            Global.Sound = new Sound(Handle, Global.DSound);
            Global.Sound.StartSound();

            Application.Idle += Application_Idle;

			if(args.Length != 0)
				LoadRom(args[0]);
        }

        public static ControllerDefinition ClientControlsDef = new ControllerDefinition
        {
            Name = "Emulator Frontend Controls",
            BoolButtons = { "Fast Forward", "Rewind", "Hard Reset", "Mode Flip", "Quick Save State", "Quick Load State", "Save Named State", "Load Named State", "Emulator Pause", "Frame Advance", "Screenshot" }
        };

        private void InitControls()
        {
            Input.Initialize();
            var controls = new Controller(ClientControlsDef);
            controls.BindMulti("Fast Forward", Global.Config.FastForwardBinding);
            controls.BindMulti("Rewind", Global.Config.RewindBinding);
            controls.BindMulti("Hard Reset", Global.Config.HardResetBinding);
            controls.BindMulti("Emulator Pause", Global.Config.EmulatorPauseBinding);
            controls.BindMulti("Frame Advance", Global.Config.FrameAdvanceBinding);
            controls.BindMulti("Screenshot", Global.Config.ScreenshotBinding);
            Global.ClientControls = controls;

            var smsControls = new Controller(SMS.SmsController);
            smsControls.BindMulti("Reset", Global.Config.SmsReset);
            smsControls.BindMulti("Pause", Global.Config.SmsPause);

            smsControls.BindMulti("P1 Up", Global.Config.SmsP1Up);
            smsControls.BindMulti("P1 Left", Global.Config.SmsP1Left);
            smsControls.BindMulti("P1 Right", Global.Config.SmsP1Right);
            smsControls.BindMulti("P1 Down", Global.Config.SmsP1Down);
            smsControls.BindMulti("P1 B1", Global.Config.SmsP1B1);
            smsControls.BindMulti("P1 B2", Global.Config.SmsP1B2);

            smsControls.BindMulti("P2 Up", Global.Config.SmsP2Up);
            smsControls.BindMulti("P2 Left", Global.Config.SmsP2Left);
            smsControls.BindMulti("P2 Right", Global.Config.SmsP2Right);
            smsControls.BindMulti("P2 Down", Global.Config.SmsP2Down);
            smsControls.BindMulti("P2 B1", Global.Config.SmsP2B1);
            smsControls.BindMulti("P2 B2", Global.Config.SmsP2B2);
            Global.SMSControls = smsControls;

            var pceControls = new Controller(PCEngine.PCEngineController);
            pceControls.BindMulti("Up", Global.Config.PCEUp);
            pceControls.BindMulti("Down", Global.Config.PCEDown);
            pceControls.BindMulti("Left", Global.Config.PCELeft);
            pceControls.BindMulti("Right", Global.Config.PCERight);

            pceControls.BindMulti("II", Global.Config.PCEBII);
            pceControls.BindMulti("I", Global.Config.PCEBI);
            pceControls.BindMulti("Select", Global.Config.PCESelect);
            pceControls.BindMulti("Run", Global.Config.PCERun);
            Global.PCEControls = pceControls;

            var genControls = new Controller(Genesis.GenesisController);
            genControls.BindMulti("P1 Up", Global.Config.GenP1Up);
            genControls.BindMulti("P1 Left", Global.Config.GenP1Left);
            genControls.BindMulti("P1 Right", Global.Config.GenP1Right);
            genControls.BindMulti("P1 Down", Global.Config.GenP1Down);
            genControls.BindMulti("P1 A", Global.Config.GenP1A);
            genControls.BindMulti("P1 B", Global.Config.GenP1B);
            genControls.BindMulti("P1 C", Global.Config.GenP1C);
            genControls.BindMulti("P1 Start", Global.Config.GenP1Start);
            Global.GenControls = genControls;
        }

        private static void FormDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void FormDragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[]) e.Data.GetData(DataFormats.FileDrop);
            LoadRom(filePaths[0]);
        }

        private void LoadRom(string path)
        {
            var file = new FileInfo(path);
            if (file.Exists == false) return;

            CloseGame();

            var game = new RomGame(path);
            Global.Game = game;

            switch(game.System)
            {
                case "SMS": 
                    Global.Emulator = new SMS();
                    Global.Emulator.Controller = Global.SMSControls;
                    break;
                case "GG":
                    Global.Emulator = new SMS { IsGameGear = true };
                    Global.Emulator.Controller = Global.SMSControls;
                    break;
                case "PCE":
                    Global.Emulator = new PCEngine(NecSystemType.TurboGrafx);
                    Global.Emulator.Controller = Global.PCEControls;
                    break;
                case "SGX":
                    Global.Emulator = new PCEngine(NecSystemType.SuperGrafx);
                    Global.Emulator.Controller = Global.PCEControls;
                    break;
                case "GEN":
                    Global.Emulator = new Genesis(false);//TODO
                    Global.Emulator.Controller = Global.GenControls;
                    break;
            }

            Global.Emulator.LoadGame(game);
            Text = game.Name;
            ResetRewindBuffer();

            if (File.Exists(game.SaveRamPath))
                LoadSaveRam();
        }

        private void LoadSaveRam()
        {
            using (var reader = new BinaryReader(new FileStream(Global.Game.SaveRamPath, FileMode.Open, FileAccess.Read)))
                reader.Read(Global.Emulator.SaveRam, 0, Global.Emulator.SaveRam.Length);
        }

        private void CloseGame()
        {
            if (Global.Emulator.SaveRamModified)
            {
                string path = Global.Game.SaveRamPath;

                var f = new FileInfo(path);
                if (f.Directory.Exists == false)
                    f.Directory.Create();

                var writer = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
                int len = Util.SaveRamBytesUsed(Global.Emulator.SaveRam);
                writer.Write(Global.Emulator.SaveRam, 0, len);
                writer.Close();
            }
        }

        [System.Security.SuppressUnmanagedCodeSecurity, DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool PeekMessage(out Message msg, IntPtr hWnd, UInt32 msgFilterMin, UInt32 msgFilterMax, UInt32 flags);

        public void GameTick()
        {
            Input.Update();
            if (ActiveForm != null)
                ScreenSaver.ResetTimerPeriodically();

            if (/*Global.Config.RewindEnabled && */Global.ClientControls["Rewind"])
            {
                Rewind();
                return;
            }
   
            if (Global.ClientControls["Hard Reset"])
            {
                Global.ClientControls.UnpressButton("Hard Reset");
                Global.Emulator.HardReset();
            }

            if (Global.ClientControls["Fast Forward"])
            {
                Global.Emulator.FrameAdvance(false);
                Global.Emulator.FrameAdvance(false);
                Global.Emulator.FrameAdvance(false);
            }

            if (Global.ClientControls["Screenshot"])
            {
                Global.ClientControls.UnpressButton("Screenshot");
                TakeScreenshot();
            }

            if (Global.ClientControls["Emulator Pause"])
            {
                Global.ClientControls.UnpressButton("Emulator Pause");
                EmulatorPaused = !EmulatorPaused;
            }

            if (EmulatorPaused == false || Global.ClientControls["Frame Advance"])
            {
                CaptureRewindState();
                Global.Emulator.FrameAdvance(true);
                if (EmulatorPaused)
                    Global.ClientControls.UnpressButton("Frame Advance");
            }
            Global.Sound.UpdateSound(Global.Emulator.SoundProvider);
            Global.RenderPanel.Render(Global.Emulator.VideoProvider);
        }

        private bool wasMaximized = false;

        private void Application_Idle(object sender, EventArgs e)
        {
            if (wasMaximized != (WindowState == FormWindowState.Maximized))
            {
                wasMaximized = (WindowState == FormWindowState.Maximized);
                Global.RenderPanel.Resized = true;
            }

            Message msg;
            while (!PeekMessage(out msg, IntPtr.Zero, 0, 0, 0))
            {
                GameTick();
            }
        }

        private void TakeScreenshot()
        {
            var video = Global.Emulator.VideoProvider;
            var image = new Bitmap(video.BufferWidth, video.BufferHeight, PixelFormat.Format32bppArgb);

            for (int y=0; y<video.BufferHeight; y++)
                for (int x=0; x<video.BufferWidth; x++)
                    image.SetPixel(x, y, Color.FromArgb(video.GetVideoBuffer()[(y*video.BufferWidth)+x]));

            var f = new FileInfo(String.Format(Global.Game.ScreenshotPrefix+".{0:yyyy-MM-dd HH.mm.ss}.png",DateTime.Now));
            if (f.Directory.Exists == false)
                f.Directory.Create();

            Global.RenderPanel.AddMessage(f.Name+" saved.");

            image.Save(f.FullName, ImageFormat.Png);
        }

        private void SaveState(string name)
        {
            string path = Global.Game.SaveStatePrefix+"."+name+".State";

            var file = new FileInfo(path);
            if (file.Directory.Exists == false)
                file.Directory.Create();

            var writer = new StreamWriter(path);
            Global.Emulator.SaveStateText(writer);
            writer.Close();
            Global.RenderPanel.AddMessage("Saved state: "+name);
        }

        private void LoadState(string name)
        {
            string path = Global.Game.SaveStatePrefix + "." + name + ".State";
            if (File.Exists(path) == false)
                return;

            var reader = new StreamReader(path);
            Global.Emulator.LoadStateText(reader);
            reader.Close();
            Global.RenderPanel.AddMessage("Loaded state: "+name);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.InitialDirectory = Global.Config.LastRomPath;
            ofd.Filter = "Rom Files|*.SMS;*.GG;*.SG;*.PCE;*.SGX;*.GB;*.BIN;*.SMD;*.ZIP|Master System|*.SMS;*.GG;*.ZIP|PC Engine|*.PCE;*.SG;*.SGX;*.ZIP|Gameboy|*.GB;*.ZIP|All Files|*.*";
            ofd.RestoreDirectory = true;

            Global.Sound.StopSound();
            var result = ofd.ShowDialog();
            Global.Sound.StartSound();
            if (result != DialogResult.OK)
                return;
            var file = new FileInfo(ofd.FileName);
            Global.Config.LastRomPath = file.DirectoryName;
            LoadRom(file.FullName);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)  { SaveState("QuickSave1"); }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)  { SaveState("QuickSave2"); }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)  { SaveState("QuickSave3"); }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)  { SaveState("QuickSave4"); }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)  { SaveState("QuickSave5"); }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)  { SaveState("QuickSave6"); }
        private void toolStripMenuItem10_Click(object sender, EventArgs e) { SaveState("QuickSave7"); }
        private void toolStripMenuItem11_Click(object sender, EventArgs e) { SaveState("QuickSave8"); }
        private void toolStripMenuItem12_Click(object sender, EventArgs e) { SaveState("QuickSave9"); }
        private void toolStripMenuItem13_Click(object sender, EventArgs e) { SaveState("QuickSave0"); }

        private void toolStripMenuItem14_Click(object sender, EventArgs e) { LoadState("QuickSave1"); }
        private void toolStripMenuItem15_Click(object sender, EventArgs e) { LoadState("QuickSave2"); }
        private void toolStripMenuItem16_Click(object sender, EventArgs e) { LoadState("QuickSave3"); }
        private void toolStripMenuItem17_Click(object sender, EventArgs e) { LoadState("QuickSave4"); }
        private void toolStripMenuItem18_Click(object sender, EventArgs e) { LoadState("QuickSave5"); }
        private void toolStripMenuItem19_Click(object sender, EventArgs e) { LoadState("QuickSave6"); }
        private void toolStripMenuItem20_Click(object sender, EventArgs e) { LoadState("QuickSave7"); }
        private void toolStripMenuItem21_Click(object sender, EventArgs e) { LoadState("QuickSave8"); }
        private void toolStripMenuItem22_Click(object sender, EventArgs e) { LoadState("QuickSave9"); }
        private void toolStripMenuItem23_Click(object sender, EventArgs e) { LoadState("QuickSave0"); }

        private void saveStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Global.Sound.StopSound();
            Application.Idle -= Application_Idle;

            var frm = new NameStateForm();
            frm.ShowDialog(this);

            if (frm.OK)
                SaveState(frm.Result);

            Global.Sound.StartSound();
            Application.Idle += Application_Idle;
        }
    }
}