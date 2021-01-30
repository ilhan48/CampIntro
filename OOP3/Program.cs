using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();           
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(needCreditManager, new DataBaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, vehicleCreditManager};

            //applicationManager.CreditInformation(credits);
            
        }
    }
}
