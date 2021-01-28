using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            string categoryTitle = "Category";
            int studentsNum = 32000;
            double interestRate = 1.45;
            bool enteredInSys = false;
            double dolaryesterday = 7.35;
            double dolartoday = 7.45;
            if (dolaryesterday>dolartoday)
            {
                Console.WriteLine("Decrease Button");
            }
            else if (dolaryesterday<dolartoday)
            {
                Console.WriteLine("Increase Button");
            }
            else
            {
                Console.WriteLine("Constant Button");
            }

            if (enteredInSys == true)
            {
                Console.WriteLine("User settings button");
            }

            else
            {
                Console.WriteLine("Login button");
            }


            Console.WriteLine(categoryTitle);
            
            Console.WriteLine(categoryTitle);
            
            Console.WriteLine(categoryTitle);
            
            Console.WriteLine(categoryTitle);

            Console.WriteLine(categoryTitle);

        }
    }
}
