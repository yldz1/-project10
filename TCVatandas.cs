using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPvideo
{
    class TCVatandas
    {
        public long TCKimlikno { get; set; }
        public string AdSoyad { get; set; }
        public DateTime Dogumtarihi { get; set; }
        public DateTime SistemeKayitTarihi { get; set; }

        public TCVatandas()
        {
            SistemeKayitTarihi=DateTime.Now;
        }


        public string Vizeal()
        {
            int yas = YasHesapla(Dogumtarihi);
            if (yas >= 18)
                return "Başvurabilirsiniz";
            else
                return "Veli izni gerek";
        }

        private int YasHesapla(DateTime can)
        {
            return DateTime.Today.Year - can.Year;
        }
    }
}
