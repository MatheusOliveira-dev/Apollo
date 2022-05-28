using Apollo.HistoryScan;
using Apollo.Misc;
using Apollo.Models.HistoryScan;
using Apollo.Models.HybridAnalysis.Result;
using Apollo.Models.HybridAnalysis.Scan;
using Apollo.Models.VirusTotal.Result;
using Apollo.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vip.Notification;

namespace Apollo.Controls
{
    public partial class UCResultScan : UserControl
    {
        private RootHistoryScan _historyScan;

        private RootResultScanHybridAnalysis _resultScanHybridAnalysis;
        private RootResultScanVirusTotal _resultScanVirusTotal;
        
        public UCResultScan(RootResultScanHybridAnalysis resultScanHybridAnalysis, 
            RootResultScanVirusTotal resultScanVirusTotal,
            RootHistoryScan historyScan)
        {
            InitializeComponent();
            _resultScanHybridAnalysis = resultScanHybridAnalysis;
            _resultScanVirusTotal = resultScanVirusTotal;
            _historyScan = historyScan;

            ApplyResultsHybridAnalysis();
            ApplyResultsVirusTotal();
            ApplyResultsHistoryScan();

            SaveHistoryScan();
        }

        private void ApplyResultsHistoryScan()
        {

            if (_historyScan != null)
            {
                bdgMaliciousVirusTotal.Value = _historyScan.hybridAnalysisProvider.virusTotalScan.malicious;
                bdgTotalVirusTotal.Value = _historyScan.hybridAnalysisProvider.virusTotalScan.total;
                lblStatusVirusTotal.Text = _historyScan.hybridAnalysisProvider.virusTotalScan.status;
                ApplyStatusResult(lblStatusVirusTotal, lblStatusVirusTotal.Text);

                bdgMaliciousMetadefender.Value = _historyScan.hybridAnalysisProvider.metaDefenderScan.malicious;
                bdgTotalMetadefender.Value = _historyScan.hybridAnalysisProvider.metaDefenderScan.total;
                lblStatusMetadefender.Text = _historyScan.hybridAnalysisProvider.metaDefenderScan.status;
                ApplyStatusResult(lblStatusMetadefender, lblStatusMetadefender.Text);

                lblStatusAcronisAV.Text = _historyScan.virusTotalProvider.acronisScan.status;
                ApplyStatusResult(lblStatusAcronisAV, lblStatusAcronisAV.Text);

                lblStatusALYacAV.Text = _historyScan.virusTotalProvider.alyacScan.status;
                ApplyStatusResult(lblStatusALYacAV, lblStatusALYacAV.Text);
                
                lblStatusAPEXAv.Text = _historyScan.virusTotalProvider.apexScan.status;
                ApplyStatusResult(lblStatusAPEXAv, lblStatusAPEXAv.Text);
                
                lblStatusAVGAv.Text = _historyScan.virusTotalProvider.avgScan.status;
                ApplyStatusResult(lblStatusAVGAv, lblStatusAVGAv.Text);

                lblMD5.Text = _historyScan.md5;
                lblSHA1.Text = _historyScan.sha1;
                lblFilename.Text = _historyScan.filename;

                if (new SettingsManager().GetIntegrationsDeserialized().OpenVirusTotalGUI
                    && !string.IsNullOrWhiteSpace(_historyScan.urlGuiVirusTotal))
                {
                    Process.Start(_historyScan.urlGuiVirusTotal);
                }

            }  
        }
        private void SaveHistoryScan()
        {

            if (_historyScan == null)
            {
                HistoryScanManager historyScanManager = new HistoryScanManager();

                RootHistoryScan rootHistory = new RootHistoryScan();

                rootHistory.filename = lblFilename.Text;
                rootHistory.date = DateTime.Now.ToShortDateString();
                rootHistory.time = DateTime.Now.ToLongTimeString();
                rootHistory.sha1 = lblSHA1.Text;
                rootHistory.md5 = lblMD5.Text;


                HybridAnalysisProvider historyhybridAnalysisProvider = new HybridAnalysisProvider();

                MetaDefenderScan historyMetaDefenderScan = new MetaDefenderScan();
                historyMetaDefenderScan.total = bdgTotalMetadefender.Value;
                historyMetaDefenderScan.malicious = bdgMaliciousMetadefender.Value;
                historyMetaDefenderScan.status = lblStatusMetadefender.Text;
                historyhybridAnalysisProvider.metaDefenderScan = historyMetaDefenderScan;

                VirusTotalScan historyVirusTotalScan = new VirusTotalScan();
                historyVirusTotalScan.total = bdgTotalVirusTotal.Value;
                historyVirusTotalScan.malicious = bdgMaliciousVirusTotal.Value;
                historyVirusTotalScan.status = lblStatusVirusTotal.Text;
                historyhybridAnalysisProvider.virusTotalScan = historyVirusTotalScan;



                VirusTotalProvider historyVirusTotalProvider = new VirusTotalProvider();

                Models.HistoryScan.AcronisScan acronisScan = new Models.HistoryScan.AcronisScan();
                acronisScan.status = lblStatusAcronisAV.Text;
                historyVirusTotalProvider.acronisScan = acronisScan;

                Models.HistoryScan.AlyacScan alyacScan = new Models.HistoryScan.AlyacScan();
                alyacScan.status = lblStatusALYacAV.Text;
                historyVirusTotalProvider.alyacScan = alyacScan;

                Models.HistoryScan.ApexScan apexScan = new Models.HistoryScan.ApexScan();
                apexScan.status = lblStatusAPEXAv.Text;
                historyVirusTotalProvider.apexScan = apexScan;

                Models.HistoryScan.AvgScan avgScan = new Models.HistoryScan.AvgScan();
                avgScan.status = lblStatusAVGAv.Text;
                historyVirusTotalProvider.avgScan = avgScan;



                rootHistory.hybridAnalysisProvider = historyhybridAnalysisProvider;
                rootHistory.virusTotalProvider = historyVirusTotalProvider;


                rootHistory.urlGuiVirusTotal = (_resultScanVirusTotal != null
                                                && _resultScanVirusTotal.data.id != null)
                                                ? string.Format("https://www.virustotal.com/gui/file/{0}", _resultScanVirusTotal.data.id)
                                                : string.Empty;

                historyScanManager.SaveScan(rootHistory);
            }
        }
        private void ApplyResultsHybridAnalysis()
        {
            if (_resultScanHybridAnalysis != null)
            {
                bdgMaliciousMetadefender.Value = _resultScanHybridAnalysis.scanners[1].positives == null
                                                  ? 0
                                                  : int.Parse(_resultScanHybridAnalysis.scanners[1].positives.ToString());

                bdgTotalMetadefender.Value = _resultScanHybridAnalysis.scanners[1].total == null
                                                  ? 0
                                                  : int.Parse(_resultScanHybridAnalysis.scanners[1].total.ToString());


                bdgMaliciousVirusTotal.Value = _resultScanHybridAnalysis.scanners[2].positives == null
                                                  ? 0
                                                  : int.Parse(_resultScanHybridAnalysis.scanners[2].positives.ToString());

                bdgTotalVirusTotal.Value = _resultScanHybridAnalysis.scanners[2].total == null
                                                  ? 0
                                                  : int.Parse(_resultScanHybridAnalysis.scanners[2].total.ToString());

                ApplyStatusResult(lblStatusMetadefender, _resultScanHybridAnalysis.scanners[1].status.ToString());
                ApplyStatusResult(lblStatusVirusTotal, _resultScanHybridAnalysis.scanners[2].status.ToString());

              
                lblFilename.Text = _resultScanHybridAnalysis.FileName;
            }
        }

        private void ApplyResultsVirusTotal()
        {
            if (_resultScanVirusTotal != null)
            {
                ApplyStatusResult(lblStatusAcronisAV, (_resultScanVirusTotal.data.attributes.last_analysis_results.Acronis != null
                                                     && _resultScanVirusTotal.data.attributes.last_analysis_results.Acronis.result != null)
                                                     ? _resultScanVirusTotal.data.attributes.last_analysis_results.Acronis.result
                                                     : "Undetected");

                ApplyStatusResult(lblStatusALYacAV, (_resultScanVirusTotal.data.attributes.last_analysis_results.ALYac != null
                                                    && _resultScanVirusTotal.data.attributes.last_analysis_results.ALYac.result != null)
                                                    ? _resultScanVirusTotal.data.attributes.last_analysis_results.ALYac.result
                                                     : "Undetected");

                ApplyStatusResult(lblStatusAPEXAv, (_resultScanVirusTotal.data.attributes.last_analysis_results.APEX != null
                                                    && _resultScanVirusTotal.data.attributes.last_analysis_results.APEX.result != null)
                                                    ? _resultScanVirusTotal.data.attributes.last_analysis_results.APEX.result
                                                    : "Undetected");

                ApplyStatusResult(lblStatusAVGAv, (_resultScanVirusTotal.data.attributes.last_analysis_results.AVG != null
                                                    && _resultScanVirusTotal.data.attributes.last_analysis_results.AVG.result != null)
                                                    ? _resultScanVirusTotal.data.attributes.last_analysis_results.AVG.result
                                                    : "Undetected");

                lblMD5.Text = _resultScanVirusTotal.data.attributes.md5;
                lblSHA1.Text = _resultScanVirusTotal.data.attributes.sha1;

                lblFilename.Text = _resultScanVirusTotal.data.attributes.Filename;

                if (new SettingsManager().GetIntegrationsDeserialized().OpenVirusTotalGUI)
                {
                    Process.Start(string.Format("https://www.virustotal.com/gui/file/{0}", _resultScanVirusTotal.data.id));
                }
            }
        }

        private void ApplyStatusResult(ReaLTaiizor.Controls.BigLabel label, string status)
        {
            status = status.ToUpper().Equals("NO-RESULT") ? "UNDETECTED" : status.ToUpper();
            label.Text = status.ToUpper();

            ApplyForeColorStatusResult(label, status);

        }

        private void ApplyForeColorStatusResult(ReaLTaiizor.Controls.BigLabel label, string status)
        {
            switch (status)
            {
                case "UNDETECTED":
                    label.ForeColor = Color.Turquoise;
                    break;
                case "NULL":
                    label.ForeColor = Color.FromArgb(193, 193, 193);
                    break;
                case "NO ACTIVE":
                    label.ForeColor = Color.FromArgb(193, 193, 193);
                    break;
                case "CLEAN":
                    label.ForeColor = Color.LimeGreen;
                    break;
                case "ERROR":
                    label.ForeColor = Color.Orange;
                    break;
                default:
                    label.ForeColor = Color.FromArgb(205, 70, 66);
                    break;
            }
        }
        
        private void UCResultScan_Load(object sender, EventArgs e)
        {

        }

        private void pnlHybridAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void btnVirusTotalGUI_Click(object sender, EventArgs e)
        {
            if (_resultScanVirusTotal != null)
            {
                Process.Start(string.Format("https://www.virustotal.com/gui/file/{0}", _resultScanVirusTotal.data.id));
            }
            else if (_historyScan != null && !string.IsNullOrWhiteSpace(_historyScan.urlGuiVirusTotal))
            {
                Process.Start(_historyScan.urlGuiVirusTotal);
            }
            else
            {
                Alert.ShowError("Analysis Not Available for VirusTotal.");
            }
        }
    }
}
