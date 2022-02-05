using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1._CUSTOM_STRING
{
    internal class MyString
    {
        //строка как массив символов
        public char[] Text;

        public MyString(string str)
        {
            Text = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                Text[i] = str[i];
            }
        }

        //comparison сравнение
        public bool Comparison(MyString str1, MyString str2)
        {          
            if (str1.Text.Length == str2.Text.Length)
            {
                for (int i = 0; i < Text.Length; i++)
                {
                    if (str1.Text[i] != str2.Text[i])
                    {
                        return false;

                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        //concatenation конкатенация
        public char[] Concatenation(MyString strA, MyString strB)
        {
            var sum = strA.Text.Concat(strB.Text).ToArray();
            return Text = sum;
        }

        //поиск символов booll
        public bool IsThereChar(MyString str, char symbol)
        {
            if (str.Text.Contains(symbol))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //поиск символа с возвратом индекса
        public int SearchCharIndex(MyString str, char symbol)
        {
            return Array.IndexOf(str.Text, symbol);

        }

        //конвертация из/в массив символов conversion from/to array characters
        public string ConvertToString()
        {
            return new string(Text);
        }

        //индексатор
        public char this[int index]
        {
            get
            {
                return Text[index];
            }
            set
            {
                Text[index] = value;
            }                 
        }   
    }
}
