using System;

namespace Task_1._2._3._LOWERCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input sentence: ");
            string str = Console.ReadLine();

            char[] symbol = new char[] { ' ', '.', '!', '?', ';', ':', '-', '(', ')'};
            string[] words = str.Split(symbol, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (Char.IsLower(words[i][0]))
                {
                    count++;
                }
            }
            Console.WriteLine("The number of words starting with a lowercase letter: " + count);
        }
    }
}
