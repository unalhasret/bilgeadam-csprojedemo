using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    internal interface IUye
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        public void OduncAl(Kitap kitap);
        public void IadeEt(Kitap kitap);
    }
}
