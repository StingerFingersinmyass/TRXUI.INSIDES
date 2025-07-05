using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using SourceChord.FluentWPF;

namespace TRX
{
	// Token: 0x0200000B RID: 11
	public partial class msgBox : AcrylicWindow
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002211 File Offset: 0x00000411
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002219 File Offset: 0x00000419
		private IEasingFunction Smooth { get; set; } = new QuarticEase
		{
			EasingMode = EasingMode.EaseInOut
		};

		// Token: 0x06000040 RID: 64 RVA: 0x00003FBC File Offset: 0x000021BC
		public void ObjectShift(DependencyObject Object, Thickness Get, Thickness Set)
		{
			Storyboard storyboard = new Storyboard();
			ThicknessAnimation thicknessAnimation = new ThicknessAnimation
			{
				From = new Thickness?(Get),
				To = new Thickness?(Set),
				Duration = TimeSpan.FromSeconds(1.0),
				EasingFunction = this.Smooth
			};
			Storyboard.SetTarget(thicknessAnimation, Object);
			Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(FrameworkElement.MarginProperty));
			storyboard.Children.Add(thicknessAnimation);
			storyboard.Begin();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000029D8 File Offset: 0x00000BD8
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

		// Token: 0x06000042 RID: 66 RVA: 0x0000403C File Offset: 0x0000223C
		public msgBox(string text, string title = "TRX Message")
		{
			try
			{
				ResourceDictionaryEx.GlobalTheme = new ElementTheme?(ElementTheme.Dark);
				this.InitializeComponent();
				ResourceDictionaryEx.GlobalTheme = new ElementTheme?(ElementTheme.Dark);
				base.Title = functions.RandomString(16);
				this.textLbl.Content = text;
				this.titleLbl.Content = title;
				int num = this.textLbl.Content.ToString().ToLower().Split(new char[] { '\n' })
					.Count<string>();
				if (num == 0)
				{
					num = 1;
				}
				base.Height = (double)(num * 20 + 117);
				this.Fade(this.textLbl);
				this.Fade(this.titleLbl);
				this.Fade(this.logoImg);
				this.Fade(this.linkLbl);
				this.Fade(this.okBtn);
				this.Fade(this.exitBtn);
				this.ObjectShift(this.textLbl, new Thickness(-448.0, 67.0, 0.0, 0.0), this.textLbl.Margin);
				this.ObjectShift(this.titleLbl, new Thickness(80.0, 12.0, 0.0, 0.0), this.titleLbl.Margin);
				this.ObjectShift(this.logoImg, new Thickness(6.0, -1.0, 0.0, 0.0), this.logoImg.Margin);
				this.ObjectShift(this.linkLbl, new Thickness(10.0, 0.0, 0.0, -35.0), this.linkLbl.Margin);
				this.ObjectShift(this.okBtn, new Thickness(0.0, 0.0, 11.0, -30.0), this.okBtn.Margin);
				this.ObjectShift(this.exitBtn, new Thickness(0.0, 0.0, -42.0, 0.0), this.exitBtn.Margin);
			}
			catch (Exception ex)
			{
				Clipboard.SetText(ex.ToString());
				MessageBox.Show("Error copied!\nTRX Messages module error.\nPlease send this to helpers on our Discord server!", "TRX");
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002061 File Offset: 0x00000261
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002076 File Offset: 0x00000276
		private void AcrylicWindow_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002061 File Offset: 0x00000261
		private void okBtn_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002069 File Offset: 0x00000269
		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://trx-roblox.com");
		}
	}
}
