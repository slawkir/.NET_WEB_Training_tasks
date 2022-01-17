using System;

namespace Task_2._1._1._CUSTOM_STRING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString myString = new MyString("");
           


            //сравнение
            MyString str1 = new MyString("Hello World");
            MyString str2 = new MyString("Hello World");
            if (myString.Comparison(str1, str2))
            {
                Console.WriteLine("Объекты str1 и str2 равны");
            }
            else
            {
                Console.WriteLine("Объекты str1 и str2 не равны");
            }
            
            //конкатенация
            char[] CommomSymbolArray = myString.Concatenation(new MyString("Hello"), new MyString("World"));
            Console.WriteLine(CommomSymbolArray[3]);
            

            //поиск символа
            bool IsCharInStr = myString.IsThereChar(new MyString("program"), 'm');
            Console.WriteLine(IsCharInStr);

            //поиск символа2
            int indexOfCharInArray = myString.SearchCharIndex(new MyString("Hello"), 'm');
            Console.WriteLine(indexOfCharInArray);


            //конвертация к строке
            string ConvertFromCharArray = str1.ConvertToString();
            Console.WriteLine(ConvertFromCharArray);

        }
    }
}
