using DLLManager;
using SeliwareAPI;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using TRX.Properties;

namespace TRX
{
	// Token: 0x02000007 RID: 7
	internal class functions
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000211E File Offset: 0x0000031E
		public static string RandomString(int length)
		{
			return new string((from s in global::System.Linq.Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwpxyz", length)
				select s[global::TRX.functions.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002159 File Offset: 0x00000359
		public static void Msg(string text, string title = "TRX Message")
		{
			new global::TRX.msgBox(text, title).ShowDialog();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000381C File Offset: 0x00001A1C
		public static void PopulateListBox(global::System.Windows.Controls.ListBox lsb, string Folder, string FileType)
		{
			foreach (global::System.IO.FileInfo fileInfo in new global::System.IO.DirectoryInfo(Folder).GetFiles(FileType))
			{
				lsb.Items.Add(fileInfo.Name);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000385C File Offset: 0x00001A5C
		public void Execute(string script)
        {
            if (global::System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
            {
                global::TRX.functions.Msg("Roblox isn't opened!", "DLL Manager");
                return;
            }
            if (Seliware.IsInjected())
            {
                Seliware.Execute(script);
            }
        }

        // Token: 0x06000028 RID: 40 RVA: 0x00002168 File Offset: 0x00000368
        public functions()
		{
		}

        // Token: 0x06000029 RID: 41 RVA: 0x000021A7 File Offset: 0x000003A7
        // маркировка 'beforefieldinit'
        static functions()
		{
		}

		// Token: 0x0400001F RID: 31
		private global::ManagerEX exApi = new global::ManagerEX();

		// Token: 0x04000020 RID: 32
		private global::DLLManager.ManagerWRD wrdApi = new global::DLLManager.ManagerWRD();

		// Token: 0x04000021 RID: 33
		private global::DLLManager.ManagerKRNL krnlApi = new global::DLLManager.ManagerKRNL();

		// Token: 0x04000022 RID: 34
		private global::DLLManager.ManagerELECTRON electronAPI = new global::DLLManager.ManagerELECTRON();

		// Token: 0x04000023 RID: 35
		private global::ManagerFLUXUS fluxusAPI = new global::ManagerFLUXUS();

		// Token: 0x04000024 RID: 36
		private static global::System.Random random = new global::System.Random();

		// Token: 0x04000025 RID: 37
		public static string ver = "1.9.7.3";
	}
}
