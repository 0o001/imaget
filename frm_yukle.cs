using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Reflection;

namespace makeit
{
    public partial class frm_yukle : Form
    {
        public frm_yukle()
        {
            InitializeComponent();
        }

        private void frm_yukle_Load(object sender, EventArgs e)
        {
            using (var yukle = new WebClient())
            {
                yukle.DownloadStringAsync(new Uri("http://nullovy.com/imaget/rastgele.php")); //Rastgele Kelimeyi İndir
                yukle.DownloadStringCompleted += new DownloadStringCompletedEventHandler(yukle_DownloadStringCompleted); //Rastgele Kelime İndirilse
                yukle.DownloadProgressChanged += new DownloadProgressChangedEventHandler(yukle_DownloadProgressChanged); //Rastgele Kelime Progressbarı
            }
        }
        void yukle_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbar_indir.Value = e.ProgressPercentage; //Progressbarda göster
        }
        void yukle_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                frm_sozluk ac = new frm_sozluk(e.Result); //Rastgele Kelimeyi Diğer Sözlük Formuna Aktar
                this.Hide();
                ac.ShowDialog(); //Sözlük Formunu Aç
                this.Close();
            }
            catch 
            {
                frm_mesaj ac = new frm_mesaj();
                this.Hide();
                ac.ShowDialog(); //İnternet Bağlantısı Kontrol Formunu Aç
                this.Close();
            }
        }

    }
}
