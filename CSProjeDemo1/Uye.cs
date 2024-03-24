using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    internal class Uye : IUye
    {
        public Uye() 
        { 
            OduncAlinanKitaplar = new List<Kitap>();
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        public void IadeEt(Kitap kitap)
        {
            if (OduncAlinanKitaplar.Contains(kitap))
            {
                OduncAlinanKitaplar.Remove(kitap);
                kitap.Durum = Durum.OduncAlabilir;
            }
        }

        public void OduncAl(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                OduncAlinanKitaplar.Add(kitap);
            }
        }
    }
}
