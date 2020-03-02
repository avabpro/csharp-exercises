// #1 - Input/output: Modify your HelloWorld program to prompt the user for their name, and greet them by name.

using System;

namespace inputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Nice you meet you.");
            

        }
    }
}
