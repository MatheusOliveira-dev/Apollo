namespace Apollo.Controls
{
    partial class UCScanFile
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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.progressIndicator1 = new ReaLTaiizor.Controls.ProgressIndicator();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(105, 152);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(117, 21);
            this.bigLabel1.TabIndex = 15;
            this.bigLabel1.Text = "Scanning File...";
            // 
            // progressIndicator1
            // 
            this.progressIndicator1.Location = new System.Drawing.Point(120, 75);
            this.progressIndicator1.MinimumSize = new System.Drawing.Size(50, 50);
            this.progressIndicator1.Name = "progressIndicator1";
            this.progressIndicator1.P_AnimationColor = System.Drawing.Color.Gray;
            this.progressIndicator1.P_AnimationSpeed = 100;
            this.progressIndicator1.P_BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.progressIndicator1.Size = new System.Drawing.Size(80, 80);
            this.progressIndicator1.TabIndex = 16;
            this.progressIndicator1.Text = "progressIndicator1";
            // 
            // UCScanFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.progressIndicator1);
            this.Name = "UCScanFile";
            this.Size = new System.Drawing.Size(334, 276);
            this.Load += new System.EventHandler(this.UCScanFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ProgressIndicator progressIndicator1;
    }
}
