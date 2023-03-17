using System;

namespace problem10
{
    internal class problem10
    {
        public static int getFactorial(int Input)
        {
            int factorial = 1;

            while (Input > 1)
            {
                factorial *= Input;
                Input--;
            }

            return factorial;
        }




        public static void Main(string[] args)
        {
            int input;
            Console.Write("Enter a number:  ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", getFactorial(input));

        }
    }
}

