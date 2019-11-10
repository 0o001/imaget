namespace makeit
{
    partial class frm_yukle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_yukle));
            this.mf_konteyner = new MonoFlat_ThemeContainer();
            this.pbar_indir = new iTalk_ProgressBar();
            this.mf_kontrol = new MonoFlat_ControlBox();
            this.mf_konteyner.SuspendLayout();
            this.SuspendLayout();
            // 
            // mf_konteyner
            // 
            this.mf_konteyner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.mf_konteyner.Controls.Add(this.pbar_indir);
            this.mf_konteyner.Controls.Add(this.mf_kontrol);
            this.mf_konteyner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mf_konteyner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mf_konteyner.Location = new System.Drawing.Point(0, 0);
            this.mf_konteyner.Name = "mf_konteyner";
            this.mf_konteyner.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.mf_konteyner.RoundCorners = true;
            this.mf_konteyner.Sizable = false;
            this.mf_konteyner.Size = new System.Drawing.Size(310, 136);
            this.mf_konteyner.SmartBounds = true;
            this.mf_konteyner.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mf_konteyner.TabIndex = 0;
            this.mf_konteyner.Text = "Kelimeyi Yükle";
            // 
            // pbar_indir
            // 
            this.pbar_indir.BackColor = System.Drawing.Color.White;
            this.pbar_indir.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pbar_indir.Location = new System.Drawing.Point(101, 40);
            this.pbar_indir.Maximum = ((long)(100));
            this.pbar_indir.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbar_indir.Name = "pbar_indir";
            this.pbar_indir.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pbar_indir.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pbar_indir.ProgressShape = iTalk_ProgressBar._ProgressShape.Round;
            this.pbar_indir.Size = new System.Drawing.Size(100, 100);
            this.pbar_indir.TabIndex = 1;
            this.pbar_indir.Text = "iTalk_ProgressBar1";
            this.pbar_indir.Value = ((long)(0));
            // 
            // mf_kontrol
            // 
            this.mf_kontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_kontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mf_kontrol.EnableHoverHighlight = false;
            this.mf_kontrol.EnableMaximizeButton = false;
            this.mf_kontrol.EnableMinimizeButton = false;
            this.mf_kontrol.Location = new System.Drawing.Point(218, 1);
            this.mf_kontrol.Name = "mf_kontrol";
            this.mf_kontrol.Size = new System.Drawing.Size(90, 25);
            this.mf_kontrol.TabIndex = 0;
            // 
            // frm_yukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 136);
            this.Controls.Add(this.mf_konteyner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_yukle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelimeyi Yükle";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_yukle_Load);
            this.mf_konteyner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat_ThemeContainer mf_konteyner;
        private MonoFlat_ControlBox mf_kontrol;
        private iTalk_ProgressBar pbar_indir;
    }
}