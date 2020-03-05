// Lists and Strings: Write a static method to print out each word in a list that has exactly 5 letters.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Class2PrepListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            Console.WriteLine("Hello! Let's look at some of the first words that come to your mind");
            Console.WriteLine("and see how many of them contain exactly FIVE letters. Ready?");

            string continuePrompt = "yes";

            do
            {
                Console.Write("\nEnter any word: ");
                words.Add(Console.ReadLine());

                Console.Write("Great. Would you like to add another word?: ");
                continuePrompt = Console.ReadLine().ToLower();
            } while (continuePrompt == "yes" || continuePrompt ==  "y");

            /* 
            string containFive = String.Join(", ", FiveLetterStrings(words));

            Console.WriteLine("\n");
            Console.WriteLine($"If any, these were the five-letter words you entered: {containFive}");
            Console.ReadLine();
            */

            Console.WriteLine("\n");
            Console.WriteLine("Done! If any, these were the five-letter words that you entered:");

            PrintList(words);

            Console.ReadLine();
        }

        private static List<string> FiveLetterStrings(List<string> NewWords)
        {
            List<string> finalList = new List<string>();
            foreach (string NewWord in NewWords)
            {
                if (NewWord.Length == 5)
                {
                    finalList.Add(NewWord);
                }
            }
            return finalList;
        }

        private static void PrintList(List<string> printStrings)
        {

            foreach (string printString in printStrings)
            {
                Console.Write(printString + ", ");
            }
        }
    }
}
