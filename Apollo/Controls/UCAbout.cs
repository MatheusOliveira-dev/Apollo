using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apollo.Controls
{
    public partial class UCAbout : UserControl
    {
        public UCAbout()
        {
            InitializeComponent();
        }

        private void lblCaptura_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MathewSachin/Captura");
        }

        private void lblIcons8_Click(object sender, EventArgs e)
        {
            Process.Start("https://icons8.com");
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MatheusOliveira-dev/");
        }

        private void pcbxGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MatheusOliveira-dev/Apollo");
        }

        private void tbReleases_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MatheusOliveira-dev/Apollo/releases");
        }

        private void tbSearchUpdate_Click(object sender, EventArgs e)
        {

        }

        private void UCAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = string.Format("{0}.{1}.{2}", Application.ProductVersion.Split('.')[0], Application.ProductVersion.Split('.')[1], Application.ProductVersion.Split('.')[2]);
        }
    }
}
