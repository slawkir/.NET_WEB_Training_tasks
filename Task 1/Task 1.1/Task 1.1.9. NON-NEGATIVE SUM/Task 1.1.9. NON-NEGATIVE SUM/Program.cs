using System;

namespace Task_1._1._9._NON_NEGATIVE_SUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Введите количество элементов массива: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    Console.WriteLine("Вы ввели нерректное значение. Пожалуйста, введите заново");
                }
            } while (x <= 0);
            
            int[] nums = new int[x];
            int sum = 0;
            Random randomNumber = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randomNumber.Next(-100, 100);
                Console.Write(nums[i] + "  ");
                if (nums[i] >= 0)
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма неотрицательных элементов массива равна: {sum}");
        }
    }
}
