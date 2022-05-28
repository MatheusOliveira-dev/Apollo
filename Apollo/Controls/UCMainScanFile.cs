using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Apollo.Integrations;
using Apollo.Models.HybridAnalysis.Scan;
using Apollo.Models.HybridAnalysis.Result;
using Apollo.Models.VirusTotal.Result;
using Vip.Notification;

namespace Apollo.Controls
{
    public partial class UCMainScanFile : UserControl
    {
        public UCMainScanFile()
        {
            InitializeComponent();
            ChangeUserControl(new UCDragAndDrop(this));
        }

        public void ScanFile(string file)
        {
            ChangeUserControl(new UCScanFile(this, file));
        }

        public void ShowResultScan(RootResultScanHybridAnalysis resultScanHybridAnalysis = null, RootResultScanVirusTotal resultScanVirusTotal = null)
        {
            ChangeUserControl(new UCResultScan(resultScanHybridAnalysis, resultScanVirusTotal, null));
        }

        public void NewScan()
        {
            ChangeUserControl(new UCDragAndDrop(this));
        }
        private void ChangeUserControl(UserControl uc)
        {
            this.InvokeEx(f => pnlControls.Controls.Clear());
            this.InvokeEx(f => pnlControls.Controls.Add(uc));
        }
    }
}
