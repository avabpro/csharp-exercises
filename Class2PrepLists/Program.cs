// Lists: Write a static method to find the sum of all the even numbers in a list. 
// Within Main, create a list with at least 10 integers and call your method on the list.


using System;
using System.Collections.Generic;

namespace Class2PrepLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAlright - let's find the sum of your EVEN numbers! Ready?");
            Console.WriteLine("Before we can begin, we need to collect at least one number from you.\n");
            Console.WriteLine("(Include as many numbers as you'd like!)");

            List<double> listOfNums = new List<double>();

            string userAnswer = "yes";

            do
            {
                Console.Write("\nEnter an even OR odd number: ");
                double newNumber = double.Parse(Console.ReadLine());
                listOfNums.Add(newNumber);

                Console.Write("Would you like to include another number?: ");
                userAnswer = Console.ReadLine().ToLower();
            } while (userAnswer == "yes");

            double theSum = SumOfEvens(listOfNums);
            Console.WriteLine("\n");
            Console.WriteLine($"Awesome! The sum of your EVEN number(s) is: {theSum}");
            Console.ReadLine();
        }

        private static double SumOfEvens(List<double> givenNumbers)
        {
            double runningSum = 0;
            foreach (double givenNumber in givenNumbers)
            {
                if (givenNumber % 2 == 0)
                {
                    runningSum += givenNumber;
                }
            }
            return runningSum;
        }
    }
}
