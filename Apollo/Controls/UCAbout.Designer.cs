namespace Apollo.Controls
{
    partial class UCAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAbout));
            this.label1 = new ReaLTaiizor.Controls.BigLabel();
            this.lblVersion = new ReaLTaiizor.Controls.BigLabel();
            this.lblAuthor = new ReaLTaiizor.Controls.BigLabel();
            this.pcbxGithub = new ReaLTaiizor.Controls.HopePictureBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.lblCaptura = new ReaLTaiizor.Controls.BigLabel();
            this.lblIcons8 = new ReaLTaiizor.Controls.BigLabel();
            this.tbReleases = new ReaLTaiizor.Controls.Button();
            this.tbSearchUpdate = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Apollo";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lblVersion.Location = new System.Drawing.Point(58, 15);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(31, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "0.0.0";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.lblAuthor.Location = new System.Drawing.Point(4, 30);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(101, 15);
            this.lblAuthor.TabIndex = 13;
            this.lblAuthor.Text = "Matheus Oliveira";
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            // 
            // pcbxGithub
            // 
            this.pcbxGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.pcbxGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxGithub.Image = ((System.Drawing.Image)(resources.GetObject("pcbxGithub.Image")));
            this.pcbxGithub.Location = new System.Drawing.Point(268, 9);
            this.pcbxGithub.Name = "pcbxGithub";
            this.pcbxGithub.Padding = new System.Windows.Forms.Padding(10, 4, 5, 0);
            this.pcbxGithub.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pcbxGithub.Size = new System.Drawing.Size(47, 36);
            this.pcbxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxGithub.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pcbxGithub.TabIndex = 14;
            this.pcbxGithub.TabStop = false;
            this.pcbxGithub.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pcbxGithub.Click += new System.EventHandler(this.pcbxGithub_Click);
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bigLabel4.Location = new System.Drawing.Point(4, 231);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(87, 15);
            this.bigLabel4.TabIndex = 17;
            this.bigLabel4.Text = "UI inspired By:";
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bigLabel5.Location = new System.Drawing.Point(35, 246);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(56, 15);
            this.bigLabel5.TabIndex = 18;
            this.bigLabel5.Text = "Icons By:";
            // 
            // lblCaptura
            // 
            this.lblCaptura.AutoSize = true;
            this.lblCaptura.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCaptura.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(225)))), ((int)(((byte)(192)))));
            this.lblCaptura.Location = new System.Drawing.Point(92, 231);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(50, 15);
            this.lblCaptura.TabIndex = 19;
            this.lblCaptura.Text = "Captura";
            this.lblCaptura.Click += new System.EventHandler(this.lblCaptura_Click);
            // 
            // lblIcons8
            // 
            this.lblIcons8.AutoSize = true;
            this.lblIcons8.BackColor = System.Drawing.Color.Transparent;
            this.lblIcons8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIcons8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcons8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(182)))), ((int)(((byte)(80)))));
            this.lblIcons8.Location = new System.Drawing.Point(92, 246);
            this.lblIcons8.Name = "lblIcons8";
            this.lblIcons8.Size = new System.Drawing.Size(43, 15);
            this.lblIcons8.TabIndex = 20;
            this.lblIcons8.Text = "Icons8";
            this.lblIcons8.Click += new System.EventHandler(this.lblIcons8_Click);
            // 
            // tbReleases
            // 
            this.tbReleases.BackColor = System.Drawing.Color.Transparent;
            this.tbReleases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbReleases.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbReleases.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReleases.Image = null;
            this.tbReleases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbReleases.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.tbReleases.Location = new System.Drawing.Point(5, 114);
            this.tbReleases.Name = "tbReleases";
            this.tbReleases.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbReleases.Size = new System.Drawing.Size(324, 26);
            this.tbReleases.TabIndex = 16;
            this.tbReleases.Text = "View Releases";
            this.tbReleases.TextAlignment = System.Drawing.StringAlignment.Center;
            this.tbReleases.Click += new System.EventHandler(this.tbReleases_Click);
            // 
            // tbSearchUpdate
            // 
            this.tbSearchUpdate.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSearchUpdate.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbSearchUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchUpdate.Image = null;
            this.tbSearchUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSearchUpdate.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.tbSearchUpdate.Location = new System.Drawing.Point(5, 146);
            this.tbSearchUpdate.Name = "tbSearchUpdate";
            this.tbSearchUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbSearchUpdate.Size = new System.Drawing.Size(324, 26);
            this.tbSearchUpdate.TabIndex = 21;
            this.tbSearchUpdate.Text = "Search Update";
            this.tbSearchUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.tbSearchUpdate.Click += new System.EventHandler(this.tbSearchUpdate_Click);
            // 
            // UCAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tbSearchUpdate);
            this.Controls.Add(this.lblIcons8);
            this.Controls.Add(this.lblCaptura);
            this.Controls.Add(this.bigLabel5);
            this.Controls.Add(this.bigLabel4);
            this.Controls.Add(this.tbReleases);
            this.Controls.Add(this.pcbxGithub);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Name = "UCAbout";
            this.Size = new System.Drawing.Size(334, 276);
            this.Load += new System.EventHandler(this.UCAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel label1;
        private ReaLTaiizor.Controls.BigLabel lblVersion;
        private ReaLTaiizor.Controls.BigLabel lblAuthor;
        private ReaLTaiizor.Controls.HopePictureBox pcbxGithub;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigLabel lblCaptura;
        private ReaLTaiizor.Controls.BigLabel lblIcons8;
        private ReaLTaiizor.Controls.Button tbReleases;
        private ReaLTaiizor.Controls.Button tbSearchUpdate;
    }
}
