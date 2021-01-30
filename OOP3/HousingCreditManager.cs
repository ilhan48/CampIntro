using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Credit Calculated.");
        }

        public void SomethingMake()
        {
            throw new NotImplementedException();
        }
    }
}
