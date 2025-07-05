using DiscordRPC;
using DLLManager;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Microsoft.Win32;
using SeliwareAPI;
using SourceChord.FluentWPF;
using System;
using System.Linq;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Xml;
using System.IO;
using TRX.Properties;

namespace TRX
{
	// Token: 0x0200000F RID: 15
	public partial class MainWindow : AcrylicWindow
	{
		private DispatcherTimer autoAttachTimer;
		private bool isInjecting = false;
		private DispatcherTimer titleUpdateTimer;
		private int dotAnimationCounter = 0;
		private string _randomTitlePart;
		private int customInjectedCount = 0;
		private System.Collections.Generic.List<int> knownRobloxPids = new System.Collections.Generic.List<int>();
		

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000022BF File Offset: 0x000004BF
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000022C7 File Offset: 0x000004C7
		private IEasingFunction Smooth { get; set; } = new QuarticEase
		{
			EasingMode = EasingMode.EaseInOut
		};

		// Token: 0x06000059 RID: 89 RVA: 0x00004748 File Offset: 0x00002948
		public void Fade(DependencyObject Object, TimeSpan time, double from)
		{
			Storyboard storyboard = new Storyboard();
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				From = new double?(from),
				To = new double?(1.0),
				Duration = new Duration(time)
			};
			Storyboard.SetTarget(doubleAnimation, Object);
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity", new object[] { 1 }));
			storyboard.Children.Add(doubleAnimation);
			storyboard.Begin();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000047C8 File Offset: 0x000029C8
		public void UnFade(DependencyObject Object)
		{
			Storyboard storyboard = new Storyboard();
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				From = new double?(1.0),
				To = new double?(0.5),
				Duration = new Duration(TimeSpan.FromMilliseconds(800.0))
			};
			Storyboard.SetTarget(doubleAnimation, Object);
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity", new object[] { 1 }));
			storyboard.Children.Add(doubleAnimation);
			storyboard.Begin();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000485C File Offset: 0x00002A5C
		public void ObjectShift(DependencyObject Object, Thickness Get, Thickness Set)
		{
			Storyboard storyboard = new Storyboard();
			ThicknessAnimation thicknessAnimation = new ThicknessAnimation
			{
				From = new Thickness?(Get),
				To = new Thickness?(Set),
				Duration = TimeSpan.FromSeconds(3.0),
				EasingFunction = this.Smooth
			};
			Storyboard.SetTarget(thicknessAnimation, Object);
			Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(FrameworkElement.MarginProperty));
			storyboard.Children.Add(thicknessAnimation);
			storyboard.Begin();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000048DC File Offset: 0x00002ADC
		public void FadeImg(DependencyObject Object)
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				From = new double?(0.5),
				To = new double?(0.05),
				Duration = new Duration(TimeSpan.FromSeconds(2.0))
			};
			Storyboard.SetTarget(doubleAnimation, Object);
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity", new object[] { 1 }));
			new Storyboard
			{
				Children = { doubleAnimation }
			}.Begin();
		}

        // Token: 0x0600005D RID: 93 RVA: 0x0000496C File Offset: 0x00002B6C
        public void Init()
        {
            MainWindow.AppWindow = this;
            string version = System.Text.RegularExpressions.Regex.Match(Seliware.GetVersion(), @"\d+\.\d+\.\d+(\.\d+)?").Value;
            this._randomTitlePart = functions.RandomString(8);
            base.Title = "TRX v" + version + " | " + this._randomTitlePart;
            if (!Directory.Exists(".\\SavedTabs"))
            {
                Directory.CreateDirectory(".\\SavedTabs");
            }
            if (UserSettings.SelectedDLL > 5)
            {
                UserSettings.SelectedDLL = 1;
            }
            this.FadeImg(this.imgBg);
            this.ObjectShift(this.EditorTabs, new Thickness(-567.0, 68.0, 700.0, 39.0), new Thickness(8.0, 68.0, 159.0, 39.0));
            this.ObjectShift(this.scriptBox, new Thickness(0.0, 68.0, -233.0, 10.0), new Thickness(0.0, 68.0, 10.0, 10.0));
            this.ObjectShift(this.navigatorPnl, new Thickness(246.0, -128.0, 246.0, 0.0), new Thickness(246.0, 7.0, 246.0, 0.0));
            this.ObjectShift(this.scripthubBtn, new Thickness(246.0, -128.0, 378.0, 0.0), new Thickness(246.0, 7.0, 378.0, 0.0));
            this.ObjectShift(this.creditsBtn, new Thickness(314.0, -128.0, 312.0, 0.0), new Thickness(314.0, 7.0, 312.0, 0.0));
            this.ObjectShift(this.injectBtn, new Thickness(380.0, -128.0, 246.0, 0.0), new Thickness(380.0, 7.0, 246.0, 0.0));
            this.ObjectShift(this.dllchange, new Thickness(748.0, 25.0, -171.0, 0.0), new Thickness(0.0, 25.0, 12.0, 0.0));
            this.ObjectShift(this.dllchangerPnl, new Thickness(719.0, 25.0, -171.0, 0.0), new Thickness(0.0, 25.0, 12.0, 0.0));
            DiscordRpcClient discordRpcClient = new DiscordRpcClient("876020972333957161");
            discordRpcClient.Initialize();
            discordRpcClient.SetPresence(new RichPresence
            {
                Details = "Best ROBLOX exploit",
                State = "seliware.com",
                Assets = new Assets
                {
                    LargeImageKey = "trx",
                    LargeImageText = "What are you waiting for? Download now!"
                },
                Buttons = new global::DiscordRPC.Button[]
                {
                    new global::DiscordRPC.Button
                    {
                        Label = "Download TRX",
                        Url = "https://github.com/StingerFingersinmyass/TRXUI"
                    }
                }
            });
            MainWindow.Instance = this;
            this.EditorTabs.Loaded += (object s, RoutedEventArgs ev) =>
            {
                this.EditorTabs.GetTemplateChild<System.Windows.Controls.Button>("AddTabButton").Click += (object s2, RoutedEventArgs ev2) =>
                {
                    this.MakeTab("", "Tab #" + this.EditorTabs.Items.Count.ToString());
                };
                this.tabScroller = this.EditorTabs.GetTemplateChild<ScrollViewer>("TabScrollViewer");
            };
            this.OutputTab.Tag = false;
            int num = 0;
            this.TextEditor.TextArea.TextView.ElementGenerators.Add(new TruncateLongLines());
            foreach (FileInfo fileInfo in new DirectoryInfo(".\\SavedTabs").GetFiles())
            {
                num++;
                string text = fileInfo.Name;
                text = text.Replace("_", " ");
                this.MakeTab(File.ReadAllText(".\\SavedTabs\\" + fileInfo.Name), text);
            }
            if (num == 0)
            {
                this.MakeTab("", "Tab #1");
            }
            this.TextEditor.TextChanged += (object s, EventArgs ev) =>
            {
                this.TextEditor.ScrollToEnd();
            };
            if (UserSettings.TopMost)
            {
                base.Topmost = true;
                this.topmostItem.IsChecked = true;
            }
            else
            {
                base.Topmost = false;
                this.topmostItem.IsChecked = false;
            }
            if (UserSettings.AutoOpacity)
            {
                base.Opacity = 0.5;
                this.autoopacityItem.IsChecked = true;
            }
            else
            {
                base.Opacity = 1.0;
                this.autoopacityItem.IsChecked = false;
            }
            if (UserSettings.hideBg)
            {
                this.imgBg.Visibility = Visibility.Hidden;
                this.hidelogoItem.IsChecked = true;
            }
            functions.PopulateListBox(this.scriptBox, "./Scripts", "*.txt");
            functions.PopulateListBox(this.scriptBox, "./Scripts", "*.lua");

            this.autoAttachTimer = new DispatcherTimer();
            this.autoAttachTimer.Interval = TimeSpan.FromSeconds(3.0);
            this.autoAttachTimer.Tick += new EventHandler(this.AutoAttachTimer_Tick);

            this.AutoAttachMenuItem.IsChecked = UserSettings.AutoAttach;
            if (UserSettings.AutoAttach)
            {
                this.autoAttachTimer.Start();
            }


            if (UserSettings.customBg != "")
            {
                try
                {
                    this.CustomBg.Source = new Uri(UserSettings.customBg, UriKind.Absolute);
                    this.CustomBg.Opacity = UserSettings.bgOpacity;
                }
                catch (Exception)
                {
                    functions.Msg("Oops...\nFailed to load image to background.\n\nWe reset your image.", "BG Editor");
                    UserSettings.bgOpacity = 1.0;
                    UserSettings.customBg = "";
                }
            }
        }

// Token: 0x0600005E RID: 94 RVA: 0x00004FDC File Offset: 0x000031DC
public MainWindow()
{
    UserSettings.Load();
    ResourceDictionaryEx.GlobalTheme = new ElementTheme?(ElementTheme.Dark);
    this.InitializeComponent();
    this.dllchange.SelectedIndex = 0;
            
    this.titleUpdateTimer = new DispatcherTimer();
    this.titleUpdateTimer.Tick += new EventHandler(this.timerTick);
    this.titleUpdateTimer.Interval = new TimeSpan(0, 0, 1);

    this.Init();
    this.LoadBackground();
    Seliware.Injected += OnSeliwareInjected;
}

private void LoadBackground()
{
    try
    {
        if (!string.IsNullOrEmpty(UserSettings.customBg))
        {
            this.CustomBg.Source = new Uri(UserSettings.customBg, UriKind.Absolute);
            this.CustomBg.Opacity = UserSettings.bgOpacity;
        }
    }
    catch (Exception)
    {
    }
}

// Token: 0x0600005F RID: 95 RVA: 0x0000505C File Offset: 0x0000325C
public TextEditor GetCurrent()
{
    if (this.EditorTabs.SelectedIndex == 0)
    {
        return this.current = null;
    }
    return this.current = this.EditorTabs.SelectedContent as TextEditor;
}

// Token: 0x06000060 RID: 96 RVA: 0x0000509C File Offset: 0x0000329C
public static TextEditor MakeEditor()
{
    return new TextEditor
    {
        SyntaxHighlighting = HighlightingLoader.Load(new XmlTextReader(File.OpenRead(".\\Bin\\syntax\\lua.xshd")), HighlightingManager.Instance),
        ShowLineNumbers = true,
        FontSize = 12.0,
        BorderThickness = new Thickness(1.0),
        BorderBrush = new SolidColorBrush(Color.FromRgb(43, 43, 43)),
        Background = new SolidColorBrush(Color.FromArgb(90, 29, 29, 29)),
        Foreground = new SolidColorBrush(Color.FromRgb(byte.MaxValue, byte.MaxValue, byte.MaxValue)),
        LineNumbersForeground = Brushes.LightGray,
        VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
        HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
        FontFamily = new FontFamily("Consolas")
    };
}

// Token: 0x06000061 RID: 97 RVA: 0x00005170 File Offset: 0x00003370
public TabItem MakeTab(string text = "", string title = "Tab")
{
    bool loaded = false;
    TextEditor textEditor = MainWindow.MakeEditor();
    textEditor.Text = text;
    TextBox tbox = new TextBox
    {
        Text = title,
        IsEnabled = false,
        TextWrapping = TextWrapping.NoWrap,
        IsHitTestVisible = false,
        Style = (base.TryFindResource("InvisibleTextBox") as Style)
    };
    TabItem tab = new TabItem
    {
        Content = textEditor,
        Style = (base.TryFindResource("Tab") as Style),
        Header = tbox,
        AllowDrop = true
    };
    tab.Loaded += (object s, RoutedEventArgs ev) =>
    {
        if (loaded)
        {
            return;
        }
        tab.GetTemplateChild<System.Windows.Controls.Button>("CloseButton").Click += (object s2, RoutedEventArgs ev2) =>
        {
            if (this.EditorTabs.Items.Count > 2)
            {
                this.EditorTabs.Items.Remove(tab);
            }
        };
        this.tabScroller.ScrollToRightEnd();
        loaded = true;
    };
    this.Fade(tab, TimeSpan.FromMilliseconds(800.0), 0.0);
    tab.MouseDown += (object s, MouseButtonEventArgs ev) =>
    {
        if (ev.OriginalSource is Border)
        {
            if (ev.MiddleButton == MouseButtonState.Pressed)
            {
                this.EditorTabs.Items.Remove(tab);
                return;
            }
            if (ev.RightButton == MouseButtonState.Pressed)
            {
                tbox.IsEnabled = true;
                tbox.Focus();
                tbox.SelectAll();
            }
        }
    };
    tab.MouseMove += this.MoveTab;
    tab.Drop += this.DropTab;
    string oldHeader = title;
    tbox.GotFocus += (object s, RoutedEventArgs ev) =>
    {
        oldHeader = tbox.Text;
        tbox.CaretIndex = tbox.Text.Length - 1;
    };
    tbox.KeyDown += (object s, KeyEventArgs ev) =>
    {
        Key key = ev.Key;
        if (key != Key.Return)
        {
            if (key != Key.Escape)
            {
                return;
            }
            tbox.Text = oldHeader;
        }
        tbox.IsEnabled = false;
    };
    tbox.LostFocus += (object s, RoutedEventArgs ev) =>
    {
        tbox.IsEnabled = false;
    };
    textEditor.TextArea.TextView.ElementGenerators.Add(new TruncateLongLines());
    this.EditorTabs.SelectedIndex = this.EditorTabs.Items.Add(tab);
    return tab;
}

// Token: 0x06000062 RID: 98 RVA: 0x00005324 File Offset: 0x00003524
private void MoveTab(object sender, MouseEventArgs e)
{
    TabItem tabItem = e.Source as TabItem;
    if (tabItem == null)
    {
        return;
    }
    if (Mouse.PrimaryDevice.LeftButton == MouseButtonState.Pressed)
    {
        if (VisualTreeHelper.HitTest(tabItem, Mouse.GetPosition(tabItem)).VisualHit is global::System.Windows.Controls.Button)
        {
            return;
        }
        DragDrop.DoDragDrop(tabItem, tabItem, DragDropEffects.Move);
    }
}

// Token: 0x06000063 RID: 99 RVA: 0x00005370 File Offset: 0x00003570
private void DropTab(object sender, DragEventArgs e)
{
    TabItem tabItem = e.Source as TabItem;
    if (tabItem != null)
    {
        TabItem tabItem2 = e.Data.GetData(typeof(TabItem)) as TabItem;
        if (tabItem2 != null)
        {
            if (!tabItem.Equals(tabItem2))
            {
                TabControl tabControl = tabItem.Parent as TabControl;
                int num = tabControl.Items.IndexOf(tabItem2);
                int num2 = tabControl.Items.IndexOf(tabItem);
                tabControl.Items.Remove(tabItem2);
                tabControl.Items.Insert(num2, tabItem2);
                tabControl.Items.Remove(tabItem);
                tabControl.Items.Insert(num, tabItem);
                tabControl.SelectedIndex = num2;
            }
            return;
        }
    }
}

private void AutoAttachTimer_Tick(object sender, EventArgs e)
{
    if (UserSettings.AutoAttach)
    {
        this.injectBtn_Click(null, null);
    }
}

private void timerTick(object sender, EventArgs e)
{
    if (this.isInjecting)
    {
        string version = System.Text.RegularExpressions.Regex.Match(Seliware.GetVersion(), @"\d+\.\d+\.\d+(\.\d+)?").Value;
        this.dotAnimationCounter++;
        string dots = new string('.', (this.dotAnimationCounter % 3) + 1);
        base.Title = string.Format("TRX v{0} | Injecting{1} | {2}", version, dots, this._randomTitlePart);
    }
}

private bool Inject(string dllName = "")
{
    Injector injector = new Injector();
    bool flag;
    try
    {
        injector.Inject(dllName);
        flag = true;
    }
    catch (Exception)
    {
        flag = false;
    }
    return flag;
}

// Token: 0x06000067 RID: 103 RVA: 0x000054DC File Offset: 0x000036DC
public void antiKick()
{
    try
    {
        string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Roblox\\GlobalBasicSettings_13.xml");
        string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Roblox\\GlobalSettings_13.xml");
        if (File.Exists(text))
        {
            File.Delete(text);
        }
        if (File.Exists(text2))
        {
            File.Delete(text2);
        }
    }
    catch (Exception)
    {
    }
}

// Token: 0x06000069 RID: 105 RVA: 0x00005584 File Offset: 0x00003784
private void injectBtn_Click(object sender, RoutedEventArgs e)
{
    bool isManualClick = sender != null;
    if (this.isInjecting)
    {
        return;
    }

    var currentPids = Process.GetProcessesByName("RobloxPlayerBeta").Select(p => p.Id).ToList();

    var closedPidsCount = this.knownRobloxPids.Count(p => !currentPids.Contains(p));
    this.customInjectedCount -= closedPidsCount;
    if (this.customInjectedCount < 0)
    {
        this.customInjectedCount = 0;
    }

    this.knownRobloxPids = currentPids;

    if (currentPids.Count > this.customInjectedCount)
    {
        this.isInjecting = true;
        this.dotAnimationCounter = 0;
        this.antiKick();
        this.titleUpdateTimer.Start();
        try
        {
            if (Seliware.Inject() != "Success")
            {
                this.isInjecting = false;
                this.titleUpdateTimer.Stop();
                string version = System.Text.RegularExpressions.Regex.Match(Seliware.GetVersion(), @"\d+\.\d+\.\d+(\.\d+)?").Value;
                base.Title = "TRX v" + version + " | " + this._randomTitlePart;
            }
        }
        catch
        {
            this.isInjecting = false;
            this.titleUpdateTimer.Stop();
            string version = System.Text.RegularExpressions.Regex.Match(Seliware.GetVersion(), @"\d+\.\d+\.\d+(\.\d+)?").Value;
            base.Title = "TRX v" + version + " | " + this._randomTitlePart;
        }
    }
    else if (isManualClick)
    {
        if (currentPids.Count == 0)
        {
            functions.Msg("Roblox not found!", "Error");
        }
        else
        {
            functions.Msg("All Roblox clients are already injected.", "TRX");
        }
    }
}

// Token: 0x0600006B RID: 107 RVA: 0x000055BC File Offset: 0x000037BC
private void execBtn_Click(object sender, RoutedEventArgs e)
{
    if (Seliware.GetClientsCount() > 0)
    {
        Seliware.Execute(this.GetCurrent().Text);
    }
    else
    {
        functions.Msg("Not Injected!", "Error");
    }
}

private void opnfileBtn_Click(object sender, RoutedEventArgs e)
{
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Filter = "Lua files (*.lua)|*.lua|Text files (*.txt)|*.txt";
    bool? flag = openFileDialog.ShowDialog();
    bool flag2 = true;
    if (flag.GetValueOrDefault() == flag2 & flag != null)
    {
        this.MakeTab(File.ReadAllText(openFileDialog.FileName), openFileDialog.SafeFileName);
    }
}

private void clrBtn_Click(object sender, RoutedEventArgs e)
{
    if (this.GetCurrent() != null)
    {
        this.GetCurrent().Text = "";
    }
}

private void svfileBtn_Click(object sender, RoutedEventArgs e)
{
    SaveFileDialog SaveDialog = new SaveFileDialog
    {
        Filter = "Script Files (*.lua, *.txt)|*.lua;*.txt|All Files (*.*)|*.*",
        FileName = ""
    };
    SaveDialog.FileOk += (object s, CancelEventArgs ev) =>
    {
        File.WriteAllText(SaveDialog.FileName, this.GetCurrent().Text);
    };
    SaveDialog.ShowDialog();
}

// Token: 0x0600006D RID: 109 RVA: 0x000022DD File Offset: 0x000004DD
private void MenuItem_Click(object sender, RoutedEventArgs e)
{
    this.GetCurrent().Paste();
}

// Token: 0x0600006E RID: 110 RVA: 0x000022EA File Offset: 0x000004EA
private void MenuItem_Click_1(object sender, RoutedEventArgs e)
{
    this.GetCurrent().Copy();
}

// Token: 0x0600006F RID: 111 RVA: 0x000022F7 File Offset: 0x000004F7
private void MenuItem_Checked(object sender, RoutedEventArgs e)
{
    UserSettings.TopMost = true;
    UserSettings.Save();
    UserSettings.Load();
    base.Topmost = true;
}

// Token: 0x06000070 RID: 112 RVA: 0x0000231F File Offset: 0x0000051F
private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
{
    UserSettings.TopMost = false;
    UserSettings.Save();
    UserSettings.Load();
    base.Topmost = false;
}

// Token: 0x06000071 RID: 113 RVA: 0x00002347 File Offset: 0x00000547
private void window_MouseEnter(object sender, MouseEventArgs e)
{
    if (UserSettings.AutoOpacity)
    {
        this.Fade(this, TimeSpan.FromMilliseconds(800.0), 0.5);
    }
}

// Token: 0x06000072 RID: 114 RVA: 0x00002373 File Offset: 0x00000573
private void window_MouseLeave(object sender, MouseEventArgs e)
{
    if (UserSettings.AutoOpacity)
    {
        this.UnFade(this);
    }
}

// Token: 0x06000073 RID: 115 RVA: 0x00002388 File Offset: 0x00000588
private void MenuItem_Checked_1(object sender, RoutedEventArgs e)
{
    UserSettings.AutoOpacity = true;
    UserSettings.Save();
    UserSettings.Load();
}

// Token: 0x06000074 RID: 116 RVA: 0x000023A9 File Offset: 0x000005A9
private void autoopacityItem_Unchecked(object sender, RoutedEventArgs e)
{
    UserSettings.AutoOpacity = false;
    UserSettings.Save();
    UserSettings.Load();
}

// Token: 0x06000075 RID: 117 RVA: 0x0000567C File Offset: 0x0000387C
private void window_Closing(object sender, CancelEventArgs e)
{
    UserSettings.Save();
    int count = this.EditorTabs.Items.Count;
    FileInfo[] files = new DirectoryInfo(".\\SavedTabs").GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        files[i].Delete();
    }
    int j = 1;
    while (j < count)
    {
        string text = this.GetCurrent().Text;
        string text2 = ((TabItem)this.EditorTabs.SelectedItem).Header.ToString();
        text2 = text2.Replace("System.Windows.Controls.TextBox: ", "");
        text2 = text2.Replace(":", "");
        text2 = text2.Replace(" ", "_");
        text2 = text2.Replace("\\", "");
        text2 = text2.Replace("/", "");
        text2 = text2.Replace("*", "");
        text2 = text2.Replace("?", "");
        text2 = text2.Replace("\"", "");
        text2 = text2.Replace("<", "");
        text2 = text2.Replace(">", "");
        text2 = text2.Replace("|", "");
        if (string.IsNullOrEmpty(text2))
        {
            text2 = "No name";
        }
        this.EditorTabs.SelectedIndex = j;
        string text3 = ".\\SavedTabs\\" + text2;
        if (!File.Exists(text3))
        {
            using (FileStream fileStream = File.Create(text3))
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes(text);
                fileStream.Write(bytes, 0, bytes.Length);
                goto IL_01E9;
            }
            goto IL_01AB;
        }
        goto IL_01AB;
        IL_01E9:
        j++;
        continue;
        IL_01AB:
        using (FileStream fileStream2 = File.Create(text3 + "_"))
        {
            byte[] bytes2 = new UTF8Encoding(true).GetBytes(text);
            fileStream2.Write(bytes2, 0, bytes2.Length);
        }
        goto IL_01E9;
    }
    Process[] array = Process.GetProcessesByName("fps-unlock");
    for (int i = 0; i < array.Length; i++)
    {
        array[i].Kill();
    }
    array = Process.GetProcessesByName("TRX-MultipleRblx");
    for (int i = 0; i < array.Length; i++)
    {
        array[i].Kill();
    }
    Environment.Exit(0);
}

// Token: 0x06000076 RID: 118 RVA: 0x000023CA File Offset: 0x000005CA
private void scripthubBtn_Click(object sender, RoutedEventArgs e)
{
    new CatalogExecution().Show();
}

// Token: 0x06000077 RID: 119 RVA: 0x000058E8 File Offset: 0x00003AE8
private void dllchange_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (this.dllchange.SelectedItem == null) return;

    string text = (this.dllchange.SelectedItem as ComboBoxItem).Content.ToString().Trim();

    if (text == "TRXQ")
    {
        functions.Msg("Rest In Peace. 03.09.2023", "TRXQ");
        this.dllchange.SelectedIndex = 0; 
    }
    else if (text == "Seliware")
    {
    }
}

// Token: 0x06000078 RID: 120 RVA: 0x000023D6 File Offset: 0x000005D6
private void Btn_Click(object sender, RoutedEventArgs e)
{
    functions.Msg("Owner, UI Designer & Developer, Marketer - Sad (Qufity)\nBot & Web Developer - Heyzzz\nTRX Injector - Dx\nLua scripter - RunDTM\nMarketer - Kamlin\nDonators: Karatel, DanSlash\n\nDiscord: https://discord.gg/FkWdQHFPdN", "Credits");
}

// Token: 0x06000079 RID: 121 RVA: 0x000023E7 File Offset: 0x000005E7
private void scriptBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    this.GetCurrent().Text = File.ReadAllText(string.Format("./Scripts/{0}", this.scriptBox.SelectedItem));
}

// Token: 0x0600007D RID: 125 RVA: 0x00002426 File Offset: 0x00000626
private void savescriptItem_Click(object sender, RoutedEventArgs e)
{
    new ScriptSave(this.GetCurrent().Text).ShowDialog();
}

// Token: 0x0600007E RID: 126 RVA: 0x0000243E File Offset: 0x0000063E
private void btoolsItem_Click(object sender, RoutedEventArgs e)
{
    this.func.Execute("local destroy = Instance.new(\"HopperBin\",game.Players.LocalPlayer.Backpack) destroy.BinType = \"Hammer\" local clone = Instance.new(\"HopperBin\",game.Players.LocalPlayer.Backpack) clone.BinType = \"Clone\" local grab = Instance.new(\"HopperBin\",game.Players.LocalPlayer.Backpack) grab.BinType = \"Grab\"");
}

// Token: 0x06000085 RID: 133 RVA: 0x000024E9 File Offset: 0x000006E9
private void hidelogoItem_Checked(object sender, RoutedEventArgs e)
{
    UserSettings.hideBg = true;
    UserSettings.Save();
    UserSettings.Load();
    this.imgBg.Visibility = Visibility.Hidden;
}

// Token: 0x06000086 RID: 134 RVA: 0x00002516 File Offset: 0x00000716
private void hidelogoItem_Unchecked(object sender, RoutedEventArgs e)
{
    UserSettings.hideBg = false;
    UserSettings.Save();
    UserSettings.Load();
    this.imgBg.Visibility = Visibility.Visible;
}

// Token: 0x06000087 RID: 135 RVA: 0x00005A24 File Offset: 0x00003C24
private void refreshItem_Click(object sender, RoutedEventArgs e)
{
    try
    {
        this.scriptBox.Items.Clear();
        functions.PopulateListBox(this.scriptBox, "./Scripts", "*.txt");
        functions.PopulateListBox(this.scriptBox, "./Scripts", "*.lua");
    }
    catch
    {
    }
}

// Token: 0x06000088 RID: 136 RVA: 0x00002543 File Offset: 0x00000743
private void bgEditor_Click(object sender, RoutedEventArgs e)
{
    new BGEditor().Show();
}

// Token: 0x06000089 RID: 137 RVA: 0x00005A80 File Offset: 0x00003C80
private void killRblx_Click(object sender, RoutedEventArgs e)
{
    Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
    for (int i = 0; i < processesByName.Length; i++)
    {
        processesByName[i].Kill();
    }
}

private void InfiniteItem_Click(object sender, RoutedEventArgs e)
{
    this.func.Execute("loadstring(game:HttpGet'https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source')()");
}

private void joinDiscord_Click(object sender, RoutedEventArgs e)
{
    Process.Start("discord:///invite/FkWdQHFPdN");
}

private void creditsBtn_Click(object sender, RoutedEventArgs e)
{
    functions.Msg("Owner, UI Designer & Developer, Marketer - Sad (Qufity)\nBot & Web Developer - Heyzzz\nTRX Injector - Dx\nLua scripter - RunDTM\nMarketer - Kamlin\nDonators: Karatel, DanSlash\n\nCustom UI by: BlyadinaNoname, G1itch\nDiscord: https://discord.gg/FkWdQHFPdN", "Credits");
}

private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
{
    this.CustomBg.Position = TimeSpan.FromMilliseconds(1.0);
}

private void OnSeliwareInjected(object sender, EventArgs e)
{
    this.isInjecting = false;
    this.customInjectedCount++;
    this.titleUpdateTimer.Stop();
    Dispatcher.Invoke(() =>
    {
        string version = System.Text.RegularExpressions.Regex.Match(Seliware.GetVersion(), @"\d+\.\d+\.\d+(\.\d+)?").Value;
        base.Title = "TRX v" + version + " | " + this._randomTitlePart;
        functions.Msg("Injected!", "Success");
    });
}

private void AutoAttachMenuItem_Click(object sender, RoutedEventArgs e)
{
    UserSettings.AutoAttach = this.AutoAttachMenuItem.IsChecked;
    UserSettings.Save();
    if (UserSettings.AutoAttach)
    {
        this.autoAttachTimer.Start();
    }
    else
    {
        this.autoAttachTimer.Stop();
    }
}

// Token: 0x0400004D RID: 77
public static MainWindow AppWindow;

// Token: 0x0400004E RID: 78
private functions func = new functions();

// Token: 0x0400004F RID: 79
private ManagerEX exApi = new ManagerEX();

// Token: 0x04000050 RID: 80
private ManagerWRD wrdApi = new ManagerWRD();

// Token: 0x04000051 RID: 81
private ManagerKRNL krnlApi = new ManagerKRNL();

// Token: 0x04000052 RID: 82
private ManagerELECTRON electronApi = new ManagerELECTRON();

// Token: 0x04000053 RID: 83
private ManagerFLUXUS fluxusApi = new ManagerFLUXUS();

// Token: 0x04000055 RID: 85
private ScrollViewer tabScroller;

// Token: 0x04000056 RID: 86
public static MainWindow Instance;

// Token: 0x04000057 RID: 87
private TextEditor current;

// Token: 0x04000058 RID: 88

// Token: 0x04000059 RID: 89
public bool isAttaching;

}
}
