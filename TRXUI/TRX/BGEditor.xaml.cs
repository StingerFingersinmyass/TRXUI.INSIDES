using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using SourceChord.FluentWPF;


namespace TRX
{
	// Token: 0x02000002 RID: 2
	public partial class BGEditor : AcrylicWindow
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		private IEasingFunction Smooth { get; set; } = new QuarticEase
		{
			EasingMode = EasingMode.EaseInOut
		};

		// Token: 0x06000003 RID: 3 RVA: 0x0000295C File Offset: 0x00000B5C
		public void ObjectShift(DependencyObject Object, Thickness Get, Thickness Set)
		{
			ThicknessAnimation thicknessAnimation = new ThicknessAnimation
			{
				From = new Thickness?(Get),
				To = new Thickness?(Set),
				Duration = this.dur,
				EasingFunction = this.Smooth
			};
			Storyboard.SetTarget(thicknessAnimation, Object);
			Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(FrameworkElement.MarginProperty));
			this.Sb.Children.Add(thicknessAnimation);
			this.Sb.Begin();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000029D8 File Offset: 0x00000BD8
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

		// Token: 0x06000005 RID: 5 RVA: 0x00002A6C File Offset: 0x00000C6C
		private void StartAnimations()
		{
			this.Fade(this.textLbl);
			this.Fade(this.urlTB);
			this.Fade(this.descLbl);
			this.Fade(this.opacitySlider);
			this.Fade(this.valueLbl);
			this.Fade(this.okBtn);
			this.Fade(this.valueLbl);
			this.ObjectShift(this.textLbl, new Thickness(-481.0, 67.0, 0.0, 0.0), this.textLbl.Margin);
			this.ObjectShift(this.urlTB, new Thickness(-478.0, 103.0, 0.0, 0.0), this.urlTB.Margin);
			this.ObjectShift(this.descLbl, new Thickness(-481.0, 138.0, 0.0, 0.0), this.descLbl.Margin);
			this.ObjectShift(this.opacitySlider, new Thickness(-482.0, 177.0, 0.0, 0.0), this.opacitySlider.Margin);
			this.ObjectShift(this.valueLbl, new Thickness(-69.0, 170.0, 0.0, 0.0), this.valueLbl.Margin);
			this.ObjectShift(this.okBtn, new Thickness(372.0, 287.0, 0.0, -60.0), this.okBtn.Margin);
			this.ObjectShift(this.linkLbl, new Thickness(3.0, 286.0, 0.0, -64.0), this.linkLbl.Margin);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002C90 File Offset: 0x00000E90
		public BGEditor()
		{
			this.InitializeComponent();
			this.StartAnimations();
			try
			{
				this.urlTB.Text = UserSettings.customBg;
				this.opacitySlider.Value = UserSettings.bgOpacity;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002061 File Offset: 0x00000261
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002D20 File Offset: 0x00000F20
		private void okBtn_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				string url = this.urlTB.Text.Trim();
				if (string.IsNullOrEmpty(url))
				{
					foreach (object obj in Application.Current.Windows)
					{
						if (obj is MainWindow window)
						{
							window.CustomBg.Source = null;
							window.CustomBg.Opacity = 1.0;
						}
					}
					UserSettings.customBg = "";
					UserSettings.bgOpacity = 1.0;
					UserSettings.Save();
					functions.Msg("The background has been reset!", "Background Editor");
				}
				else
				{
					string text = url.Replace("https:", "http:");
					foreach (object obj2 in Application.Current.Windows)
					{
						if (obj2 is MainWindow window2)
						{
							window2.CustomBg.Source = new Uri(text, UriKind.Absolute);
							window2.CustomBg.Opacity = this.opacitySlider.Value;
						}
					}
					UserSettings.bgOpacity = this.opacitySlider.Value;
					UserSettings.customBg = text;
					UserSettings.Save();
					functions.Msg("Background applied and saved!", "Background Editor");
				}
			}
			catch (Exception)
			{
				foreach (object obj3 in Application.Current.Windows)
				{
					if (obj3 is MainWindow window3)
					{
						window3.CustomBg.Source = null;
						window3.CustomBg.Opacity = 1.0;
					}
				}
				UserSettings.customBg = "";
				UserSettings.bgOpacity = 1.0;
				UserSettings.Save();
				functions.Msg("Invalid URL. The background has been reset.", "Background Editor");
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002069 File Offset: 0x00000269
		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://trx-roblox.com");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002076 File Offset: 0x00000276
		private void AcrylicWindow_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000300C File Offset: 0x0000120C
		private void opacitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (this.valueLbl != null)
			{
				this.valueLbl.Content = (this.opacitySlider.Value * 100.0).ToString() + "%";
			}
		}

		// Token: 0x04000001 RID: 1
		private TimeSpan dur = TimeSpan.FromMilliseconds(1400.0);

		// Token: 0x04000002 RID: 2
		private Storyboard Sb = new Storyboard();
	}
}
