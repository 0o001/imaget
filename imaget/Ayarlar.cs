using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace makeit
{
    class Ayarlar
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private string dosyayolu = String.Empty;
        public string Default { get; set; }

         public Ayarlar(string yol)
         {
             dosyayolu = yol;
         }

        public string Oku(string section, string key)
        {
            Default = Default ?? String.Empty;
            StringBuilder StrBuild = new StringBuilder(256);
            GetPrivateProfileString(section, key, Default, StrBuild, 255, dosyayolu);
            return StrBuild.ToString();
        }

        public long Yaz(string section, string key, string value)
        {
            return WritePrivateProfileString(section, key, value, dosyayolu);
        }
    }
}
