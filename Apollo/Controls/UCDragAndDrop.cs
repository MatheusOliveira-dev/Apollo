using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apollo.Controls
{
    public partial class UCDragAndDrop : UserControl
    {
        private UCMainScanFile _UCScanFile;
        public UCDragAndDrop(UCMainScanFile ucScanFile)
        {
            _UCScanFile = ucScanFile;
            InitializeComponent();
        }

        private void UCDragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            _UCScanFile.ScanFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }

        private void UCDragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _UCScanFile.ScanFile(openFileDialog.FileName);
            }
        }
    }
}
