using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "personel.json";

            DosyaOku dosyaOku = new DosyaOku();
            var personelListesi = dosyaOku.PersonelListesiOku(dosyaYolu);

            MaasBordro.BordroOlustur(personelListesi);

        }
    }
}
