using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            
            switch (num)
            {
                case 1:
                    Console.WriteLine("State 1");
                    break;
                case 2:
                    Console.WriteLine("State 2");
                    break;
                case 3:
                    Console.WriteLine("State 3");
                    break;
                case 4:
                    Console.WriteLine("State 4");
                    break;
                case 5:
                    Console.WriteLine("State 5");
                    break;
                case 6:
                    Console.WriteLine("State 6");
                    break;

                default:
                    Console.WriteLine("Default State");
                    break;
            }
        }
    }
}
