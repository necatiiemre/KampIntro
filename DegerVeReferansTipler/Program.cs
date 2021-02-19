using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 =65;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };

            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            Console.WriteLine(sayılar1[0]);

            foreach (var a in sayılar1)
            {
                Console.WriteLine(a);
            }

            for (int i = 0; i < sayılar1.Length; i++)
            {
                int hh = sayılar1[i];
                Console.WriteLine(hh);
            }

            //int , deciaml , float , double , bool( 0 ve 1 tutar) ==> Deger tip (Sayısal Görüntü)
            //array , class , interface ==> Referans Tip 

            //     Stack            Heap
            //   Deger Tip      Referans Tip
 
        }
    }
}
