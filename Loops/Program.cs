using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "A";
            string course2 = "B";
            string course3 = "C";
            string course4 = "D";
            string course5 = "E";

            //array - dizi

            string[] courses = new string[] { "A" , "B" , "C","D","E" };



            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]); 
            }

            Console.WriteLine("For Loop end");

            foreach (string course in courses) // dizi temelli yapıları döner
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Footer");
        }
    }
}


