namespace makeit
{
    partial class frm_ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ayarlar));
            this.mf_konteyner = new MonoFlat_ThemeContainer();
            this.lbl_zamanNot = new iTalk_Label();
            this.lbl_zaman = new iTalk_Label();
            this.tg_zaman = new iTalk_Toggle();
            this.tg_baslangic = new iTalk_Toggle();
            this.lbl_baslangic = new iTalk_Label();
            this.mf_kontrol = new MonoFlat_ControlBox();
            this.mf_konteyner.SuspendLayout();
            this.SuspendLayout();
            // 
            // mf_konteyner
            // 
            this.mf_konteyner.BackColor = System.Drawing.Color.White;
            this.mf_konteyner.Controls.Add(this.lbl_zamanNot);
            this.mf_konteyner.Controls.Add(this.lbl_zaman);
            this.mf_konteyner.Controls.Add(this.tg_zaman);
            this.mf_konteyner.Controls.Add(this.tg_baslangic);
            this.mf_konteyner.Controls.Add(this.lbl_baslangic);
            this.mf_konteyner.Controls.Add(this.mf_kontrol);
            this.mf_konteyner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mf_konteyner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mf_konteyner.Location = new System.Drawing.Point(0, 0);
            this.mf_konteyner.Name = "mf_konteyner";
            this.mf_konteyner.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.mf_konteyner.RoundCorners = true;
            this.mf_konteyner.Sizable = false;
            this.mf_konteyner.Size = new System.Drawing.Size(297, 131);
            this.mf_konteyner.SmartBounds = true;
            this.mf_konteyner.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.mf_konteyner.TabIndex = 1;
            this.mf_konteyner.Text = "Ayarlar";
            // 
            // lbl_zamanNot
            // 
            this.lbl_zamanNot.AutoSize = true;
            this.lbl_zamanNot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_zamanNot.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl_zamanNot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_zamanNot.Location = new System.Drawing.Point(166, 94);
            this.lbl_zamanNot.Name = "lbl_zamanNot";
            this.lbl_zamanNot.Size = new System.Drawing.Size(117, 13);
            this.lbl_zamanNot.TabIndex = 9;
            this.lbl_zamanNot.Text = "*10 dakikada hatırlat.";
            // 
            // lbl_zaman
            // 
            this.lbl_zaman.AutoSize = true;
            this.lbl_zaman.BackColor = System.Drawing.Color.Transparent;
            this.lbl_zaman.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl_zaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_zaman.Location = new System.Drawing.Point(13, 94);
            this.lbl_zaman.Name = "lbl_zaman";
            this.lbl_zaman.Size = new System.Drawing.Size(72, 13);
            this.lbl_zaman.TabIndex = 8;
            this.lbl_zaman.Text = "Zaman Ayarı:";
            // 
            // tg_zaman
            // 
            this.tg_zaman.BackColor = System.Drawing.Color.White;
            this.tg_zaman.Location = new System.Drawing.Point(123, 91);
            this.tg_zaman.Name = "tg_zaman";
            this.tg_zaman.Size = new System.Drawing.Size(41, 23);
            this.tg_zaman.TabIndex = 7;
            this.tg_zaman.Toggled = false;
            this.tg_zaman.Type = iTalk_Toggle._Type.OnOff;
            this.tg_zaman.ToggledChanged += new iTalk_Toggle.ToggledChangedEventHandler(this.tg_zaman_ToggledChanged);
            // 
            // tg_baslangic
            // 
            this.tg_baslangic.BackColor = System.Drawing.Color.White;
            this.tg_baslangic.Location = new System.Drawing.Point(123, 56);
            this.tg_baslangic.Name = "tg_baslangic";
            this.tg_baslangic.Size = new System.Drawing.Size(41, 23);
            this.tg_baslangic.TabIndex = 3;
            this.tg_baslangic.Toggled = false;
            this.tg_baslangic.Type = iTalk_Toggle._Type.YesNo;
            this.tg_baslangic.ToggledChanged += new iTalk_Toggle.ToggledChangedEventHandler(this.tg_baslangic_ToggledChanged);
            // 
            // lbl_baslangic
            // 
            this.lbl_baslangic.AutoSize = true;
            this.lbl_baslangic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_baslangic.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl_baslangic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_baslangic.Location = new System.Drawing.Point(12, 58);
            this.lbl_baslangic.Name = "lbl_baslangic";
            this.lbl_baslangic.Size = new System.Drawing.Size(89, 13);
            this.lbl_baslangic.TabIndex = 2;
            this.lbl_baslangic.Text = "Başlangıça Ekle:";
            // 
            // mf_kontrol
            // 
            this.mf_kontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_kontrol.EnableHoverHighlight = false;
            this.mf_kontrol.EnableMaximizeButton = false;
            this.mf_kontrol.EnableMinimizeButton = true;
            this.mf_kontrol.Location = new System.Drawing.Point(205, 1);
            this.mf_kontrol.Name = "mf_kontrol";
            this.mf_kontrol.Size = new System.Drawing.Size(90, 25);
            this.mf_kontrol.TabIndex = 0;
            // 
            // frm_ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 131);
            this.Controls.Add(this.mf_konteyner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.mf_konteyner.ResumeLayout(false);
            this.mf_konteyner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat_ThemeContainer mf_konteyner;
        private iTalk_Toggle tg_baslangic;
        private iTalk_Label lbl_baslangic;
        private MonoFlat_ControlBox mf_kontrol;
        private iTalk_Toggle tg_zaman;
        private iTalk_Label lbl_zaman;
        private iTalk_Label lbl_zamanNot;
    }
}