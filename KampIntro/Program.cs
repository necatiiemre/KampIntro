using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            string KategoriEtiketi = "Kategoriler";
            int OgrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool SistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Oku");
            }
            else
            {
                Console.WriteLine("Degismedi");
            }

            Console.WriteLine(faizOrani);
            if (SistemeGirisYapmismi == true)
            {
                Console.WriteLine(" Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(OgrenciSayısı);
        }
    }
}
