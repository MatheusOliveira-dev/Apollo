using Apollo.Controls;
using Apollo.Models.HistoryScan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apollo.Forms
{
    public partial class frmViewHistoryScan : Form
    {
        private RootHistoryScan _historyScan;
        public frmViewHistoryScan(RootHistoryScan historyScan)
        {
            InitializeComponent();

            _historyScan = historyScan;
            pnlMain.Controls.Add(new UCResultScan(null, null, _historyScan));
        }
    }
}
