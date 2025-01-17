using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MinesWeeper
{
    public class Skorboard
    {
        public string dosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MinesWeeper", "skorlar.txt");
        public class Kullanici
        {
            public string KullaniciAdi { get; set; }
            public int Skor { get; set; }
        }

        // Skoru hesaplayan metot
        public int HesaplaSkor(int bayrakSayisi, int sure)
        {
            if (sure == 0) return 0;
            if (bayrakSayisi == 0) bayrakSayisi = 1; // Süre sıfırsa skoru sıfır yap
            return (bayrakSayisi * 1000) / sure;
        }

        // Kullanıcı adı ve skoru dosyaya kaydeden metot
        public void KaydetSkor(string kullaniciAdi, int skor)
        {
            var yeniKullanici = new Kullanici { KullaniciAdi = kullaniciAdi, Skor = skor };

            // Dosyaya yeni kullanıcıyı ekle
            using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
            {
                writer.WriteLine($"{yeniKullanici.KullaniciAdi}:{yeniKullanici.Skor}");
            }
        }

        // Dosyadan en yüksek 10 skoru okuyan metot
        public List<Kullanici> EnYuksekSkorlar()
        {
            var kullanicilar = new List<Kullanici>();

            // Dosyadan kullanıcıları oku
            if (File.Exists(dosyaYolu))
            {
                var satirlar = File.ReadAllLines(dosyaYolu);
                foreach (var satir in satirlar)
                {
                    var parcalar = satir.Split(':');
                    if (parcalar.Length == 2 && int.TryParse(parcalar[1], out int skor))
                    {
                        kullanicilar.Add(new Kullanici { KullaniciAdi = parcalar[0], Skor = skor });
                    }
                }
            }

            // Skorları büyükten küçüğe sırala ve en yüksek 10 skoru al
            return kullanicilar.OrderByDescending(k => k.Skor).Take(10).ToList();
        }
    }
}
