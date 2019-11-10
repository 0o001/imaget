using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace makeit
{
    public partial class frm_ayarlar : Form
    {
        Ayarlar ayar = new Ayarlar(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Ayarlar.ini"); //Programdata Ayarlar.ini
        public frm_ayarlar()
        {
            InitializeComponent();

            if (ayar.Oku("Ayarlar", "Zaman").Trim().ToLower() == "açık") //Eğer Zaman Ayarı Açıksa
            {
                tg_zaman.Toggled = true;
            }

            if (ayar.Oku("Ayarlar", "Başlangıç").Trim().ToLower() == "evet") //Eğer Başlangıç Ayarı Açıksa
            {
                tg_baslangic.Toggled = true;
            }
        }

        Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"); //Başlangıçta çalış kayıt yeri
        private void tg_baslangic_ToggledChanged()
        {
            if (tg_baslangic.Toggled) //Başlangıç Ayarını Aç
            {
                string programdata = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Imaget.exe"; //Programdata kayıt yeri
                if (!System.IO.File.Exists(programdata)) //Eğer Imaget.exe Programdatada yoksa
                {
                    System.IO.File.Copy(Application.ExecutablePath.ToString(), programdata); //Programı programdataya kopyala
                }
                key.SetValue("Imaget.exe", programdata); //Başlangıca Ekle
                ayar.Yaz("Ayarlar", "Başlangıç", "Evet"); //.ini Dosyasına Ekle
            }
            else
            {
                key.DeleteValue("Imaget.exe"); //Bağlangıçtan Kaldır
                ayar.Yaz("Ayarlar", "Başlangıç", "Hayır"); //.ini Dosyasına Ekle
            }
        }

        private void tg_zaman_ToggledChanged()
        {
            if (tg_zaman.Toggled) //Zaman Ayarını Aç
            {
                ayar.Yaz("Ayarlar", "Zaman", "Açık"); //.ini Dosyasına Ekle
            }
            else
            {
                ayar.Yaz("Ayarlar", "Zaman", "Kapalı"); //.ini Dosyasına Ekle
            }
        }
    }
}
