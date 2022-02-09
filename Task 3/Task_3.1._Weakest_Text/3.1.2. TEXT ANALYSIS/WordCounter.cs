using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2._TEXT_ANALYSIS
{
    public class WordCounter
    {
        private static Dictionary<string, int> dict;
        public WordCounter()
        {
            dict = new Dictionary<string, int>();
        }

        public void AddKey(string words)
        {
            if (dict.ContainsKey(words))
            {
                dict[words] += 1;
            }
            else
            {
                dict.Add(words, 1);
            }
        }

        public void WordStatistics()
        {
            foreach (var item in dict)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"'{item.Key}'");
                Console.ResetColor();
                Console.Write($" is used ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{item.Value}");
                Console.ResetColor();
                Console.Write(" times");
                Console.WriteLine();
            }
        }


    }
}
