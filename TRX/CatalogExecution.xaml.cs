using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using DLLManager;
using SourceChord.FluentWPF;

namespace TRX
{
	// Token: 0x02000003 RID: 3
	public partial class CatalogExecution : AcrylicWindow
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002086 File Offset: 0x00000286
		private void AntiFiddler()
		{
			WebRequest.DefaultWebProxy = new WebProxy();
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002092 File Offset: 0x00000292
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000209A File Offset: 0x0000029A
		private IEasingFunction Smooth { get; set; } = new QuarticEase
		{
			EasingMode = EasingMode.EaseInOut
		};

		// Token: 0x06000011 RID: 17 RVA: 0x000031C8 File Offset: 0x000013C8
		public void ObjectShift(DependencyObject Object, Thickness Get, Thickness Set)
		{
			ThicknessAnimation thicknessAnimation = new ThicknessAnimation
			{
				From = new Thickness?(Get),
				To = new Thickness?(Set),
				Duration = this.dur2,
				EasingFunction = this.Smooth
			};
			Storyboard.SetTarget(thicknessAnimation, Object);
			Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(FrameworkElement.MarginProperty));
			this.Sb.Children.Add(thicknessAnimation);
			this.Sb.Begin();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029D8 File Offset: 0x00000BD8
		public void Fade(DependencyObject Object)
		{
			Storyboard storyboard = new Storyboard();
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				From = new double?(0.5),
				To = new double?(1.0),
				Duration = new Duration(TimeSpan.FromSeconds(1.0))
			};
			Storyboard.SetTarget(doubleAnimation, Object);
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity", new object[] { 1 }));
			storyboard.Children.Add(doubleAnimation);
			storyboard.Begin();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003244 File Offset: 0x00001444
		private void StartAnimations()
		{
			this.Fade(this.img);
			this.Fade(this.titleLbl);
			this.Fade(this.descLbl);
			this.Fade(this.exitBtn);
			this.Fade(this.idtxt);
			this.Fade(this.execbtn);
			this.Fade(this.catalogBtn);
			this.ObjectShift(this.img, new Thickness(-213.0, 10.0, 0.0, 0.0), this.img.Margin);
			this.ObjectShift(this.titleLbl, new Thickness(-150.0, 10.0, 0.0, 0.0), this.titleLbl.Margin);
			this.ObjectShift(this.descLbl, new Thickness(-150.0, 34.0, 0.0, 0.0), this.descLbl.Margin);
			this.ObjectShift(this.exitBtn, new Thickness(0.0, 3.0, -52.0, 0.0), this.exitBtn.Margin);
			this.ObjectShift(this.idtxt, new Thickness(11.0, 164.0, 9.0, -65.0), this.idtxt.Margin);
			this.ObjectShift(this.execbtn, new Thickness(12.0, 208.0, 0.0, -106.0), this.execbtn.Margin);
			this.ObjectShift(this.catalogBtn, new Thickness(321.0, 208.0, 0.0, -106.0), this.catalogBtn.Margin);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003468 File Offset: 0x00001668
		public CatalogExecution()
		{
			this.InitializeComponent();
			this.StartAnimations();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002076 File Offset: 0x00000276
		private void AcrylicWindow_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020A3 File Offset: 0x000002A3
		private void idtxt_GotFocus(object sender, RoutedEventArgs e)
		{
			this.idtxt.Text = "";
			this.idtxt.Foreground = Brushes.White;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000034E4 File Offset: 0x000016E4
		private void execbtn_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(this.idtxt.Text))
			{
				functions.Msg("Sorry, but the id box is empty.", "Script Catalog");
				return;
			}
			if (!this.exApi.isInjected() && !this.wrdApi.isAPIAttached() && !this.krnlApi.IsInjected() && !ManagerELECTRON.NamedPipeExist() && !ManagerFLUXUS.NamedPipeExist("fluxus_send_pipe"))
			{
				functions.Msg("Please inject!", "DLL Manager");
				return;
			}
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			this.AntiFiddler();
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; WlNDOWS NT 5.2; .NET CLR 1.0.3705;)");
			webClient.Proxy = null;
			string text = webClient.DownloadString("https://trx-roblox.com/scripts/api/script/TRX_ok3wxHybGUk5kSRu/" + this.idtxt.Text);
			if (text == "err")
			{
				functions.Msg("Unknown script!", "DLL Manager");
			}
			else
			{
				this.func.Execute(text);
			}
			webClient.Dispose();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020C5 File Offset: 0x000002C5
		private void catalogBtn_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://scripts.trx-roblox.com");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020D2 File Offset: 0x000002D2
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
			base.Hide();
		}

		// Token: 0x0400000F RID: 15
		private functions func = new functions();

		// Token: 0x04000010 RID: 16
		private ManagerEX exApi = new ManagerEX();

		// Token: 0x04000011 RID: 17
		private ManagerWRD wrdApi = new ManagerWRD();

		// Token: 0x04000012 RID: 18
		private ManagerKRNL krnlApi = new ManagerKRNL();

		// Token: 0x04000013 RID: 19
		private TimeSpan dur2 = TimeSpan.FromMilliseconds(800.0);

		// Token: 0x04000014 RID: 20
		private Storyboard Sb = new Storyboard();
	}
}
