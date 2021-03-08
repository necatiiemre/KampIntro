using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeApplication(ICreditManager creditManager , ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditPreNotificaion(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
