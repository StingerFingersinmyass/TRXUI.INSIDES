using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using SourceChord.FluentWPF;

namespace TRX
{
	// Token: 0x0200000C RID: 12
	public partial class ScriptSave : AcrylicWindow
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002222 File Offset: 0x00000422
		public ScriptSave(string script)
		{
			this.InitializeComponent();
			this.Script = script;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000043FC File Offset: 0x000025FC
		private void okBtn_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(this.Script))
			{
				functions.Msg("Sorry, but the script editor is empty.", "Script Saver");
				return;
			}
			new MainWindow();
			if (!File.Exists(".\\Scripts\\" + this.nameTB.Text + ".lua"))
			{
				string text = ".\\Scripts\\" + this.nameTB.Text + ".lua";
				try
				{
					using (FileStream fileStream = File.Create(text))
					{
						byte[] bytes = new UTF8Encoding(true).GetBytes(this.Script);
						fileStream.Write(bytes, 0, bytes.Length);
					}
				}
				catch (Exception)
				{
				}
				foreach (object obj in Application.Current.Windows)
				{
					Window window = (Window)obj;
					if (window.GetType() == typeof(MainWindow))
					{
						(window as MainWindow).scriptBox.Items.Clear();
						functions.PopulateListBox((window as MainWindow).scriptBox, "./Scripts", "*.txt");
						functions.PopulateListBox((window as MainWindow).scriptBox, "./Scripts", "*.lua");
					}
				}
				functions.Msg("Script saved!", "Script Saver");
				return;
			}
			functions.Msg("Sorry, but script with this name already exists.", "Script Saver");
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002061 File Offset: 0x00000261
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002076 File Offset: 0x00000276
		private void AcrylicWindow_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002069 File Offset: 0x00000269
		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://trx-roblox.com");
		}

		// Token: 0x0400003F RID: 63
		private functions func = new functions();

		// Token: 0x04000040 RID: 64
		private string Script;
	}
}
