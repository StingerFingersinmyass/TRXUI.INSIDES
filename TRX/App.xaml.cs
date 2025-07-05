using SeliwareAPI;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace TRX
{
    public partial class App : Application
    {
                public App()
        {         
            AppDomain.CurrentDomain.UnhandledException += Exception;
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            string errorMessage = $"An unhandled exception occurred: {e.Exception.Message}\nStackTrace: {e.Exception.StackTrace}";
            Debug.WriteLine($"Unhandled UI Exception:\n{e.Exception}");
            
            try
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Clipboard.SetText(e.Exception.ToString());
                functions.Msg("Error copied to clipboard! Please send this to our Discord server.", "Error!");
            }
            catch
            {
                Debug.WriteLine("Failed to show error dialog");
            }
            
            e.Handled = true;
        }

        private static void Exception(object sender, UnhandledExceptionEventArgs e)
        {
            string errorMessage = e.ExceptionObject.ToString();
            Debug.WriteLine($"Unhandled Exception:\n{errorMessage}");
            
            try
            {
                Clipboard.SetText(errorMessage);
                MessageBox.Show(errorMessage, "Critical Error", MessageBoxButton.OK, MessageBoxImage.Error);
                functions.Msg("Critical error copied to clipboard! Please send this to our Discord server.", "Critical Error!");
            }
            catch
            {
                Debug.WriteLine("Failed to show error dialog");
            }
        }



        private void InitializeResources()
        {
            try
            {
                string[] requiredDirs = {
                    ".\\SavedTabs",
                    ".\\Scripts",
                    ".\\DLLs",
                    ".\\Bin",
                    ".\\Bin\\syntax",
                    ".\\TRXLogos",
                    ".\\Icons",
                    ".\\AutoExec"
                };

                foreach (string dir in requiredDirs)
                {
                    if (!Directory.Exists(dir))
                    {
                        try
                        {
                            Directory.CreateDirectory(dir);
                            Debug.WriteLine($"Created directory: {dir}");
                        }
                        catch (Exception ex)
                        {
                            string error = $"Failed to create directory {dir}: {ex.Message}";
                            MessageBox.Show(error, "Startup Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            throw new InvalidOperationException(error, ex);
                        }
                    }
                }

                string luaSyntaxFile = ".\\Bin\\syntax\\lua.xshd";
                if (!File.Exists(luaSyntaxFile))
                {
                    try
                    {
                        string defaultSyntax = @"<?xml version=""1.0""?>
<SyntaxDefinition name=""Lua"" xmlns=""http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008"">
  <Color name=""Comment"" foreground=""Green"" />
  <Color name=""String"" foreground=""#CD7C32"" />
  <Color name=""Keyword"" foreground=""#569CD6"" />
  <RuleSet>
    <Span color=""Comment"" begin=""--"" />
    <Span color=""String"">
      <Begin>""</Begin>
      <End>""</End>
      <RuleSet>
        <Span begin=""\\"" end=""."" />
      </RuleSet>
    </Span>
    <Keywords color=""Keyword"">
      <Word>and</Word>
      <Word>break</Word>
      <Word>do</Word>
      <Word>else</Word>
      <Word>elseif</Word>
      <Word>end</Word>
      <Word>false</Word>
      <Word>for</Word>
      <Word>function</Word>
      <Word>if</Word>
      <Word>in</Word>
      <Word>local</Word>
      <Word>nil</Word>
      <Word>not</Word>
      <Word>or</Word>
      <Word>repeat</Word>
      <Word>return</Word>
      <Word>then</Word>
      <Word>true</Word>
      <Word>until</Word>
      <Word>while</Word>
    </Keywords>
  </RuleSet>
</SyntaxDefinition>";
                        File.WriteAllText(luaSyntaxFile, defaultSyntax);
                        Debug.WriteLine($"Created default syntax file: {luaSyntaxFile}");
                    }
                    catch (Exception ex)
                    {
                        string error = $"Failed to create syntax file: {ex.Message}";
                        MessageBox.Show(error, "Startup Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        throw new InvalidOperationException(error, ex);
                    }
                }

                foreach (string dir in requiredDirs)
                {
                    try
                    {
                        string testFile = Path.Combine(dir, "test.tmp");
                        File.WriteAllText(testFile, "test");
                        File.Delete(testFile);
                        Debug.WriteLine($"Verified write access to: {dir}");
                    }
                    catch (Exception ex)
                    {
                        string error = $"Failed to verify write access to {dir}: {ex.Message}";
                        MessageBox.Show(error, "Startup Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        throw new InvalidOperationException(error, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to initialize resources: {ex}");
                throw;
            }
        }

                private void SyncAutoExecFiles()
        {
            try
            {
                string localAutoExec = ".\\AutoExec";
                string seliwareAutoExec = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "seliware-autoexec");

                if (!Directory.Exists(seliwareAutoExec))
                {
                    Directory.CreateDirectory(seliwareAutoExec);
                }

                                if (Directory.Exists(seliwareAutoExec))
                {
                    string[] oldFiles = Directory.GetFiles(seliwareAutoExec, "*.lua").Concat(Directory.GetFiles(seliwareAutoExec, "*.txt")).ToArray();
                    foreach (string file in oldFiles)
                    {
                        File.Delete(file);
                    }
                }

                if (Directory.Exists(localAutoExec))
                {
                    string[] filesToCopy = Directory.GetFiles(localAutoExec, "*.lua").Concat(Directory.GetFiles(localAutoExec, "*.txt")).ToArray();

                    foreach (string sourceFile in filesToCopy)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destFile = Path.Combine(seliwareAutoExec, fileName);
                        File.Copy(sourceFile, destFile, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to sync AutoExec files: {ex.Message}", "AutoExec Sync Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                Debug.WriteLine("Application starting...");
                
                base.OnStartup(e);

                Seliware.Initialize();

                                InitializeResources();

                SyncAutoExecFiles();

                Debug.WriteLine("Application startup completed successfully");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Application startup failed: {ex}");
                MessageBox.Show($"Application startup failed: {ex.Message}\n\nStackTrace: {ex.StackTrace}", 
                    "Critical Startup Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Shutdown(1);
            }
        }
    }
}
