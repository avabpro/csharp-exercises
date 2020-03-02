using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your name?");
            Console.Write("Enter your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + myFirstName + " " + myLastName + "!");
            Console.ReadLine();

            FirstMethod();
            Console.ReadLine();

            Console.Write("What if I need a \nnew line?");
            Console.ReadLine();

            string myString = string.Format("{0:C}", 9.78);
            Console.WriteLine(myString);

            string myOtherString = string.Format("{1:C}", 4, 8.89);
            Console.WriteLine(myOtherString);

            string numOfYears = string.Format("{0:N}", 98766576465465486);
            Console.WriteLine(numOfYears);

            string Tip = string.Format("Percentage: {0:P}", .879);
            Console.WriteLine(Tip);

            string phoneNumber = string.Format("Phone Number: {0:(###) ###-####}", 7535674296);
            Console.WriteLine(phoneNumber);
            Console.ReadLine();

            string partSentence = " Oh my goodness, what is happenning?  ";
            partSentence = partSentence.Substring(5, 10);
            Console.WriteLine(partSentence);
            Console.ReadLine();
            // ToUpper, Replace, Remove

            string compareLength = "    Once upon a time in the desert   ";
            compareLength = string.Format("Length before: {0} -- Length after: {1}", compareLength.Length, compareLength.Trim().Length);
            Console.WriteLine(compareLength);
            Console.ReadLine();
            

            string countThis = "";
            for (int i = 0; i < 100; i++)
            {
                countThis += "--" + i.ToString();
            }
            Console.WriteLine(countThis);
            // this works but is a waste of memory management for the run time -- use append instead
            // would give append example but can't find StringBuilder

            // ----------------------------------
            // PLAYING WITH DATES AND TIMES

            DateTime checkToday = DateTime.Now;
            //Console.WriteLine(checkToday.ToString());
            //Console.WriteLine(checkToday.ToShortDateString());
            //Console.WriteLine(checkToday.ToShortTimeString());
            //Console.WriteLine(checkToday.ToLongDateString());
            //Console.WriteLine(checkToday.ToLongTimeString());
            //Console.WriteLine(checkToday.AddDays(3).ToLongDateString());
            //Console.WriteLine(checkToday.AddDays(-3).ToLongDateString());
            //Console.WriteLine(checkToday.Month);
            //DateTime myBirthday = new DateTime(1989, 8, 13);
            //Console.WriteLine("My birthday is " + myBirthday.ToLongDateString() + "!");
            
            DateTime myBirthday = DateTime.Parse("1/15/1989");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("So far, I have been alive " + myAge.TotalDays + " days!");

            Console.ReadLine();

      
            // -----------------------------

            // in-line conditional operator
            Console.Write("Do you prefer the number 1 or 0?: ");
            int x = Console.ReadLine();
            string message = (x == 1) ? "Car" : "Boat";

    */

            for (int i = 0; i < 11; i++)
            {
                if (i == 8)
                    {
                    Console.WriteLine("Found 8!");
                    break;
                    }
            }
            Console.ReadLine();

        }

        private static void FirstMethod()
        {
            Console.WriteLine("You've just called a simple method!");
        }
    }
}
