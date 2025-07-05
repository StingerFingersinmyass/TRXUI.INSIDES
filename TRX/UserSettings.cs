using Newtonsoft.Json;
using System.IO;

namespace TRX
{
    public static class UserSettings
    {
        private static readonly string settingsFilePath = "TRX_Settings.json";

                public static bool AutoAttach { get; set; } = false;
        public static bool AutoOpacity { get; set; } = false;
        public static bool TopMost { get; set; } = true;
        public static int SelectedDLL { get; set; } = 2;
        public static bool FPSUnlocker { get; set; } = false;
        public static bool fastInject { get; set; } = false;
        public static bool hideBg { get; set; } = false;
        public static double bgOpacity { get; set; } = 1.0;
        public static string customBg { get; set; } = "";
        public static string key { get; set; } = "";

        public static void Load()
        {
            if (File.Exists(settingsFilePath))
            {
                try
                {
                    string json = File.ReadAllText(settingsFilePath);
                    var settings = JsonConvert.DeserializeObject<SettingsData>(json);
                    if (settings != null)
                    {
                        AutoAttach = settings.AutoAttach;
                        AutoOpacity = settings.AutoOpacity;
                        TopMost = settings.TopMost;
                        SelectedDLL = settings.SelectedDLL;
                        FPSUnlocker = settings.FPSUnlocker;
                        fastInject = settings.fastInject;
                        hideBg = settings.hideBg;
                        bgOpacity = settings.bgOpacity;
                        customBg = settings.customBg;
                        key = settings.key;
                    }
                }
                catch
                {
                }
            }
        }

        public static void Save()
        {
            try
            {
                var settings = new SettingsData
                {
                    AutoAttach = AutoAttach,
                    AutoOpacity = AutoOpacity,
                    TopMost = TopMost,
                    SelectedDLL = SelectedDLL,
                    FPSUnlocker = FPSUnlocker,
                    fastInject = fastInject,
                    hideBg = hideBg,
                    bgOpacity = bgOpacity,
                    customBg = customBg,
                    key = key
                };
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(settingsFilePath, json);
            }
            catch
            {
            }
        }

        private class SettingsData
        {
            public bool AutoAttach { get; set; }
            public bool AutoOpacity { get; set; }
            public bool TopMost { get; set; }
            public int SelectedDLL { get; set; }
            public bool FPSUnlocker { get; set; }
            public bool fastInject { get; set; }
            public bool hideBg { get; set; }
            public double bgOpacity { get; set; }
            public string customBg { get; set; }
            public string key { get; set; }
        }
    }
}
