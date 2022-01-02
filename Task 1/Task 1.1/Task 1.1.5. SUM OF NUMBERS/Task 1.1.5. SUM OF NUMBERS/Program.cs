using System;

namespace Task_1._1._5._SUM_OF_NUMBERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of all numbers less than 1000, multiples of 3 or 5 equals");
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
