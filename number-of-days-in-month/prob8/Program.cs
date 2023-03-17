using System;

namespace problem8
{
    internal class problem8
    {
        static void Main(string[] args)
        {
            int month;

            Console.Write("Enter months (1-12):  ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month == 1)
            {
                Console.WriteLine("month: January \nNo of days: 31");
            }
            else if (month == 2)
            {
                Console.WriteLine("month: February \nNo of days: 29 or 28");
            }
            else if (month == 3)
            {
                Console.WriteLine("month: March \nNo of days: 31");
            }
            else if (month == 4)
            {
                Console.WriteLine("month: April \nNo of days: 30");
            }
            else if (month == 5)
            {
                Console.WriteLine("month: May \nNo of days: 31");
            }
            else if (month == 6)
            {
                Console.WriteLine("month: June \nNo of days: 30");
            }
        }
    }
}

