﻿namespace BizHawk.Client.EmuHawk
{
	partial class BasicBot
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicBot));
			this.BotMenu = new MenuStripEx();
			this.FileSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RecentSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.MemoryDomainsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.DataSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._1ByteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._2ByteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._4ByteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BigEndianMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.TurboWhileBottingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RunBtn = new System.Windows.Forms.Button();
			this.BotStatusStrip = new System.Windows.Forms.StatusStrip();
			this.BotStatusButton = new System.Windows.Forms.ToolStripStatusLabel();
			this.MessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ControlsBox = new System.Windows.Forms.GroupBox();
			this.ControlProbabilityPanel = new System.Windows.Forms.Panel();
			this.BestGroupBox = new System.Windows.Forms.GroupBox();
			this.PlayBestButton = new System.Windows.Forms.Button();
			this.ClearBestButton = new System.Windows.Forms.Button();
			this.BestAttemptNumberLabel = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.BestAttemptLogLabel = new System.Windows.Forms.Label();
			this.BestTieBreak3Box = new System.Windows.Forms.TextBox();
			this.BestTieBreak2Box = new System.Windows.Forms.TextBox();
			this.BestTieBreak1Box = new System.Windows.Forms.TextBox();
			this.BestMaximizeBox = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AttemptsLabel = new System.Windows.Forms.Label();
			this.FramesLabel = new System.Windows.Forms.Label();
			this.GoalGroupBox = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TieBreaker1Box = new BizHawk.Client.EmuHawk.HexTextBox();
			this.TieBreaker2Box = new BizHawk.Client.EmuHawk.HexTextBox();
			this.TieBreaker3Box = new BizHawk.Client.EmuHawk.HexTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.MaximizeAddressBox = new BizHawk.Client.EmuHawk.HexTextBox();
			this.maximizeLabeltext = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.FrameLengthNumeric = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.StopBtn = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.StartFromSlotBox = new System.Windows.Forms.ComboBox();
			this.ControlGroupBox = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.StatsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ClearStatsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BotMenu.SuspendLayout();
			this.BotStatusStrip.SuspendLayout();
			this.ControlsBox.SuspendLayout();
			this.BestGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.GoalGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FrameLengthNumeric)).BeginInit();
			this.ControlGroupBox.SuspendLayout();
			this.panel2.SuspendLayout();
			this.StatsContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// BotMenu
			// 
			this.BotMenu.ClickThrough = true;
			this.BotMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSubMenu,
            this.OptionsSubMenu});
			this.BotMenu.Location = new System.Drawing.Point(0, 0);
			this.BotMenu.Name = "BotMenu";
			this.BotMenu.Size = new System.Drawing.Size(587, 24);
			this.BotMenu.TabIndex = 0;
			this.BotMenu.Text = "menuStrip1";
			// 
			// FileSubMenu
			// 
			this.FileSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.RecentSubMenu,
            this.toolStripSeparator1,
            this.ExitMenuItem});
			this.FileSubMenu.Name = "FileSubMenu";
			this.FileSubMenu.Size = new System.Drawing.Size(37, 20);
			this.FileSubMenu.Text = "&File";
			this.FileSubMenu.DropDownOpened += new System.EventHandler(this.FileSubMenu_DropDownOpened);
			// 
			// NewMenuItem
			// 
			this.NewMenuItem.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.NewFile;
			this.NewMenuItem.Name = "NewMenuItem";
			this.NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.NewMenuItem.Size = new System.Drawing.Size(195, 22);
			this.NewMenuItem.Text = "&New";
			this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
			// 
			// OpenMenuItem
			// 
			this.OpenMenuItem.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.OpenFile;
			this.OpenMenuItem.Name = "OpenMenuItem";
			this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OpenMenuItem.Size = new System.Drawing.Size(195, 22);
			this.OpenMenuItem.Text = "&Open...";
			this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
			// 
			// SaveMenuItem
			// 
			this.SaveMenuItem.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.SaveAs;
			this.SaveMenuItem.Name = "SaveMenuItem";
			this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.SaveMenuItem.Size = new System.Drawing.Size(195, 22);
			this.SaveMenuItem.Text = "&Save";
			this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
			// 
			// SaveAsMenuItem
			// 
			this.SaveAsMenuItem.Name = "SaveAsMenuItem";
			this.SaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.SaveAsMenuItem.Size = new System.Drawing.Size(195, 22);
			this.SaveAsMenuItem.Text = "Save &As...";
			this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
			// 
			// RecentSubMenu
			// 
			this.RecentSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
			this.RecentSubMenu.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.Recent;
			this.RecentSubMenu.Name = "RecentSubMenu";
			this.RecentSubMenu.Size = new System.Drawing.Size(195, 22);
			this.RecentSubMenu.Text = "Recent";
			this.RecentSubMenu.DropDownOpened += new System.EventHandler(this.RecentSubMenu_DropDownOpened);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(57, 6);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.ShortcutKeyDisplayString = "Alt+F4";
			this.ExitMenuItem.Size = new System.Drawing.Size(195, 22);
			this.ExitMenuItem.Text = "E&xit";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// OptionsSubMenu
			// 
			this.OptionsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemoryDomainsMenuItem,
            this.DataSizeMenuItem,
            this.BigEndianMenuItem,
            this.toolStripSeparator4,
            this.TurboWhileBottingMenuItem});
			this.OptionsSubMenu.Name = "OptionsSubMenu";
			this.OptionsSubMenu.Size = new System.Drawing.Size(61, 20);
			this.OptionsSubMenu.Text = "&Options";
			this.OptionsSubMenu.DropDownOpened += new System.EventHandler(this.OptionsSubMenu_DropDownOpened);
			// 
			// MemoryDomainsMenuItem
			// 
			this.MemoryDomainsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
			this.MemoryDomainsMenuItem.Name = "MemoryDomainsMenuItem";
			this.MemoryDomainsMenuItem.Size = new System.Drawing.Size(181, 22);
			this.MemoryDomainsMenuItem.Text = "Memory Domains";
			this.MemoryDomainsMenuItem.DropDownOpened += new System.EventHandler(this.MemoryDomainsMenuItem_DropDownOpened);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(57, 6);
			// 
			// DataSizeMenuItem
			// 
			this.DataSizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._1ByteMenuItem,
            this._2ByteMenuItem,
            this._4ByteMenuItem});
			this.DataSizeMenuItem.Name = "DataSizeMenuItem";
			this.DataSizeMenuItem.Size = new System.Drawing.Size(181, 22);
			this.DataSizeMenuItem.Text = "Data Size";
			this.DataSizeMenuItem.DropDownOpened += new System.EventHandler(this.DataSizeMenuItem_DropDownOpened);
			// 
			// _1ByteMenuItem
			// 
			this._1ByteMenuItem.Name = "_1ByteMenuItem";
			this._1ByteMenuItem.Size = new System.Drawing.Size(152, 22);
			this._1ByteMenuItem.Text = "1 Byte";
			this._1ByteMenuItem.Click += new System.EventHandler(this._1ByteMenuItem_Click);
			// 
			// _2ByteMenuItem
			// 
			this._2ByteMenuItem.Name = "_2ByteMenuItem";
			this._2ByteMenuItem.Size = new System.Drawing.Size(152, 22);
			this._2ByteMenuItem.Text = "2 Bytes";
			this._2ByteMenuItem.Click += new System.EventHandler(this._2ByteMenuItem_Click);
			// 
			// _4ByteMenuItem
			// 
			this._4ByteMenuItem.Name = "_4ByteMenuItem";
			this._4ByteMenuItem.Size = new System.Drawing.Size(152, 22);
			this._4ByteMenuItem.Text = "4 Bytes";
			this._4ByteMenuItem.Click += new System.EventHandler(this._4ByteMenuItem_Click);
			// 
			// BigEndianMenuItem
			// 
			this.BigEndianMenuItem.Name = "BigEndianMenuItem";
			this.BigEndianMenuItem.Size = new System.Drawing.Size(181, 22);
			this.BigEndianMenuItem.Text = "Big Endian";
			this.BigEndianMenuItem.Click += new System.EventHandler(this.BigEndianMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
			// 
			// TurboWhileBottingMenuItem
			// 
			this.TurboWhileBottingMenuItem.Name = "TurboWhileBottingMenuItem";
			this.TurboWhileBottingMenuItem.Size = new System.Drawing.Size(181, 22);
			this.TurboWhileBottingMenuItem.Text = "Turbo While Botting";
			this.TurboWhileBottingMenuItem.Click += new System.EventHandler(this.TurboWhileBottingMenuItem_Click);
			// 
			// RunBtn
			// 
			this.RunBtn.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.Play;
			this.RunBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RunBtn.Location = new System.Drawing.Point(6, 56);
			this.RunBtn.Name = "RunBtn";
			this.RunBtn.Size = new System.Drawing.Size(75, 23);
			this.RunBtn.TabIndex = 2001;
			this.RunBtn.Text = "&Run";
			this.RunBtn.UseVisualStyleBackColor = true;
			this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
			// 
			// BotStatusStrip
			// 
			this.BotStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotStatusButton,
            this.MessageLabel});
			this.BotStatusStrip.Location = new System.Drawing.Point(0, 565);
			this.BotStatusStrip.Name = "BotStatusStrip";
			this.BotStatusStrip.Size = new System.Drawing.Size(587, 22);
			this.BotStatusStrip.TabIndex = 2;
			this.BotStatusStrip.Text = "statusStrip1";
			// 
			// BotStatusButton
			// 
			this.BotStatusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BotStatusButton.Image = ((System.Drawing.Image)(resources.GetObject("BotStatusButton.Image")));
			this.BotStatusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BotStatusButton.Name = "BotStatusButton";
			this.BotStatusButton.RightToLeftAutoMirrorImage = true;
			this.BotStatusButton.Size = new System.Drawing.Size(16, 17);
			this.BotStatusButton.Text = " ";
			this.BotStatusButton.ToolTipText = " ";
			// 
			// MessageLabel
			// 
			this.MessageLabel.Name = "MessageLabel";
			this.MessageLabel.Size = new System.Drawing.Size(109, 17);
			this.MessageLabel.Text = "                                  ";
			// 
			// ControlsBox
			// 
			this.ControlsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ControlsBox.Controls.Add(this.ControlProbabilityPanel);
			this.ControlsBox.Location = new System.Drawing.Point(12, 183);
			this.ControlsBox.Name = "ControlsBox";
			this.ControlsBox.Size = new System.Drawing.Size(312, 369);
			this.ControlsBox.TabIndex = 3;
			this.ControlsBox.TabStop = false;
			this.ControlsBox.Text = "Controls";
			// 
			// ControlProbabilityPanel
			// 
			this.ControlProbabilityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ControlProbabilityPanel.AutoScroll = true;
			this.ControlProbabilityPanel.Location = new System.Drawing.Point(6, 19);
			this.ControlProbabilityPanel.Name = "ControlProbabilityPanel";
			this.ControlProbabilityPanel.Size = new System.Drawing.Size(299, 344);
			this.ControlProbabilityPanel.TabIndex = 0;
			// 
			// BestGroupBox
			// 
			this.BestGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BestGroupBox.Controls.Add(this.PlayBestButton);
			this.BestGroupBox.Controls.Add(this.ClearBestButton);
			this.BestGroupBox.Controls.Add(this.BestAttemptNumberLabel);
			this.BestGroupBox.Controls.Add(this.label17);
			this.BestGroupBox.Controls.Add(this.panel1);
			this.BestGroupBox.Controls.Add(this.BestTieBreak3Box);
			this.BestGroupBox.Controls.Add(this.BestTieBreak2Box);
			this.BestGroupBox.Controls.Add(this.BestTieBreak1Box);
			this.BestGroupBox.Controls.Add(this.BestMaximizeBox);
			this.BestGroupBox.Controls.Add(this.label16);
			this.BestGroupBox.Controls.Add(this.label15);
			this.BestGroupBox.Controls.Add(this.label14);
			this.BestGroupBox.Controls.Add(this.label13);
			this.BestGroupBox.Location = new System.Drawing.Point(330, 183);
			this.BestGroupBox.Name = "BestGroupBox";
			this.BestGroupBox.Size = new System.Drawing.Size(245, 369);
			this.BestGroupBox.TabIndex = 4;
			this.BestGroupBox.TabStop = false;
			this.BestGroupBox.Text = "Best";
			// 
			// PlayBestButton
			// 
			this.PlayBestButton.Enabled = false;
			this.PlayBestButton.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.Play;
			this.PlayBestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.PlayBestButton.Location = new System.Drawing.Point(12, 46);
			this.PlayBestButton.Name = "PlayBestButton";
			this.PlayBestButton.Size = new System.Drawing.Size(75, 23);
			this.PlayBestButton.TabIndex = 2004;
			this.PlayBestButton.Text = "&Play";
			this.PlayBestButton.UseVisualStyleBackColor = true;
			this.PlayBestButton.Click += new System.EventHandler(this.PlayBestButton_Click);
			// 
			// ClearBestButton
			// 
			this.ClearBestButton.Enabled = false;
			this.ClearBestButton.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.Close;
			this.ClearBestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ClearBestButton.Location = new System.Drawing.Point(12, 70);
			this.ClearBestButton.Name = "ClearBestButton";
			this.ClearBestButton.Size = new System.Drawing.Size(75, 23);
			this.ClearBestButton.TabIndex = 2003;
			this.ClearBestButton.Text = "&Clear";
			this.ClearBestButton.UseVisualStyleBackColor = true;
			this.ClearBestButton.Click += new System.EventHandler(this.ClearBestButton_Click);
			// 
			// BestAttemptNumberLabel
			// 
			this.BestAttemptNumberLabel.AutoSize = true;
			this.BestAttemptNumberLabel.Location = new System.Drawing.Point(59, 20);
			this.BestAttemptNumberLabel.Name = "BestAttemptNumberLabel";
			this.BestAttemptNumberLabel.Size = new System.Drawing.Size(13, 13);
			this.BestAttemptNumberLabel.TabIndex = 23;
			this.BestAttemptNumberLabel.Text = "0";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(17, 20);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(46, 13);
			this.label17.TabIndex = 22;
			this.label17.Text = "Attempt:";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.BestAttemptLogLabel);
			this.panel1.Location = new System.Drawing.Point(12, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(227, 251);
			this.panel1.TabIndex = 21;
			// 
			// BestAttemptLogLabel
			// 
			this.BestAttemptLogLabel.AutoSize = true;
			this.BestAttemptLogLabel.Location = new System.Drawing.Point(8, 8);
			this.BestAttemptLogLabel.Name = "BestAttemptLogLabel";
			this.BestAttemptLogLabel.Size = new System.Drawing.Size(130, 13);
			this.BestAttemptLogLabel.TabIndex = 0;
			this.BestAttemptLogLabel.Text = "                                         ";
			// 
			// BestTieBreak3Box
			// 
			this.BestTieBreak3Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BestTieBreak3Box.Location = new System.Drawing.Point(178, 73);
			this.BestTieBreak3Box.Name = "BestTieBreak3Box";
			this.BestTieBreak3Box.ReadOnly = true;
			this.BestTieBreak3Box.Size = new System.Drawing.Size(58, 20);
			this.BestTieBreak3Box.TabIndex = 20;
			this.BestTieBreak3Box.TabStop = false;
			// 
			// BestTieBreak2Box
			// 
			this.BestTieBreak2Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BestTieBreak2Box.Location = new System.Drawing.Point(178, 53);
			this.BestTieBreak2Box.Name = "BestTieBreak2Box";
			this.BestTieBreak2Box.ReadOnly = true;
			this.BestTieBreak2Box.Size = new System.Drawing.Size(58, 20);
			this.BestTieBreak2Box.TabIndex = 19;
			this.BestTieBreak2Box.TabStop = false;
			// 
			// BestTieBreak1Box
			// 
			this.BestTieBreak1Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BestTieBreak1Box.Location = new System.Drawing.Point(178, 33);
			this.BestTieBreak1Box.Name = "BestTieBreak1Box";
			this.BestTieBreak1Box.ReadOnly = true;
			this.BestTieBreak1Box.Size = new System.Drawing.Size(58, 20);
			this.BestTieBreak1Box.TabIndex = 18;
			this.BestTieBreak1Box.TabStop = false;
			// 
			// BestMaximizeBox
			// 
			this.BestMaximizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BestMaximizeBox.Location = new System.Drawing.Point(178, 13);
			this.BestMaximizeBox.Name = "BestMaximizeBox";
			this.BestMaximizeBox.ReadOnly = true;
			this.BestMaximizeBox.Size = new System.Drawing.Size(58, 20);
			this.BestMaximizeBox.TabIndex = 17;
			this.BestMaximizeBox.TabStop = false;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(111, 76);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(61, 13);
			this.label16.TabIndex = 16;
			this.label16.Text = "Tiebreak 3:";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(111, 56);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(61, 13);
			this.label15.TabIndex = 15;
			this.label15.Text = "Tiebreak 2:";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(111, 36);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(61, 13);
			this.label14.TabIndex = 6;
			this.label14.Text = "Tiebreak 1:";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(119, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Maximize:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Attempts:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Frames:";
			// 
			// AttemptsLabel
			// 
			this.AttemptsLabel.AutoSize = true;
			this.AttemptsLabel.Location = new System.Drawing.Point(61, 2);
			this.AttemptsLabel.Name = "AttemptsLabel";
			this.AttemptsLabel.Size = new System.Drawing.Size(13, 13);
			this.AttemptsLabel.TabIndex = 7;
			this.AttemptsLabel.Text = "0";
			// 
			// FramesLabel
			// 
			this.FramesLabel.AutoSize = true;
			this.FramesLabel.Location = new System.Drawing.Point(61, 17);
			this.FramesLabel.Name = "FramesLabel";
			this.FramesLabel.Size = new System.Drawing.Size(13, 13);
			this.FramesLabel.TabIndex = 8;
			this.FramesLabel.Text = "0";
			// 
			// GoalGroupBox
			// 
			this.GoalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GoalGroupBox.Controls.Add(this.label12);
			this.GoalGroupBox.Controls.Add(this.label11);
			this.GoalGroupBox.Controls.Add(this.label10);
			this.GoalGroupBox.Controls.Add(this.label9);
			this.GoalGroupBox.Controls.Add(this.label7);
			this.GoalGroupBox.Controls.Add(this.label6);
			this.GoalGroupBox.Controls.Add(this.TieBreaker1Box);
			this.GoalGroupBox.Controls.Add(this.TieBreaker2Box);
			this.GoalGroupBox.Controls.Add(this.TieBreaker3Box);
			this.GoalGroupBox.Controls.Add(this.label5);
			this.GoalGroupBox.Controls.Add(this.MaximizeAddressBox);
			this.GoalGroupBox.Controls.Add(this.maximizeLabeltext);
			this.GoalGroupBox.Controls.Add(this.label4);
			this.GoalGroupBox.Controls.Add(this.FrameLengthNumeric);
			this.GoalGroupBox.Controls.Add(this.label3);
			this.GoalGroupBox.Location = new System.Drawing.Point(12, 27);
			this.GoalGroupBox.Name = "GoalGroupBox";
			this.GoalGroupBox.Size = new System.Drawing.Size(312, 150);
			this.GoalGroupBox.TabIndex = 9;
			this.GoalGroupBox.TabStop = false;
			this.GoalGroupBox.Text = "Goal";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(108, 124);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(59, 13);
			this.label12.TabIndex = 14;
			this.label12.Text = "Address 0x";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(108, 102);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(59, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "Address 0x";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(108, 79);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 13);
			this.label10.TabIndex = 12;
			this.label10.Text = "Address 0x";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(108, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Address 0x";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(42, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Tiebreak 3:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Tiebreak 2:";
			// 
			// TieBreaker1Box
			// 
			this.TieBreaker1Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TieBreaker1Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TieBreaker1Box.Location = new System.Drawing.Point(167, 75);
			this.TieBreaker1Box.Name = "TieBreaker1Box";
			this.TieBreaker1Box.Nullable = true;
			this.TieBreaker1Box.Size = new System.Drawing.Size(95, 20);
			this.TieBreaker1Box.TabIndex = 1002;
			// 
			// TieBreaker2Box
			// 
			this.TieBreaker2Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TieBreaker2Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TieBreaker2Box.Location = new System.Drawing.Point(167, 98);
			this.TieBreaker2Box.Name = "TieBreaker2Box";
			this.TieBreaker2Box.Nullable = true;
			this.TieBreaker2Box.Size = new System.Drawing.Size(95, 20);
			this.TieBreaker2Box.TabIndex = 1003;
			// 
			// TieBreaker3Box
			// 
			this.TieBreaker3Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TieBreaker3Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TieBreaker3Box.Location = new System.Drawing.Point(167, 120);
			this.TieBreaker3Box.Name = "TieBreaker3Box";
			this.TieBreaker3Box.Nullable = true;
			this.TieBreaker3Box.Size = new System.Drawing.Size(95, 20);
			this.TieBreaker3Box.TabIndex = 1004;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Tiebreak 1:";
			// 
			// MaximizeAddressBox
			// 
			this.MaximizeAddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MaximizeAddressBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.MaximizeAddressBox.Location = new System.Drawing.Point(167, 52);
			this.MaximizeAddressBox.Name = "MaximizeAddressBox";
			this.MaximizeAddressBox.Nullable = true;
			this.MaximizeAddressBox.Size = new System.Drawing.Size(95, 20);
			this.MaximizeAddressBox.TabIndex = 1001;
			this.MaximizeAddressBox.TextChanged += new System.EventHandler(this.FrameLengthNumeric_ValueChanged);
			// 
			// maximizeLabeltext
			// 
			this.maximizeLabeltext.AutoSize = true;
			this.maximizeLabeltext.Location = new System.Drawing.Point(50, 56);
			this.maximizeLabeltext.Name = "maximizeLabeltext";
			this.maximizeLabeltext.Size = new System.Drawing.Size(53, 13);
			this.maximizeLabeltext.TabIndex = 3;
			this.maximizeLabeltext.Text = "Maximize:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(113, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "frames";
			// 
			// FrameLengthNumeric
			// 
			this.FrameLengthNumeric.Location = new System.Drawing.Point(60, 25);
			this.FrameLengthNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.FrameLengthNumeric.Name = "FrameLengthNumeric";
			this.FrameLengthNumeric.Size = new System.Drawing.Size(46, 20);
			this.FrameLengthNumeric.TabIndex = 1000;
			this.FrameLengthNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.FrameLengthNumeric.ValueChanged += new System.EventHandler(this.FrameLengthNumeric_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "End after";
			// 
			// StopBtn
			// 
			this.StopBtn.Image = global::BizHawk.Client.EmuHawk.Properties.Resources.Stop;
			this.StopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.StopBtn.Location = new System.Drawing.Point(6, 56);
			this.StopBtn.Name = "StopBtn";
			this.StopBtn.Size = new System.Drawing.Size(75, 23);
			this.StopBtn.TabIndex = 2002;
			this.StopBtn.Text = "&Stop";
			this.StopBtn.UseVisualStyleBackColor = true;
			this.StopBtn.Visible = false;
			this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Start From:";
			// 
			// StartFromSlotBox
			// 
			this.StartFromSlotBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StartFromSlotBox.FormattingEnabled = true;
			this.StartFromSlotBox.Items.AddRange(new object[] {
            "Slot 0",
            "Slot 1",
            "Slot 2",
            "Slot 3",
            "Slot 4",
            "Slot 5",
            "Slot 6",
            "Slot 7",
            "Slot 8",
            "Slot 9"});
			this.StartFromSlotBox.Location = new System.Drawing.Point(71, 25);
			this.StartFromSlotBox.Name = "StartFromSlotBox";
			this.StartFromSlotBox.Size = new System.Drawing.Size(75, 21);
			this.StartFromSlotBox.TabIndex = 2000;
			// 
			// ControlGroupBox
			// 
			this.ControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ControlGroupBox.Controls.Add(this.panel2);
			this.ControlGroupBox.Controls.Add(this.StopBtn);
			this.ControlGroupBox.Controls.Add(this.RunBtn);
			this.ControlGroupBox.Controls.Add(this.StartFromSlotBox);
			this.ControlGroupBox.Controls.Add(this.label8);
			this.ControlGroupBox.Location = new System.Drawing.Point(329, 27);
			this.ControlGroupBox.Name = "ControlGroupBox";
			this.ControlGroupBox.Size = new System.Drawing.Size(245, 150);
			this.ControlGroupBox.TabIndex = 2004;
			this.ControlGroupBox.TabStop = false;
			this.ControlGroupBox.Text = "Control";
			// 
			// panel2
			// 
			this.panel2.ContextMenuStrip = this.StatsContextMenu;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.FramesLabel);
			this.panel2.Controls.Add(this.AttemptsLabel);
			this.panel2.Location = new System.Drawing.Point(6, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(140, 33);
			this.panel2.TabIndex = 2003;
			// 
			// StatsContextMenu
			// 
			this.StatsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearStatsContextMenuItem});
			this.StatsContextMenu.Name = "StatsContextMenu";
			this.StatsContextMenu.Size = new System.Drawing.Size(102, 26);
			// 
			// ClearStatsContextMenuItem
			// 
			this.ClearStatsContextMenuItem.Name = "ClearStatsContextMenuItem";
			this.ClearStatsContextMenuItem.Size = new System.Drawing.Size(101, 22);
			this.ClearStatsContextMenuItem.Text = "&Clear";
			this.ClearStatsContextMenuItem.Click += new System.EventHandler(this.ClearStatsContextMenuItem_Click);
			// 
			// BasicBot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 587);
			this.Controls.Add(this.ControlGroupBox);
			this.Controls.Add(this.GoalGroupBox);
			this.Controls.Add(this.BestGroupBox);
			this.Controls.Add(this.ControlsBox);
			this.Controls.Add(this.BotStatusStrip);
			this.Controls.Add(this.BotMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.BotMenu;
			this.Name = "BasicBot";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Basic Bot";
			this.Load += new System.EventHandler(this.BasicBot_Load);
			this.BotMenu.ResumeLayout(false);
			this.BotMenu.PerformLayout();
			this.BotStatusStrip.ResumeLayout(false);
			this.BotStatusStrip.PerformLayout();
			this.ControlsBox.ResumeLayout(false);
			this.BestGroupBox.ResumeLayout(false);
			this.BestGroupBox.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.GoalGroupBox.ResumeLayout(false);
			this.GoalGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FrameLengthNumeric)).EndInit();
			this.ControlGroupBox.ResumeLayout(false);
			this.ControlGroupBox.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.StatsContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStripEx BotMenu;
		private System.Windows.Forms.ToolStripMenuItem FileSubMenu;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.Button RunBtn;
		private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RecentSubMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.StatusStrip BotStatusStrip;
		private System.Windows.Forms.GroupBox ControlsBox;
		private System.Windows.Forms.Panel ControlProbabilityPanel;
		private System.Windows.Forms.GroupBox BestGroupBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label AttemptsLabel;
		private System.Windows.Forms.Label FramesLabel;
		private System.Windows.Forms.ToolStripMenuItem OptionsSubMenu;
		private System.Windows.Forms.GroupBox GoalGroupBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private HexTextBox TieBreaker1Box;
		private HexTextBox TieBreaker2Box;
		private HexTextBox TieBreaker3Box;
		private System.Windows.Forms.Label label5;
		private HexTextBox MaximizeAddressBox;
		private System.Windows.Forms.Label maximizeLabeltext;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown FrameLengthNumeric;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button StopBtn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox StartFromSlotBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox BestTieBreak3Box;
		private System.Windows.Forms.TextBox BestTieBreak2Box;
		private System.Windows.Forms.TextBox BestTieBreak1Box;
		private System.Windows.Forms.TextBox BestMaximizeBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label BestAttemptNumberLabel;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label BestAttemptLogLabel;
		private System.Windows.Forms.Button ClearBestButton;
		private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
		private System.Windows.Forms.Button PlayBestButton;
		private System.Windows.Forms.ToolStripStatusLabel MessageLabel;
		private System.Windows.Forms.GroupBox ControlGroupBox;
		private System.Windows.Forms.ToolStripMenuItem TurboWhileBottingMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MemoryDomainsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ContextMenuStrip StatsContextMenu;
		private System.Windows.Forms.ToolStripMenuItem ClearStatsContextMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel BotStatusButton;
		private System.Windows.Forms.ToolStripMenuItem BigEndianMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem DataSizeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _1ByteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _2ByteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _4ByteMenuItem;
	}
}