using System;

namespace problem9
{
    internal class problem9
    {
        static void Main(string[] args)
        {
            string userInput, reverseString;
            reverseString = "";
            Console.Write("Enter a string:  ");
            userInput = Console.ReadLine();

            int Size = userInput.Length - 1;

            while (Size >= 0)
            {
                reverseString += userInput[Size];
                Size--;
            }

            Console.WriteLine("The reverse sting is {0}", reverseString);

        }
    }
}

