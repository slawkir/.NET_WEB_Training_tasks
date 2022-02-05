using System;

namespace Task_1._2._1._AVERAGES
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // округление до целого

            Console.WriteLine("Введите предложение: ");
            string inputStr = Console.ReadLine();

            char[] symbol = new char[] { ' ', '.', ',', '!', '?', ':', ';', '-', '(', ')'};
            string[] words = inputStr.Split(symbol, StringSplitOptions.RemoveEmptyEntries);

            int sumLettersWords = 0;
            foreach (var item in words)
            {
                sumLettersWords += item.Length;
            }

            int averageLengthWord = sumLettersWords / words.Length;
            Console.WriteLine($"Средняя длина слова равна: {averageLengthWord}");

        }
    }
}
