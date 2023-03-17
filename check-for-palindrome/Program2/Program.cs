/* PROGRAM 2: Create a program that will check if a string is a palindrome. */

using System;

namespace Program2
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            // Variables
            string userInput, reversedString, lowerUserInput, lowerReversedString;

            // Prompt for string w/ input validation
            do
            {
                Console.WriteLine("Enter a string, and I'll check if it's a Palindrome!\n");

                Console.Write("String:  ");
                userInput = Console.ReadLine();

                Console.WriteLine();
            }
            // Prompt again if null was entered
            while (string.IsNullOrEmpty(userInput));

            // Reverse the string
            reversedString = "";
            // i is a counter variable
            for (int i = userInput.Length; i > 0; i--)
            {
                reversedString += userInput[i - 1];
            }

            // Lowercase both strings for comparison
            lowerUserInput = userInput.ToLower();
            lowerReversedString = reversedString.ToLower();

            // Display the string and its reversed
            Console.WriteLine("Your string '{0}' when reversed is '{1}'.\n", lowerUserInput, lowerReversedString);

            // Determine if it's a Palindrome and print
            if (String.Equals(lowerUserInput, lowerReversedString))
            {
                Console.WriteLine("'{0}' is a Palindrome!", userInput);
            }
            else
            {
                Console.WriteLine("'{0}' is NOT a Palindrome!", userInput);
            }
        }
    }
}