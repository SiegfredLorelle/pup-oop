/* PROGRAM 3: Create a C# program to find the sum of all digits of a number. */

using System;

namespace Program3
{
    public class Program3
    {
        public static void Main(string[] args)
        {
            // Variables
            string wholeNumberStr;
            int wholeNumber, sumDigits;
            bool isValidNumber;

            // Instructions
            Console.WriteLine("Enter a whole number, and I'll add its digits!\n");

            // Prompt for string w/ input validation
            do
            {
                Console.Write("Whole number:  ");
                wholeNumberStr = Console.ReadLine();

                // Check if input is valid and convert to int
                isValidNumber = int.TryParse(wholeNumberStr, out wholeNumber);

                // Print error message if not valid 
                if (!isValidNumber)
                {
                    Console.WriteLine("Please enter numbers (digits) only. Try again!");
                }
                Console.WriteLine();
            }
            // Prompt again if input is invalid
            while (!isValidNumber);

            // Loop through each digit and add to sum
            sumDigits = 0;
            for (int i = 0; i < wholeNumberStr.Length; i++)
            {
                // Convert char to string to int then add to sum
                sumDigits += Int32.Parse(wholeNumberStr[i].ToString());
            }

            // Display the sum of all digits
            Console.WriteLine($"The sum of all digits of {wholeNumberStr} is {sumDigits}");
            Console.WriteLine(sumDigits);
        }
    }
}
