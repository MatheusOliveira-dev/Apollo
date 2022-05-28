using Apollo.Models.Settings;
using Apollo.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vip.Notification;

namespace Apollo.Controls
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            RootSettings rootSettings = new SettingsManager().GetIntegrationsDeserialized();

            chbxMinizeToTray.Checked = rootSettings.MinimizeToTray;
            chbxOpenVirusTotalGUI.Checked = rootSettings.OpenVirusTotalGUI;
            nmricWaitTimeResult.Value = rootSettings.WaitTimeGetResult;
        }


        private void SaveSettings()
        {
            RootSettings rootSettings = new RootSettings();
            rootSettings.MinimizeToTray = chbxMinizeToTray.Checked;
            rootSettings.OpenVirusTotalGUI = chbxOpenVirusTotalGUI.Checked;
            rootSettings.WaitTimeGetResult = (int)nmricWaitTimeResult.Value;

            SettingsManager settingsManager = new SettingsManager();
            settingsManager.SaveSettings(rootSettings);

            Alert.ShowSucess("Settings saved successfully.", 5000);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
