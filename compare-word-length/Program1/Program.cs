/* PROGRAM 1: Create a program where two strings will be inputted by the user 
and be compared if first string is greater or smaller or equal to the second string. */

using System;

namespace Program1 
{
    public class Program1
    {
        public static void Main(string[] args)
        {
            // Variables
            string firstString, secondString;
            int lengthFirstString, lengthSecondString;

            // Get strings w/ input validation
            do
            {
                Console.WriteLine("Enter two (2) strings and I'll compare their lengths!\n");
                Console.Write("First String:  ");
                firstString = Console.ReadLine();

                Console.Write("Second String:  ");
                secondString = Console.ReadLine();

                Console.WriteLine();
            }
            // Get string again if input was null
            while (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString));


            // Get length of strings
            lengthFirstString = firstString.Length;
            lengthSecondString = secondString.Length;

            // Declare the greater string and print
            if (lengthFirstString > lengthSecondString)
            {
                Console.WriteLine("First string is greater than second string.\n" +
                                  "'{0}' is greater than '{1}'.", firstString, secondString);
            }
            else if (lengthFirstString < lengthSecondString)
            {
                Console.WriteLine("First string is smaller than second string.\n" +
                                  "'{0}' is smaller than '{1}'.", firstString, secondString);
            }
            else
            {
                Console.WriteLine("Both strings are equal.\n" +
                                  "'{0}' is the same as '{1}'.", firstString, secondString);
            }
        }
    }
}