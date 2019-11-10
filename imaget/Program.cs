using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace makeit
{
    static class Program
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(IsConnectedToInternet()) //Eğer İnternet Bağlantısı Varsa
                Application.Run(new frm_yukle()); //Kelime Yükleme Formunu Aç
            else
                Application.Run(new frm_mesaj()); //İnternet Bağlantısı Kontrol Formunu Aç
        }
    }
}
