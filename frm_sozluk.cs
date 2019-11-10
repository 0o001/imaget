using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;

namespace makeit
{
    public partial class frm_sozluk : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool IsConnectedToInternet() //İnternet Bağlantısı Kontrolü
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public class RootObject //Çevrilen Kelimenin Json Özellikleri
        {
            public int code { get; set; }
            public string lang { get; set; }
            public List<string> text { get; set; }
        }

        void Yenile()
        {
            if (IsConnectedToInternet()) //Eğer İnternet Bağlantısı Varsa
            {
                RootObject ro;
                using (var client = new WebClient())
                {
                    kelime = client.DownloadString("http://nullovy.com/imaget/rastgele.php"); //Rastgele Kelimeyi Yükle
                }

                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8; //Utf-8 Formatında Çevir
                    string json = client.DownloadString("https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20150831T163143Z.12b5d175d71d0a9d.fd31cc1f73764b2d1fcdd5ddc036efb04cab2aa6&lang=en-tr&text=" + kelime); //Kelimeyi Çevir
                    var jss = new JavaScriptSerializer();
                    ro = jss.Deserialize<RootObject>(json);
                }

                if (!string.IsNullOrEmpty(ro.text[0]) && kelime.Trim() != ro.text[0].Trim()) //Çeviri boş ve kelimeler aynı değilse
                {
                    txt_ingilizce.Text = kelime;
                    txt_turkce.Text = ro.text[0];
                }
                else
                    Yenile(); //Yenile
            }
            else
            {
                frm_mesaj ac = new frm_mesaj();
                ac.ShowDialog(); //İnternet Bağlantısı Kontrol Formu
            }
        }

        string kelime;
        NotifyIcon nti_ac = new NotifyIcon(); //Zaman Ayarı Notifyiconu
        public frm_sozluk(string sozluk)
        {
            InitializeComponent();
            kelime = sozluk;
            Yenile(); //Yenile

            Timer tmr_zaman = new Timer(); //Zaman ayarı kontrol timerı
            tmr_zaman.Interval = 600000;
            tmr_zaman.Start();
            tmr_zaman.Tick += new EventHandler(tmr_zaman_Tick);

            nti_ac.BalloonTipIcon = ToolTipIcon.Info;
            nti_ac.BalloonTipTitle = "Hatırlatma";
            nti_ac.BalloonTipText = "Sözlüğe Bakıp Bir Kaç Kelime Daha Öğrenmek İster Misiniz?";
            nti_ac.Icon = this.Icon;
            nti_ac.Click += delegate
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                nti_ac.Visible = false;
            };
        }

        Ayarlar ayar = new Ayarlar(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +"\\Ayarlar.ini"); //Programdata Ayarlar.ini
        void tmr_zaman_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ayar.Oku("Ayarlar", "Zaman").Trim().ToLower() == "açık") //Eğer Zaman Ayarı Açıksa
                {
                    nti_ac.Visible = true;
                    nti_ac.ShowBalloonTip(2000);
                }
            }
            catch
            {
            }
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Yenile(); //Yenile
        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            frm_ayarlar ac = new frm_ayarlar();
            ac.ShowDialog(); //Ayarlar Formunu Aç
        }

        private void pcr_speak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10
            synthesizer.SpeakAsync(txt_ingilizce.Text);
        }
    }
}
