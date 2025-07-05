using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using SourceChord.FluentWPF;
using TRX.Properties;

namespace TRX
{
	// Token: 0x02000009 RID: 9
	public partial class KeySystem : AcrylicWindow
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000021E1 File Offset: 0x000003E1
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000021E9 File Offset: 0x000003E9
		private IEasingFunction Smooth { get; set; } = new QuarticEase
		{
			EasingMode = EasingMode.EaseInOut
		};

		// Token: 0x0600002F RID: 47 RVA: 0x00003944 File Offset: 0x00001B44
		public void ObjectShift(DependencyObject Object, Thickness Get, Thickness Set)
		{
			Storyboard storyboard = new Storyboard();
			ThicknessAnimation thicknessAnimation = new ThicknessAnimation
			{
				From = new Thickness?(Get),
				To = new Thickness?(Set),
				Duration = TimeSpan.FromSeconds(2.0),
				EasingFunction = this.Smooth
			};
			Storyboard.SetTarget(thicknessAnimation, Object);
			Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(FrameworkElement.MarginProperty));
			storyboard.Children.Add(thicknessAnimation);
			storyboard.Begin();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000039C4 File Offset: 0x00001BC4
		public void Fade(DependencyObject Object)
		{
			Storyboard storyboard = new Storyboard();
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				From = new double?(0.2),
				To = new double?(1.0),
				Duration = new Duration(TimeSpan.FromMilliseconds(2500.0))
			};
			Storyboard.SetTarget(doubleAnimation, Object);
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity", new object[] { 1 }));
			storyboard.Children.Add(doubleAnimation);
			storyboard.Begin();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003A58 File Offset: 0x00001C58
		private async void StartAnimations()
		{
			await Task.Delay(1000);
			this.Fade(this.exitBtn);
			this.Fade(this.minBtn);
			this.ObjectShift(this.keyLbl, new Thickness(408.0, 356.0, 0.0, -37.0), this.keyLbl.Margin);
			this.ObjectShift(this.keyPb, new Thickness(409.0, 388.0, 0.0, -72.0), this.keyPb.Margin);
			this.ObjectShift(this.okBtn, new Thickness(409.0, 0.0, 0.0, -121.0), this.okBtn.Margin);
			this.ObjectShift(this.getkeyBtn, new Thickness(409.0, 0.0, 0.0, -170.0), this.getkeyBtn.Margin);
			this.Fade(this.keyLbl);
			this.Fade(this.keyPb);
			this.Fade(this.okBtn);
			this.Fade(this.getkeyBtn);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003A90 File Offset: 0x00001C90
		public KeySystem()
		{
			if (!this.CheckKey(Settings.Default.key))
			{
				ResourceDictionaryEx.GlobalTheme = new ElementTheme?(ElementTheme.Dark);
				this.InitializeComponent();
				this.keyLbl.Opacity = 0.0;
				this.keyPb.Opacity = 0.0;
				this.okBtn.Opacity = 0.0;
				this.getkeyBtn.Opacity = 0.0;
				this.exitBtn.Opacity = 0.0;
				this.minBtn.Opacity = 0.0;
				this.StartAnimations();
				return;
			}
			new MainWindow().Show();
			base.Hide();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002076 File Offset: 0x00000276
		private void AcrylicWindow_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021F2 File Offset: 0x000003F2
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021FA File Offset: 0x000003FA
		private void minBtn_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003B6C File Offset: 0x00001D6C
		private void getkeyBtn_Click(object sender, RoutedEventArgs e)
		{
			string text = "https://trx-roblox.com/api/key/checkpoint";
			try
			{
				Process.Start(text);
			}
			catch (Exception)
			{
				Clipboard.SetText(text);
				functions.Msg("An unknown error occurred,\nso we copied your key-link to the clipboard.", "GetKey error!");
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002086 File Offset: 0x00000286
		private void AntiFiddler()
		{
			WebRequest.DefaultWebProxy = new WebProxy();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public bool CheckKey(string key)
		{
			this.AntiFiddler();
			WebClient webClient = new WebClient();
			string text = "https://trx-roblox.com/api/key/test?key=";
			return webClient.DownloadString(text + key) == "valid";
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003BEC File Offset: 0x00001DEC
		private void okBtn_Click(object sender, RoutedEventArgs e)
		{
			if (this.CheckKey(this.keyPb.Password))
			{
				Settings.Default.key = this.keyPb.Password;
				Settings.Default.Save();
				new MainWindow().Show();
				base.Hide();
				return;
			}
			functions.Msg("Invalid key!", "Key System");
		}
	}
}
