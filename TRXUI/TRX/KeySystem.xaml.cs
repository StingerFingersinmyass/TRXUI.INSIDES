using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.IO;
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
	public partial class KeySystem : AcrylicWindow
	{
		private IEasingFunction Smooth { get; set; } = new QuarticEase
		{
			EasingMode = EasingMode.EaseInOut
		};

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

		public KeySystem()
		{
			string keyFile = "key.dat";
			try
			{
				if (File.Exists(keyFile) && !string.IsNullOrEmpty(File.ReadAllText(keyFile)))
				{
					new MainWindow().Show();
					base.Hide();
					return;
				}
			}
			catch { /* игнориру€ ошибки просто показать меню ключа */ }

			ResourceDictionaryEx.GlobalTheme = new ElementTheme?(ElementTheme.Dark);
			this.InitializeComponent();
			this.keyLbl.Opacity = 0.0;
			this.keyPb.Opacity = 0.0;
			this.okBtn.Opacity = 0.0;
			this.getkeyBtn.Opacity = 0.0;
			this.exitBtn.Opacity = 0.0;
			this.minBtn.Opacity = 0.0;
			this.StartAnimations();
		}

		private void AcrylicWindow_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}

		private void minBtn_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		private void getkeyBtn_Click(object sender, RoutedEventArgs e)
		{
			functions.Msg("This feature is disabled.", "Get Key");
		}

		private void AntiFiddler()
		{
			WebRequest.DefaultWebProxy = new WebProxy();
		}

		public bool CheckKey(string key)
		{
			return !string.IsNullOrEmpty(key);
		}

		private void okBtn_Click(object sender, RoutedEventArgs e)
		{
			if (this.CheckKey(this.keyPb.Password))
			{
				try
				{
					File.WriteAllText("key.dat", this.keyPb.Password);
					new MainWindow().Show();
					base.Hide();
					return;
				}
				catch (Exception ex)
				{
					functions.Msg($"Failed to save key: {ex.Message}", "Error");
					return;
				}
			}
			functions.Msg("Invalid key!", "Key System");
		}
	}
}
