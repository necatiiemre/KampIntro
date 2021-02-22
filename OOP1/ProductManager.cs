using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

        public int AddNumber(int number1 , int number2)
        {
            return number1 + number2;
        }

        public void AddNumber2(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
