using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._2._SUPER_STRING
{
    public static class LanguageExtension
    {
        public static string CheckLanguage(this string str)
        {
            //str = str.ToLower();

            if (str == "")
            {
                return "Empty";
            }
            //x20, x21, x2C, x2E (пробел !  , .)
            else if (str.All(element => (element == '\x20' || element == '\x21' || element == '\x2C' || element == '\x2E') || (element >= '\x41' && element <= '\x7A')))
            {
                return "English language";
            }
            else if (str.All(element => (element == '\x20' || element == '\x21' || element == '\x2C' || element == '\x2E') || (element == '\x401') || (element == '\x451') || (element >= '\x410' && element <= '\x44F'))) //x401, x451 - буквы Ё, ё
            {
                return "Russian language";
            }
            else if (str.All(element => (element == '\x20') || (element >= '\x30' && element <= '\x39')))
            {
                return "Numbers";
            }
            else
            {
                return "Mixed";
            }

        }










    }
}
