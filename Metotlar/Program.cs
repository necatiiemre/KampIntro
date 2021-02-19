using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";
            product1.Id = 0;

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";
            product2.Id = 1;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product productwrite in products)
            {
                Console.WriteLine(productwrite.Name );
                Console.WriteLine(productwrite.Price);
                Console.WriteLine(productwrite.Description);
                Console.WriteLine(productwrite.Id);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("FOREACH BİTTİ");

            for (int i = 0; i < products.Length; i++)
            {
                Product list = products[i];
                Console.WriteLine(list.Name);
                Console.WriteLine(list.Price);
                Console.WriteLine(list.Description);
                Console.WriteLine(list.Id);
                Console.WriteLine("--------------");

            }

            Console.WriteLine("FOR BİTTİ");

            int number = 0;
            while (number < 2)
            {
                Product list1 = products[number];
                Console.WriteLine(list1.Name);
                Console.WriteLine(list1.Price);
                Console.WriteLine(list1.Description);
                Console.WriteLine(list1.Id);
                Console.WriteLine("--------------");
                number++;
            }

            Console.WriteLine("WHILE BİTTİ");

            Console.WriteLine("-------Metotlar--------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12);
        }
    }
}


// Dont repeat yourself -- Clean Code-- 
