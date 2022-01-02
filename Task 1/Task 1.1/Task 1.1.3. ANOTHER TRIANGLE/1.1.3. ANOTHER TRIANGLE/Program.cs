using System;

namespace _1._1._3._ANOTHER_TRIANGLE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            do
            {
                Console.WriteLine("Enter the number of strings: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("You entered the incorrect value of the number of strings");
                }
            } while (n <= 0);

            for (int i = 1; i <= n; i++)
            {
                //j - number of spaces in string
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                //k - number of stars in string
                for (int k = 1; k <= 2*i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } 
            
        }
    }
}
