using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apollo.Integrations;
using Apollo.Models.Integrations;
using Vip.Notification;

namespace Apollo.Controls
{
    public partial class UCIntegrations : UserControl
    {
        public UCIntegrations()
        {
            InitializeComponent();

            LoadIntegrations();
        }

        private void LoadIntegrations()
        {
            RootIntegrations rootIntegrations = new IntegrationsManager().GetIntegrationsDeserialized();

            tbApiKeyHybridAnalysis.Text = rootIntegrations.hybrid;
            tbApiKeyVirusTotal.Text = rootIntegrations.virustotal;
        }
        private void SaveIntegrations()
        {
            RootIntegrations rootIntegrations = new RootIntegrations();
            rootIntegrations.hybrid = tbApiKeyHybridAnalysis.Text;
            rootIntegrations.virustotal = tbApiKeyVirusTotal.Text;

            IntegrationsManager integrationsManager = new IntegrationsManager();
            integrationsManager.SaveIntegrations(rootIntegrations);

            Alert.ShowSucess("Integrations saved successfully.", 5000);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveIntegrations();
        }
    }
}
