﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Credit Calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
