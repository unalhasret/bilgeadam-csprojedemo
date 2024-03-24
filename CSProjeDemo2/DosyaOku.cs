using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    internal class DosyaOku
    {
        public List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            List<Personel> personelListesi = new List<Personel>();


                string json = File.ReadAllText(dosyaYolu);
                dynamic veri = JsonConvert.DeserializeObject(json);

                foreach (var item in veri)
                {
                    string unvan = item.title;
                    if (unvan == "Yonetici")
                    {
                        personelListesi.Add(new Yonetici { AdSoyad = item.name });
                    }
                    else if (unvan == "Memur")
                    {
                        personelListesi.Add(new Memur { AdSoyad = item.name });
                    }
                }


            return personelListesi;
        }
    }
}
