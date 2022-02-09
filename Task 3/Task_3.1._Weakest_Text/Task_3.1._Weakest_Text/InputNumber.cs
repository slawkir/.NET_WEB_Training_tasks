using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._Weakest_Text
{
    public class InputNumber
    {
        public static int SetNumber()
        {
            int result;
            do
            {
                result = int.Parse(Console.ReadLine());
            } while (result <= 0);
            return result;
        }
    }
}
