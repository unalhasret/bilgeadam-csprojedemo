using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    internal class Memur : Personel
    {
        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal saatlikUcret = 500m;
            decimal maas = calismaSaati <= 180 ? calismaSaati * saatlikUcret : (180 * saatlikUcret) + ((calismaSaati - 180) * (saatlikUcret * 1.5m));
            return maas;
        }
    }
}
