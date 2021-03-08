using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Finance Credit Calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
