using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    internal abstract class Personel
    {
        public string AdSoyad { get; set; }
        public abstract decimal MaasHesapla(int calismaSaati);
    }
}
