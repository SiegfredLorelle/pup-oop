using System;

namespace DateandTime
{
    internal class DataandTIme
    {
        static void Main(string[] args)
        {
            float firstGrade, secGrade, thirdGrade, ave, total;

            Console.Write("Enter 1st grade:  ");
            firstGrade = float.Parse(Console.ReadLine());

            Console.Write("Enter 2nd grade:  ");
            secGrade = float.Parse(Console.ReadLine());

            Console.Write("Enter 3rd grade:  ");
            thirdGrade = float.Parse(Console.ReadLine());


            ave = firstGrade + secGrade + thirdGrade;
            total = ave / 3;


            if (total >= 90)
            {
                Console.WriteLine("{0} grade is A", total);
            }

            else if (total >= 70 && total < 90)
            {
                Console.WriteLine("{0} grade is B", total);
            }
            else if (total >= 50 && total < 70)
            {
                Console.WriteLine("{0} grade is C", total);
            }
            else 
            {
                Console.WriteLine("{0} grade is F", total);
            }

        }
    }
}

