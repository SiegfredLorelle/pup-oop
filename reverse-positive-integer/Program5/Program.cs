/* PROGRAM 5: Create a program that reversed the positive integer input by the user */

using System;

namespace Program5
{
    public class Program5
    {
        public static void Main(string[] args)
        {
            // Variables
            string numberStr, reversedNumberStr;
            int number;
            bool isValidNumber;

            // Instructions
            Console.WriteLine("Enter a positive integer,and I'll reverse it!\n");

            // Prompt for positive integer w/ input validation
            do
            {
                Console.Write("Positive Integer:  ");
                numberStr = Console.ReadLine();

                // Check if input is valid and convert to int
                isValidNumber = int.TryParse(numberStr, out number);

                // Print error message if not valid 
                if (!isValidNumber)
                {
                    Console.WriteLine("Please enter a positive integer, digits only. Try again!");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Please enter a positive integer, No 0 or negatives. Try again!");
                }
                Console.WriteLine();
            }
            // Prompt again if input is invalid
            while (!isValidNumber || number <= 0);

            // Loop through each digit starting from the back
            reversedNumberStr = "";
            for (int i = numberStr.Length; i > 0; i--)
            {
                reversedNumberStr += numberStr[i - 1];
            }

            // Display reversed integer
            Console.WriteLine($"Your integer '{numberStr}' when reversed is '{reversedNumberStr}'.");
            Console.WriteLine($"Reversed: {reversedNumberStr}");
        }
    }
}
