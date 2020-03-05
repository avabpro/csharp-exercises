// Arrays: 
// Create and initialize in a single line an array with the following values: 1, 1, 2, 3, 5, 8. 
// Then loop through the array and print out each value.

using System;

namespace Class2PrepArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; 
            int[] practiceArray = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int practiceNumber in practiceArray)
            {
                Console.WriteLine(practiceNumber);
            }

            Console.ReadLine();
        }
    }
}
