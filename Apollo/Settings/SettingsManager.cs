using System.IO;
using Apollo.Misc;
using Apollo.Models.Settings;
using Newtonsoft.Json;

namespace Apollo.Settings
{
    public class SettingsManager
    {
        private RootSettings _rootSettingsDeserialized;

        public SettingsManager()
        {
            CreateDefaultSettings();
            _rootSettingsDeserialized = JsonConvert.DeserializeObject<RootSettings>(File.ReadAllText(@"Settings\settings.json"));
        }
        public void CreateDefaultSettings()
        {
            if (!File.Exists(@"Settings\settings.json"))
            {
                RootSettings rootSettings = new RootSettings();

                rootSettings.MinimizeToTray = false;
                rootSettings.OpenVirusTotalGUI = false;
                rootSettings.WaitTimeGetResult = 3;
                Helpers.CreateOrReplaceFile(@"Settings\settings.json", JsonConvert.SerializeObject(rootSettings));
            }
        }

        public void SaveSettings(RootSettings rootSettings)
        {
            Helpers.CreateOrReplaceFile(@"Settings\settings.json", JsonConvert.SerializeObject(rootSettings));
        }

        public RootSettings GetIntegrationsDeserialized()
        {
            return _rootSettingsDeserialized;
        }
    }
}
