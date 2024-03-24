using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    internal class Yonetici : Personel
    {
        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal saatlikUcret = 500m;
            decimal maas = calismaSaati * saatlikUcret;
            decimal bonus = 1000m;
            maas += bonus;
            return maas;
        }
    }
}
