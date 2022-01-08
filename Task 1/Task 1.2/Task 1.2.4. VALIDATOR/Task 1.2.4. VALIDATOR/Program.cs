using System;
using System.Text.RegularExpressions;

namespace Task_1._2._4._VALIDATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputSentenses = "";
            do
            {
                Console.WriteLine("Input some sentences (only lowercase letters)");
                inputSentenses = Console.ReadLine();

                if (!(inputSentenses[inputSentenses.Length - 1] == '.'
                    || inputSentenses[inputSentenses.Length - 1] == '!'
                    || inputSentenses[inputSentenses.Length - 1] == '?'))
                {
                    Console.WriteLine("The sentence must end with '.', or '!', or '?', or '?!' ");
                }
            } while (!(inputSentenses[inputSentenses.Length - 1] == '.'
                    || inputSentenses[inputSentenses.Length - 1] == '!'
                    || inputSentenses[inputSentenses.Length - 1] == '?'));

            string[] outputSentences = Regex.Split(inputSentenses, @"([.?!]\s)");
            for (int i = 0; i < outputSentences.Length; i++)
            {
                outputSentences[i] = outputSentences[i].Remove(1, outputSentences[i].Length - 1).ToUpper() + outputSentences[i].Remove(0, 1);
            }

            foreach (var item in outputSentences)
            {
                Console.Write(item);
            }
        }
    }
}
