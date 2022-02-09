using System;

namespace _3._1._2._TEXT_ANALYSIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your text, please! A then press the ENTER-button: ");
            string inputText = Console.ReadLine();
            char[] symbol = new char[] { '.', ' ', ',', '!', '?', ';', ':', '(', ')', '-', '"' };
            string[] words = inputText.ToLower().Split(symbol, StringSplitOptions.RemoveEmptyEntries);

            //счетчик повторения слова
            int CounterRepWords = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i+1; j < words.Length; j++)
                {
                    if (String.Compare(words[i], words[j]) == 0)
                    {
                        CounterRepWords += 1;
                    }
                }
            }

            // % повтора слов
            int FrequencyRepWords;
            try
            {
                FrequencyRepWords = CounterRepWords * 100 / words.Length;
                Console.WriteLine($"Frequency of using the same words in your text is {FrequencyRepWords} %");
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("error divide-by-zero");
            }

            //
            WordCounter wordcounter = new WordCounter();
            foreach (var item in words)
            {
                wordcounter.AddKey(item);
            }

            //вывод статистики употребления слов
            wordcounter.WordStatistics();

           
            

        }
    }
}
