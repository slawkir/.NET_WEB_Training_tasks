using System;
using System.Globalization;
using System.Text;

namespace _3._3._2._SUPER_STRING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the text: ");
            string inputText = Console.ReadLine();

            Console.WriteLine(inputText.CheckLanguage());

        }
    }
}
