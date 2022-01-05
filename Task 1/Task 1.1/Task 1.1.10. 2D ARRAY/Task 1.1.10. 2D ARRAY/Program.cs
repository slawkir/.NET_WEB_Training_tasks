using System;

namespace Task_1._1._10._2D_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = randomArray();
            //наглядное представление двухмерного массива в виде матрицы
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"{Array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Сумма элементов массива, стоящих на чётных позициях равна  " + SumElementsArray(Array));
            Console.WriteLine("Количество строк: " + Array.GetLength(0));
            Console.WriteLine("Количество столбцов: " + Array.GetLength(1));
            Console.WriteLine("Общее количество элементов массива: " + Array.Length);
        }

        public static int[,] randomArray()
        {
            Random randomNumber = new Random();
            int[,] nums = new int[randomNumber.Next(2, 10), randomNumber.Next(2, 10)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = randomNumber.Next(-100, 100);
                }
            }
            return nums;
        }

        public static int SumElementsArray(int[,] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += Array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
