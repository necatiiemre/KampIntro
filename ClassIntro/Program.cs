using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Emre Özdemir";
            kurs1.IzlenmeOranı = 50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mehmet Özdemir";
            kurs2.IzlenmeOranı = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Sena Özdemir";
            kurs3.IzlenmeOranı = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Python";
            kurs4.Egitmen = "Sıla Özdemir";
            kurs4.IzlenmeOranı = 80;



            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            Console.WriteLine(kurs1 + "111");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + kurs.Egitmen + kurs.IzlenmeOranı);
            }

            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.IzlenmeOranı + " " + kurs1.KursAdi);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
