using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apollo.APIs.HybridAnalysis;
using Apollo.APIs.VirusTotal;
using Apollo.Integrations;
using Apollo.Misc;
using Apollo.Models.HybridAnalysis.Result;
using Apollo.Models.HybridAnalysis.Scan;
using Apollo.Models.VirusTotal.Result;
using Newtonsoft.Json;
using Vip.Notification;

namespace Apollo.Controls
{
    public partial class UCScanFile : UserControl
    {
        private UCMainScanFile _UCMainScanFile;
        private string _file;
        
        public UCScanFile(UCMainScanFile ucScanFile, string file)
        {
            _UCMainScanFile = ucScanFile;
            _file = file;
            InitializeComponent();

            Task.Run(() => ScanFile());
        }

        public async void ScanFile()
        {
            IntegrationsManager integrationsManager = new IntegrationsManager();

            RootResultScanHybridAnalysis resultScanHybridAnalysis = null;
            RootResultScanVirusTotal resultScanVirusTotal = null;

            Helpers.CreateLog(string.Format("Starting Scan. File: {0}", _file));

            try
            {
                if (integrationsManager.IsHybridAnalysisProviderActive())
                {
                    Helpers.CreateLog("Hybrid Analysis Provider is Active");

                    HybridAnalysisAPI hybridAnalysisAPI = new HybridAnalysisAPI(integrationsManager.GetIntegrationsDeserialized().hybrid);
                    resultScanHybridAnalysis = await hybridAnalysisAPI.ScanAsync(_file);
                }

                if (integrationsManager.IsVirusTotalProviderActive())
                {
                    Helpers.CreateLog("VirusTotal Provider is Active");

                    VirusTotalAPI virusTotalAPI = new VirusTotalAPI(integrationsManager.GetIntegrationsDeserialized().virustotal);
                    resultScanVirusTotal = await virusTotalAPI.ScanAsync(_file);
                }

                _UCMainScanFile.ShowResultScan(resultScanHybridAnalysis, resultScanVirusTotal);

                Helpers.CreateLog("Scan Finished. Displaying Results");

            }
            catch (Exception)
            {
                MessageBox.Show("Scan Error. Check the Logs.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                _UCMainScanFile.NewScan();
            }

        }


        private void UCScanFile_Load(object sender, EventArgs e)
        {

        }
    }
}
