// Strings: 
// In one of the Gradebook programs (it doesn't matter which), 
// modify the code that prints out the class roster near the end of the program to use the StringBuilder class.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2PrepDictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder finalRoster = new StringBuilder();

            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Hi there! It's time to build a class roster for your new students. " +
                "\n\nPlease provide us with your students' names and IDs." +
                "\n(If you have NO new students to add, just hit ENTER to finish and see your final roster):");
            do
            {
                // Get student NAME
                Console.WriteLine("\nStudent name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get student ID
                    Console.WriteLine("Student ID: ");
                    int newID = int.Parse(Console.ReadLine());

                    students.Add(newID, newStudent);
                }
            }
            while (newStudent != "");


            // Print roster
            finalRoster.Append("\n-------------------------\n");
            finalRoster.Append("\nGreat! Here is your finale roster:\n");


            foreach (KeyValuePair<int, string> student in students)
            {
                finalRoster.Append("\nNAME: " + student.Value + " || ID: " + student.Key);
            }
            finalRoster.Append("\n-------------------------\n");
            Console.WriteLine(finalRoster);

            // Student look-up
            string searchForStudent = "";
            int studentSearchID;
            Console.WriteLine("\nAre you looking for a particular student?: (yes/no)");
            searchForStudent = Console.ReadLine();
            while (searchForStudent == "yes")
            {
                Console.Write("\nPlease enter a student ID: ");
                studentSearchID = int.Parse(Console.ReadLine());

                //if (students.ContainsKey int studentSearchID)
                if (students.ContainsKey(studentSearchID) == true)
                {
                    Console.Write("The student name registered with this ID is: ***" + students[studentSearchID] + "***");
                    Console.WriteLine("\n\nWould you like to look up another ID?: (yes/no)");
                    searchForStudent = Console.ReadLine();
                }
                else
                {
                    Console.Write("\nSorry about that! No student is registered with that ID. \nBest of luck.");
                }

            }
            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine("Great! We're all done here.");


            Console.ReadLine();
        }
    }
}