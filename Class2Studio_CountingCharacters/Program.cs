using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Class2Studio_CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text:");
            string LoremIpsum = Console.ReadLine();

            LetterCount(LoremIpsum);
            Console.ReadLine();
        }

        private static void LetterCount(string words)
        {
            char[] letters = words.ToLower().ToCharArray();

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int i = 0;
            int counter = 0;

            foreach (char alph in alphabet)

            {
                while (i < letters.Length)
                {
                    if (alph == letters[i])
                    {
                        counter++;
                    }
                    i++;
                } 
                Console.WriteLine(alph + ": " + counter);
                i = 0;
                counter = 0;

            }
        }
    }

}
