// Write a program/class Area that prompts the user for a number representing the radius, 
// and then calculates the area of a circle with that radius and prints the result.

// NOTE: Recall that the area of a circle is A = pi* r * r where pi is 3.14 and r is the radius.

// -------------------------------------------------------------------

// BONUS #2 -Extend your program further by using a while or do-while loop, 
// so that when the user enters a negative number they are re-prompted.


using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! All you need to to is provide us with the radius of your circle." +
                "\nWe'll return the calculated the area for you. Ready?\n");

            Console.Write("Please enter the radius of your circle (must be a positive number): ");
            double radius = double.Parse(Console.ReadLine());

            while (radius < 0)
            {
                Console.Write("\nPlease try again. Be sure to enter a NON-NEGATIVE number: ");
                radius = double.Parse(Console.ReadLine());
            }
            
            double area = AreaMethod(radius);
            Console.WriteLine("\n");
            Console.WriteLine($"The area of your circle is {area.ToString()}.");
            Console.ReadLine();

        }


        private static double AreaMethod(double radius)
        {
            double areaOfCircle = radius * radius * 3.14;
            return areaOfCircle;
        }
    }

}
