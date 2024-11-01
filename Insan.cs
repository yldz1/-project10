using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPvideo
{
    class Insan
    {
        public string AdSoyad { get; set; }
        public bool CanliMi { get; set; }

        public Insan()
        {
            CanliMi = true;
        }

        public Insan(string adSoyad)
        {
            AdSoyad = adSoyad;
            CanliMi = true;
        }

        public static string SelamVer()
        {
            return "Merhaba!";
        }

        public string AdiniSoyle()
        {
            return "Benim adim " + AdSoyad;
        }
    }
}
