using System;

namespace Task_1._2._2._DOUBLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first string");
            string str1 = Console.ReadLine();

            Console.WriteLine("Input second string");
            string str2 = Console.ReadLine();

            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j])
                    {
                        str1 = str1.Insert(j + 1, str2[i].ToString());
                        j++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Doubled string: {Environment.NewLine}{str1}");


        }
    }
}
