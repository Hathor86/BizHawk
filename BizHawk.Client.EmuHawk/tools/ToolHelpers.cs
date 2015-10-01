﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using BizHawk.Emulation.Common;
using BizHawk.Emulation.Common.IEmulatorExtensions;

using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk.WinFormExtensions;

namespace BizHawk.Client.EmuHawk
{
	public static class ToolHelpers
	{
		public static FileInfo OpenFileDialog(string currentFile, string path, string fileType, string fileExt)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			var ofd = new OpenFileDialog
			{
				FileName = !string.IsNullOrWhiteSpace(currentFile)
					? Path.GetFileName(currentFile)
					: PathManager.FilesystemSafeName(Global.Game) + "." + fileExt,
				InitialDirectory = path,
				Filter = string.Format("{0} (*.{1})|*.{1}|All Files|*.*", fileType, fileExt),
				RestoreDirectory = true
			};

			var result = ofd.ShowHawkDialog();
			if (result != DialogResult.OK)
			{
				return null;
			}

			return new FileInfo(ofd.FileName);
		}

		public static FileInfo SaveFileDialog(string currentFile, string path, string fileType, string fileExt)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			var sfd = new SaveFileDialog
			{
				FileName = !string.IsNullOrWhiteSpace(currentFile)
					? Path.GetFileName(currentFile)
					: PathManager.FilesystemSafeName(Global.Game) + "." + fileExt,
				InitialDirectory = path,
				Filter = string.Format("{0} (*.{1})|*.{1}|All Files|*.*", fileType, fileExt),
				RestoreDirectory = true,
			};

			var result = sfd.ShowHawkDialog();
			if (result != DialogResult.OK)
			{
				return null;
			}

			return new FileInfo(sfd.FileName);
		}

		public static FileInfo GetWatchFileFromUser(string currentFile)
		{
			return OpenFileDialog(currentFile, PathManager.MakeAbsolutePath(Global.Config.PathEntries.WatchPathFragment, null), "Watch Files", "wch");
		}

		public static FileInfo GetWatchSaveFileFromUser(string currentFile)
		{
			return SaveFileDialog(currentFile, PathManager.MakeAbsolutePath(Global.Config.PathEntries.WatchPathFragment, null), "Watch Files", "wch");
        }

		public static void UpdateCheatRelatedTools(object sender, CheatCollection.CheatListEventArgs e)
		{
			if (Global.Emulator.HasMemoryDomains())
			{
				GlobalWin.Tools.UpdateValues<RamWatch>();
				GlobalWin.Tools.UpdateValues<RamSearch>();
				GlobalWin.Tools.UpdateValues<HexEditor>();

				if (GlobalWin.Tools.Has<Cheats>())
				{
					GlobalWin.Tools.Cheats.UpdateDialog();
				}

				GlobalWin.MainForm.UpdateCheatStatus();
			}
		}

		public static void ViewInHexEditor(MemoryDomain domain, IEnumerable<long> addresses, Watch.WatchSize size)
		{
			GlobalWin.Tools.Load<HexEditor>();
			GlobalWin.Tools.HexEditor.SetToAddresses(addresses, domain, size);
		}
	}
}
