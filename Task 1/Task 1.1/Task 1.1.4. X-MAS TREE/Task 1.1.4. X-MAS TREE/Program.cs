using System;

namespace Task_1._1._4._X_MAS_TREE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            do
            {
                Console.WriteLine("Enter the number of triangles");
                m = int.Parse(Console.ReadLine());
                if (m <= 0)
                {
                    Console.WriteLine("You entered incorrect value");
                }
            } while (m <= 0);

            

            for (int p = 1; p <= m; p++)
            {
                int n = p;
                int x = m - p; // distance the string are offset
                for (int i = 1; i <= n; i++)
                {
                   
                    //j - number of spaces in string
                    for (int j = 1; j <= x + n - i; j++) //
                    {
                        Console.Write(" ");
                    }
                    //k - number of stars in string
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                   Console.WriteLine();
                }
            }
        }
    }
}
