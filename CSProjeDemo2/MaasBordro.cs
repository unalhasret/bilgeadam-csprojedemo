using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    internal class MaasBordro
    {
        public static void BordroOlustur(List<Personel> personelListesi)
        {
            DateTime tarih = DateTime.Now;

            foreach (var personel in personelListesi)
            {
                Console.WriteLine($"Maaş bilgilerini giriniz - {personel.AdSoyad}:");
                Console.Write("Çalışma Saati: ");
                int calismaSaati = Convert.ToInt32(Console.ReadLine());

                decimal maas = personel.MaasHesapla(calismaSaati);
                string json = string.Format("{{\n\t\"Personel Ismi\": \"{0}\",\n\t\"Calisma Saati\": {1},\n\t\"Ana Odeme\": \"{2}\",\n\t\"Mesai\": \"{3}\",\n\t\"Toplam Odeme\": \"{4}\"\n}}",
                    personel.AdSoyad,
                    calismaSaati,
                    maas.ToString("C"),
                    (maas - (180 * 500m)).ToString("C"),
                    maas.ToString("C")
                );

                string dosyaYolu = Path.Combine(personel.AdSoyad, tarih.ToString("yyyy_MM") + ".json");
                Directory.CreateDirectory(personel.AdSoyad);
                File.WriteAllText(dosyaYolu, json);
            }
        }
    }
}

