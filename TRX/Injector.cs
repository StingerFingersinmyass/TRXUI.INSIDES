using SeliwareAPI;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;

namespace TRX
{
	// Token: 0x02000004 RID: 4
	public class Injector
	{
		// Token: 0x0600001C RID: 28
		[global::System.Runtime.InteropServices.DllImport("Bin\\TRXInjector.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void trx_injection(string dll_name);

		// Token: 0x0600001D RID: 29 RVA: 0x000020E0 File Offset: 0x000002E0
		public static int GetProcessId(string proc)
		{
			return global::System.Diagnostics.Process.GetProcessesByName(proc)[0].Id;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003718 File Offset: 0x00001918
		public bool Inject(string dllPath)
		{
			bool flag;
			try
			{
				if (global::TRX.Injector.GetProcessId("RobloxPlayerBeta") >= 1)
				{
                    Seliware.Inject();
                    flag = true;
				}
				else
				{
					flag = false;
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Windows.MessageBox.Show(string.Format("Unknown inject error :(\n{0}", ex), "TRX Injector");
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020EF File Offset: 0x000002EF
		public Injector()
		{
		}
	}
}
