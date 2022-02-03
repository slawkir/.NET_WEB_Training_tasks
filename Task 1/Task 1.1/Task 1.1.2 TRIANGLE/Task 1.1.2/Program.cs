using System;

namespace Task_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.WriteLine("Enter the number: ");
                N = int.Parse(Console.ReadLine());
                if (N <= 0)
                {
                    Console.WriteLine("ERORR! You entered incorrect data");
                }
            } while (N <= 0);

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
