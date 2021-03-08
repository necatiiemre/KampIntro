using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CarCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Car Finance Credit Calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
