namespace makeit
{
    partial class frm_mesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mesaj));
            this.mf_konteyner = new MonoFlat_ThemeContainer();
            this.lbl_internet = new iTalk_Label();
            this.mf_kontrol = new MonoFlat_ControlBox();
            this.mf_konteyner.SuspendLayout();
            this.SuspendLayout();
            // 
            // mf_konteyner
            // 
            this.mf_konteyner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.mf_konteyner.Controls.Add(this.lbl_internet);
            this.mf_konteyner.Controls.Add(this.mf_kontrol);
            this.mf_konteyner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mf_konteyner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mf_konteyner.Location = new System.Drawing.Point(0, 0);
            this.mf_konteyner.Name = "mf_konteyner";
            this.mf_konteyner.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.mf_konteyner.RoundCorners = true;
            this.mf_konteyner.Sizable = false;
            this.mf_konteyner.Size = new System.Drawing.Size(317, 140);
            this.mf_konteyner.SmartBounds = true;
            this.mf_konteyner.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mf_konteyner.TabIndex = 0;
            this.mf_konteyner.Text = "Uyarı";
            // 
            // lbl_internet
            // 
            this.lbl_internet.AutoSize = true;
            this.lbl_internet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_internet.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl_internet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_internet.Location = new System.Drawing.Point(45, 82);
            this.lbl_internet.Name = "lbl_internet";
            this.lbl_internet.Size = new System.Drawing.Size(226, 13);
            this.lbl_internet.TabIndex = 1;
            this.lbl_internet.Text = "Lütfen İnternet Bağlantınızı Kontrol Ediniz.";
            // 
            // mf_kontrol
            // 
            this.mf_kontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_kontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mf_kontrol.EnableHoverHighlight = false;
            this.mf_kontrol.EnableMaximizeButton = false;
            this.mf_kontrol.EnableMinimizeButton = false;
            this.mf_kontrol.Location = new System.Drawing.Point(225, 1);
            this.mf_kontrol.Name = "mf_kontrol";
            this.mf_kontrol.Size = new System.Drawing.Size(90, 25);
            this.mf_kontrol.TabIndex = 0;
            this.mf_kontrol.Text = "monoFlat_ControlBox1";
            // 
            // frm_mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 140);
            this.Controls.Add(this.mf_konteyner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_mesaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uyarı";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.mf_konteyner.ResumeLayout(false);
            this.mf_konteyner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat_ThemeContainer mf_konteyner;
        private MonoFlat_ControlBox mf_kontrol;
        private iTalk_Label lbl_internet;
    }
}