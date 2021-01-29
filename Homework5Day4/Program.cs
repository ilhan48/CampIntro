using System;

namespace Homework5Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class MyList<T> //  Generic class struct
    {
        T[] myArray;
        T[] myTempArray;
        public MyList() // constructor
        {
            myArray = new T[0]; // I reserved space for an array with 0 elements.

        }
        public void Add(T item) // Add method is born
        {
            myTempArray = myArray; // myTempArray holds reference number of myArray.
            myArray = new T[myArray.Length + 1]; // Increment myArray element count by one.
            for (int i = 0; i < myArray.Length; i++)   //The elements in the temporary array are written to the array using the for loop.
            {
                myArray[i] = myTempArray[i];
            }
        }

    }
}
