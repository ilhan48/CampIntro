using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ilhan";
            int yas = 36;
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Teacher = "Engin Demiroğ";
            course1.ViewRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Teacher = "Kerem Varış";
            course2.ViewRate = 64;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Teacher = "Berkay Bilgin";
            course3.ViewRate = 80;


            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Teacher);
            }

            //Console.WriteLine(course1.CourseName + " : " + course1.Teacher);

            //Console.WriteLine("Hello World!");
        }
    }


    class Course
    {
        public string CourseName { get; set; }

        public string Teacher { get; set; }

        public int ViewRate { get; set; }
    }

}
