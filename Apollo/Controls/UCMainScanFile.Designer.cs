namespace Apollo.Controls
{
    partial class UCMainScanFile
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
            this.pnlControls = new ReaLTaiizor.Controls.Panel();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(5);
            this.pnlControls.Size = new System.Drawing.Size(334, 276);
            this.pnlControls.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlControls.TabIndex = 0;
            this.pnlControls.Text = "panel1";
            //this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // UCScanFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlControls);
            this.Name = "UCScanFile";
            this.Size = new System.Drawing.Size(334, 276);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel pnlControls;
    }
}
