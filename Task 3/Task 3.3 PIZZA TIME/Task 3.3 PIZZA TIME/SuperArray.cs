using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3_PIZZA_TIME
{
    public static class SuperArray
    {
        public static void ActionInArray<T>(this T[] items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }
        static int SumElements(this int[] items)
        {
            int sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }

        static int AverageOfElements(this int[] items)
        {
            int average = items.SumElements() / items.Length;
            return average;
        }

        static int FreqRepElement<T>(int[] arr, int item)
        {
            int freqelement = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    freqelement++;
                }
            }

            return freqelement;
        }
    }
}
