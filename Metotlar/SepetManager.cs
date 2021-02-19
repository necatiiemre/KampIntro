using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name);
        }

        public void Add2(string name, string description, double price)
        {
            Console.WriteLine("Sepete Eklendi : " + name + description + price);
        }
    }
}
