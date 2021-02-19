using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici kampı", "Programlamaya baslangıc icin temel kurs", "java", "C#", "C++" };


            for (int i = 0; i <= 50; i = ( i + 2) *2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For 1 bitti");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For 2 bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfasonu - footer");
        }
    }
}
