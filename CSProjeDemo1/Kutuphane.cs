using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    internal class Kutuphane
    {
        public  Kutuphane() 
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }
        public List<Kitap> Kitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }

        public void OduncVer(Kitap kitap, Uye uye)
        {
            if (kitap.Durum == Durum.OduncAlabilir)
            {
                uye.OduncAl(kitap);
                kitap.Durum = Durum.OduncVerildi;
            }
        }

        public void IadeAl(Kitap kitap, Uye uye)
        {
            if (uye.OduncAlinanKitaplar.Contains(kitap))
            {
                uye.IadeEt(kitap);
                kitap.Durum = Durum.OduncAlabilir;
            }
        }
    }
}
