﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit Calculated.");
        }

        public void SomethingMake()
        {
            throw new NotImplementedException();
        }
    }
}
