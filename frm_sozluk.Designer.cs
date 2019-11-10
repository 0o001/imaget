namespace makeit
{
    partial class frm_sozluk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sozluk));
            this.mf_konteyner = new MonoFlat_ThemeContainer();
            this.pcr_speak = new System.Windows.Forms.PictureBox();
            this.txt_ingilizce = new iTalk_TextBox_Big();
            this.pbox_ceviri = new System.Windows.Forms.PictureBox();
            this.txt_turkce = new iTalk_TextBox_Big();
            this.btn_yenile = new iTalk_Button_2();
            this.mf_kontrol = new MonoFlat_ControlBox();
            this.btn_ayarlar = new iTalk_Button_1();
            this.mf_konteyner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_speak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ceviri)).BeginInit();
            this.SuspendLayout();
            // 
            // mf_konteyner
            // 
            this.mf_konteyner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.mf_konteyner.Controls.Add(this.pcr_speak);
            this.mf_konteyner.Controls.Add(this.txt_ingilizce);
            this.mf_konteyner.Controls.Add(this.pbox_ceviri);
            this.mf_konteyner.Controls.Add(this.txt_turkce);
            this.mf_konteyner.Controls.Add(this.btn_yenile);
            this.mf_konteyner.Controls.Add(this.mf_kontrol);
            this.mf_konteyner.Controls.Add(this.btn_ayarlar);
            this.mf_konteyner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mf_konteyner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mf_konteyner.Location = new System.Drawing.Point(0, 0);
            this.mf_konteyner.Name = "mf_konteyner";
            this.mf_konteyner.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.mf_konteyner.RoundCorners = true;
            this.mf_konteyner.Sizable = false;
            this.mf_konteyner.Size = new System.Drawing.Size(532, 327);
            this.mf_konteyner.SmartBounds = true;
            this.mf_konteyner.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mf_konteyner.TabIndex = 0;
            this.mf_konteyner.Text = "Imaget";
            // 
            // pcr_speak
            // 
            this.pcr_speak.BackColor = System.Drawing.Color.White;
            this.pcr_speak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_speak.Image = global::makeit.Properties.Resources.volume_down_5_24__1_;
            this.pcr_speak.Location = new System.Drawing.Point(400, 209);
            this.pcr_speak.Name = "pcr_speak";
            this.pcr_speak.Size = new System.Drawing.Size(24, 24);
            this.pcr_speak.TabIndex = 8;
            this.pcr_speak.TabStop = false;
            this.pcr_speak.Click += new System.EventHandler(this.pcr_speak_Click);
            // 
            // txt_ingilizce
            // 
            this.txt_ingilizce.BackColor = System.Drawing.Color.Transparent;
            this.txt_ingilizce.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_ingilizce.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ingilizce.Image = global::makeit.Properties.Resources._1441058135_United_States_of_America;
            this.txt_ingilizce.Location = new System.Drawing.Point(84, 200);
            this.txt_ingilizce.MaxLength = 32767;
            this.txt_ingilizce.Multiline = false;
            this.txt_ingilizce.Name = "txt_ingilizce";
            this.txt_ingilizce.ReadOnly = true;
            this.txt_ingilizce.Size = new System.Drawing.Size(346, 41);
            this.txt_ingilizce.TabIndex = 7;
            this.txt_ingilizce.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ingilizce.UseSystemPasswordChar = false;
            // 
            // pbox_ceviri
            // 
            this.pbox_ceviri.BackColor = System.Drawing.Color.White;
            this.pbox_ceviri.Image = global::makeit.Properties.Resources._1441056910_translate;
            this.pbox_ceviri.Location = new System.Drawing.Point(235, 158);
            this.pbox_ceviri.Name = "pbox_ceviri";
            this.pbox_ceviri.Size = new System.Drawing.Size(37, 36);
            this.pbox_ceviri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ceviri.TabIndex = 6;
            this.pbox_ceviri.TabStop = false;
            // 
            // txt_turkce
            // 
            this.txt_turkce.BackColor = System.Drawing.Color.Transparent;
            this.txt_turkce.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_turkce.ForeColor = System.Drawing.Color.DimGray;
            this.txt_turkce.Image = global::makeit.Properties.Resources._1441056140_Turkey;
            this.txt_turkce.Location = new System.Drawing.Point(84, 111);
            this.txt_turkce.MaxLength = 32767;
            this.txt_turkce.Multiline = false;
            this.txt_turkce.Name = "txt_turkce";
            this.txt_turkce.ReadOnly = true;
            this.txt_turkce.Size = new System.Drawing.Size(346, 41);
            this.txt_turkce.TabIndex = 5;
            this.txt_turkce.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_turkce.UseSystemPasswordChar = false;
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.Color.Transparent;
            this.btn_yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yenile.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_yenile.ForeColor = System.Drawing.Color.White;
            this.btn_yenile.Image = null;
            this.btn_yenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yenile.Location = new System.Drawing.Point(199, 262);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(108, 30);
            this.btn_yenile.TabIndex = 3;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // mf_kontrol
            // 
            this.mf_kontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_kontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mf_kontrol.EnableHoverHighlight = false;
            this.mf_kontrol.EnableMaximizeButton = false;
            this.mf_kontrol.EnableMinimizeButton = true;
            this.mf_kontrol.Location = new System.Drawing.Point(440, 1);
            this.mf_kontrol.Name = "mf_kontrol";
            this.mf_kontrol.Size = new System.Drawing.Size(90, 25);
            this.mf_kontrol.TabIndex = 1;
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ayarlar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ayarlar.Image = null;
            this.btn_ayarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayarlar.Location = new System.Drawing.Point(430, 50);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(89, 28);
            this.btn_ayarlar.TabIndex = 0;
            this.btn_ayarlar.Text = "Ayarlar";
            this.btn_ayarlar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_ayarlar.Click += new System.EventHandler(this.btn_ayarlar_Click);
            // 
            // frm_sozluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(532, 327);
            this.Controls.Add(this.mf_konteyner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sozluk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imaget";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.mf_konteyner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_speak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ceviri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat_ThemeContainer mf_konteyner;
        private iTalk_Button_1 btn_ayarlar;
        private MonoFlat_ControlBox mf_kontrol;
        private iTalk_Button_2 btn_yenile;
        private iTalk_TextBox_Big txt_turkce;
        private System.Windows.Forms.PictureBox pbox_ceviri;
        private iTalk_TextBox_Big txt_ingilizce;
        private System.Windows.Forms.PictureBox pcr_speak;
    }
}

