using Apollo.Forms;
using Apollo.HistoryScan;
using Apollo.Models.HistoryScan;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vip.Notification;

namespace Apollo.Controls
{
    public partial class UCHistoryScan : UserControl
    {
        public UCHistoryScan()
        {
            InitializeComponent();
            LoadScans();
        }

        private void LoadScans()
        {
            dtGridViewScans.Rows.Clear();

            HistoryScanManager historyScanManager = new HistoryScanManager();

            List<RootHistoryScan> lstScans = historyScanManager.GetScans();

            foreach (RootHistoryScan scanFile in lstScans)
            {
                dtGridViewScans.Rows.Add(scanFile.date, scanFile.time, scanFile.filename, string.Format(@"HistoryScans\{0}.json", scanFile.uid));
            }
        }

        private void ViewScan()
        {
            if (dtGridViewScans.SelectedRows.Count > 0)
            {

                if (File.Exists(dtGridViewScans.SelectedRows[0].Cells["columnScanJson"].Value.ToString()))
                {
                    RootHistoryScan rootHistory = JsonConvert.DeserializeObject<RootHistoryScan>(File.ReadAllText(dtGridViewScans.SelectedRows[0].Cells["columnScanJson"].Value.ToString()));
                    frmViewHistoryScan frmViewHistoryScan = new frmViewHistoryScan(rootHistory);
                    frmViewHistoryScan.Show();
                }
                else
                {
                    Alert.ShowError("Scan File Not Found.", 5000);
                    LoadScans();
                }
            }
        }

        private void UCHistoryScan_Load(object sender, EventArgs e)
        {

        }

        private void btnViewScan_Click(object sender, EventArgs e)
        {
            ViewScan();
        }
    }
}
