/* PROGRAM 4: Create a program that checks if a number is a leap year or not */

using System;

namespace Program4
{
    public class Program4
    {
        // Check if it a leap year and return true or false
        public static bool checkLeapYear(int yearF)
        {
            if ((yearF % 4) == 0)
            {
                if ((yearF % 100) == 0)
                {
                    if ((yearF % 400) == 0)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
                else
                { 
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            // Variables
            string yearStr;
            int year;
            bool isValidYear, isLeapYear;

            // Instructions
            Console.WriteLine("Enter a year, and I'll tell if it is a leap year!\n");

            // Prompt for year w/ input validation
            do
            {
                Console.Write("Year:  ");
                yearStr = Console.ReadLine();

                // Check if input is valid and convert to int
                isValidYear = int.TryParse(yearStr, out year);

                // Print error message if not valid 
                if (!isValidYear)
                {
                    Console.WriteLine("Please enter a valid year, numbers (digits) only. Try again!");
                }
                else if (year <= 0)
                {
                    Console.WriteLine("Please enter a valid year, No 0 and negatives. Try again!");
                }
                Console.WriteLine();
            }
            // Prompt again if input is invalid
            while (!isValidYear || year <= 0);

            // Check if leap year
            isLeapYear = checkLeapYear(year);

            // Display if it is a leap year or not
            if (isLeapYear)
            {
                Console.WriteLine($"YES. {year} is leap year.");
            }
            else
            {
                Console.WriteLine($"NO. {year} is NOT leap year.");
            }
        }
    }
}
