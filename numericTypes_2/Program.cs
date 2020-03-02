// #3 - Numeric types: Write a program that asks a user for the number of miles they have driven 
// and the amount of gas they've consumed (in gallons), and print their miles-per-gallon.



using System;

namespace numericTypes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! So you've just returned from a long road trip. How cool.");
            Console.WriteLine("Let's figure out just how many miles-per-gallon it took you on average. Ready?\n");
            Console.Write("First off, just how many miles did you drive?: ");
            int milesDriven = int.Parse(Console.ReadLine());
            Console.Write("Great! And  how many gallons of gas did you consume in total?: ");
            int gallonsConsumed = int.Parse(Console.ReadLine());
            int totalMilesPerGallon = milesDriven / gallonsConsumed;
            Console.WriteLine($"\nAlright, it looks like you traveled about {totalMilesPerGallon.ToString()} miles-per-gallon on this trip!");

        }
    }
}
