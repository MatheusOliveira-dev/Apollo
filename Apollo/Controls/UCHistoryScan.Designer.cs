namespace Apollo.Controls
{
    partial class UCHistoryScan
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGridViewScans = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnScanJson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChooseFile = new ReaLTaiizor.Controls.BigLabel();
            this.btnViewScan = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewScans)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewScans
            // 
            this.dtGridViewScans.AllowUserToAddRows = false;
            this.dtGridViewScans.AllowUserToDeleteRows = false;
            this.dtGridViewScans.AllowUserToResizeRows = false;
            this.dtGridViewScans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dtGridViewScans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewScans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridViewScans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewScans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewScans.ColumnHeadersHeight = 35;
            this.dtGridViewScans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDate,
            this.columnTime,
            this.columnFilename,
            this.columnScanJson});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewScans.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewScans.EnableHeadersVisualStyles = false;
            this.dtGridViewScans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtGridViewScans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dtGridViewScans.Location = new System.Drawing.Point(1, 33);
            this.dtGridViewScans.MultiSelect = false;
            this.dtGridViewScans.Name = "dtGridViewScans";
            this.dtGridViewScans.ReadOnly = true;
            this.dtGridViewScans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewScans.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewScans.RowHeadersWidth = 5;
            this.dtGridViewScans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridViewScans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewScans.Size = new System.Drawing.Size(332, 212);
            this.dtGridViewScans.TabIndex = 0;
            // 
            // columnDate
            // 
            this.columnDate.FillWeight = 99.07121F;
            this.columnDate.HeaderText = "Date";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            this.columnDate.Width = 70;
            // 
            // columnTime
            // 
            this.columnTime.FillWeight = 60.90014F;
            this.columnTime.HeaderText = "Time";
            this.columnTime.Name = "columnTime";
            this.columnTime.ReadOnly = true;
            this.columnTime.Width = 49;
            // 
            // columnFilename
            // 
            this.columnFilename.FillWeight = 148.6845F;
            this.columnFilename.HeaderText = "Filename";
            this.columnFilename.Name = "columnFilename";
            this.columnFilename.ReadOnly = true;
            this.columnFilename.Width = 205;
            // 
            // columnScanJson
            // 
            this.columnScanJson.FillWeight = 91.34423F;
            this.columnScanJson.HeaderText = "ScanJson";
            this.columnScanJson.Name = "columnScanJson";
            this.columnScanJson.ReadOnly = true;
            this.columnScanJson.Visible = false;
            this.columnScanJson.Width = 74;
            // 
            // lblChooseFile
            // 
            this.lblChooseFile.AutoSize = true;
            this.lblChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChooseFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lblChooseFile.Location = new System.Drawing.Point(3, 7);
            this.lblChooseFile.Name = "lblChooseFile";
            this.lblChooseFile.Size = new System.Drawing.Size(95, 15);
            this.lblChooseFile.TabIndex = 9;
            this.lblChooseFile.Text = "History Scans 🔎";
            // 
            // btnViewScan
            // 
            this.btnViewScan.BackColor = System.Drawing.Color.Transparent;
            this.btnViewScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewScan.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnViewScan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScan.Image = null;
            this.btnViewScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewScan.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnViewScan.Location = new System.Drawing.Point(256, 247);
            this.btnViewScan.Name = "btnViewScan";
            this.btnViewScan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnViewScan.Size = new System.Drawing.Size(75, 26);
            this.btnViewScan.TabIndex = 20;
            this.btnViewScan.Text = "View Scan";
            this.btnViewScan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnViewScan.Click += new System.EventHandler(this.btnViewScan_Click);
            // 
            // UCHistoryScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnViewScan);
            this.Controls.Add(this.lblChooseFile);
            this.Controls.Add(this.dtGridViewScans);
            this.Name = "UCHistoryScan";
            this.Size = new System.Drawing.Size(334, 276);
            this.Load += new System.EventHandler(this.UCHistoryScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewScans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dtGridViewScans;
        private ReaLTaiizor.Controls.BigLabel lblChooseFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnScanJson;
        private ReaLTaiizor.Controls.Button btnViewScan;
    }
}
