// #4 - Strings: The first sentence of Alice's Adventures in Wonderland is below. 
// Store this sentence in a string, and then prompt the user for a string to search for within this string. 
// Print whether or not the search term was found. See if you can make the search case-insensitive, 
// so that searching for "alice" prints true.

// Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: 
// once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 
// 'and what is the use of a book,' thought Alice 'without pictures or conversation?'


using System;

namespace stringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string AliceFirstSentence_True = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Hello there! How well do you think you recall the beginning sentence to Alice's Adventures in Wonderland?");
            Console.WriteLine("Let's test your memory.\n");
            Console.WriteLine("Try to write at least PART of the introductory sentence, and we'll let you know if what you've");
            Console.WriteLine("submitted actually exists in that string. Ready?\n");
            Console.Write("What is a part of the first sentence that you can remember?: ");
            string AliceFirstSentence_Guess = Console.ReadLine();

            string AliceFirstSentence_True_LowerCase = AliceFirstSentence_True.ToLower();
            string AliceFirstSentence_Guess_LowerCase = AliceFirstSentence_Guess.ToLower();

            bool result = AliceFirstSentence_True_LowerCase.Contains(AliceFirstSentence_Guess_LowerCase);

            if (result == true)
            {
                Console.WriteLine("\nNicely done! That is in fact from the introductory sentence. Great recall.\n");
                Console.WriteLine($"As a refresher, the full, correct sentence is: \n\n{AliceFirstSentence_True}\n");
            }
            else
            {
                Console.WriteLine("Oh no. Unfortunately, you may need a  refresher on this book. That text does not exist");
                Console.WriteLine($" in the first sentence of the book. \n " +
                    $"As a refresher, the full, corect sentence is: \n\n{AliceFirstSentence_True}\n");
                
            }
            
        }
    }
}
