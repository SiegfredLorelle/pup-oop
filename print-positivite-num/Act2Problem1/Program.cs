/* ACTIVITY 2 PROBLEM 1: Create a C# Program to print positive number enetered by the user
                         If the user enters a negative number it is skipped. */

using System;

namespace Act2Prob1
{
    public class Act2Prob1
    {
        public static void Main(string[] args)
        {
            // Variables
            string userInput;
            int number;
            bool isValidNumber;

            // Instructions
            Console.WriteLine("Enter an integer, and I'll print it back if it is positive! (Enter 'q' to exit)\n");

            // Prompt for integer w/ input validation
            while (true)
            {
                Console.Write("Integer:  ");
                userInput = Console.ReadLine();

                // Check if input is valid and convert to int
                isValidNumber = int.TryParse(userInput, out number);

                // Exit if q
                if (String.Equals(userInput.ToLower(), "q"))
                {
                    Console.WriteLine("The program is closing...");
                    break;
                }
                // Print error message if not an integer
                else if (!isValidNumber)
                {
                    Console.WriteLine("Please enter an integer, digits only. (Enter 'q' to exit)");
                }
                // Print if positive integer
                else if (number >= 0)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine();
            }
        }
    }
}
