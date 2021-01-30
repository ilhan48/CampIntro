using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Need Credit Calculated.");
        }

        public void SomethingMake()
        {
            throw new NotImplementedException();
        }
    }
}
