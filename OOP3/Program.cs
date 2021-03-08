using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            //personalFinanceCredit.Calculate();

            //CarCreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Calculate();

            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();

            // or

            //ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
            //personalFinanceCredit.Calculate();

            //ICreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Calculate();

            //ICreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();


            ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
     
            ICreditManager carCreditManager = new CarCreditManager();
            
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(carCreditManager, new DataBaseLoggerService());
            //applicationManager.MakeApplication(personalFinanceCredit, new FileLoggerService());
            //applicationManager.MakeApplication(mortgageCreditManager, new DataBaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {mortgageCreditManager , carCreditManager };
            //applicationManager.CreditPreNotificaion(credits);

            applicationManager.MakeApplication(carCreditManager, new List<ILoggerService> { new DataBaseLoggerService(),new FileLoggerService()});
            applicationManager.MakeApplication(personalFinanceCredit, new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService()});
            applicationManager.MakeApplication(mortgageCreditManager, new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService()});


        }
    }
}
