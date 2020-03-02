// #2 - Numeric types: Write a program to calculate the area of a rectangle and print the answer to the console. 
// You should prompt the user for the dimensions. (What data types should the dimensions be?)

using System;

namespace numericTypes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Ready to calculate the area of your rectangle?\n");
            Console.Write("Please enter the LENGTH of your rectangle (omit units of measurement): ");
            int rectangleLength = int.Parse(Console.ReadLine());
            Console.Write("Please enter the WIDTH of your rectangle (omit units of measurement): ");
            int rectangleWidth = int.Parse(Console.ReadLine());
            int rectangleArea = (rectangleLength * rectangleWidth);
            Console.WriteLine($"Great! The area of your latest rectangle is {rectangleArea.ToString()}.");
            Console.WriteLine("\nBe sure to go back and check your units of measurement. =)");

        }
    }
}
