using Apollo.Controls;
using Apollo.Misc;
using System;
using Apollo.Settings;
using System.Windows.Forms;
using Apollo.Integrations;
using Vip.Notification;
using System.Drawing;

namespace Apollo.Forms
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();

            Helpers.CreateDirectory(string.Format(@"Logs\{0}", DateTime.Now.ToShortDateString().Replace("/", null)));
            Helpers.CreateDirectory("Settings");
            Helpers.CreateDirectory("Integrations");
            Helpers.CreateDirectory("HistoryScans");

            if (new IntegrationsManager().IsScanProvidersInformed())
            {
                ChangeUserControl(new UCMainScanFile());
            }
            else
            {
                ChangeUserControl(new UCIntegrations());
            }
        }
    

        private void ChangeUserControl(UserControl uc)
        {
            pnlControls.Controls.Clear();
            pnlControls.Controls.Add(uc);
        }

        private void pcbxHome_Click(object sender, EventArgs e)
        {
            if (!new IntegrationsManager().IsScanProvidersInformed())
            {
                Alert.ShowError("No Scan Provider Informed.", 5000);
                ChangeUserControl(new UCIntegrations());
                return;
            }

            ChangeUserControl(new UCMainScanFile());
        }

        private void pcbxHistoryScan_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCHistoryScan());
        }

        private void pcbxIntegrations_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCIntegrations());
        }

        private void pcbxSettings_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCSettings());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (new SettingsManager().GetIntegrationsDeserialized().MinimizeToTray)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.notifyIcon.Visible = true;

                    notifyIcon.Icon = SystemIcons.Shield;
                    this.Hide();
                }
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon.Visible = false;
        }

        private void pcbxInfo_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCAbout());
        }
    }
}
