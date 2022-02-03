using System;

namespace Task_1._1._6._FONT_ADJUSTMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int n;
            bool bold = false;
            bool italic = false;
            bool underline = false;
            string outputProperty;

            do
            {
                outputProperty = "";

                if (bold)
                {
                    outputProperty += "Bold, ";
                }
                if (italic)
                {
                    outputProperty += "Italic, ";
                }
                if (underline)
                {
                    outputProperty += "Underline";
                }
                if (outputProperty == "")
                {
                    outputProperty = "None";
                }
                if (outputProperty[outputProperty.Length - 1] == ' ')
                {
                    outputProperty = outputProperty.Remove(outputProperty.Length - 2);
                }                

                Console.WriteLine($"Параметры надписи: {outputProperty}{Environment.NewLine}" +
                    $"Введите:{Environment.NewLine}" +
                    $"        1: bold{Environment.NewLine}" +
                    $"        2: italic{Environment.NewLine}" +
                    $"        3: underline{Environment.NewLine}");

                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        bold = !bold;
                        break;
                    case 2:
                        italic = !italic;
                        break;
                    case 3:
                        underline = !underline;
                        break;
                }
            } while (n > 0 && n < 4);
        }
    }
}
