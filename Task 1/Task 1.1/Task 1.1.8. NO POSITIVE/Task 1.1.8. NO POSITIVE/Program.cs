using System;

namespace Task_1._1._8._NO_POSITIVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            do
            {
                Console.Write("Введите длину 1-го измерения (dimension length) случайного трехмерного массива X: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    Console.WriteLine("Вы ввели некорректное значение длины измерения X. Пожалуйста, введите заново");
                }
            } while (x <= 0);
            do
            {
                Console.Write("Введите длину 2-го измерения (dimension length) случайного трехмерного массива Y: ");
                y = int.Parse(Console.ReadLine());
                if (y <= 0)
                {
                    Console.WriteLine("Вы ввели некорректное значение длины измерения X. Пожалуйста, введите заново");
                }
            } while (y <= 0);
            do
            {
                Console.Write("Введите длину 3-го измерения (dimension length) случайного трехмерного массива Z: ");
                z = int.Parse(Console.ReadLine());
                if (z <= 0)
                {
                    Console.WriteLine("Вы ввели некорректное значение длины измерения X. Пожалуйста, введите заново");
                }
            } while (z <= 0);


            int[,,] arr = new int[x, y, z];
            Random randomNum = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"{i}-й срез массива");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int m = 0; m < arr.GetLength(2); m++)
                    {
                        arr[i, j, m] = randomNum.Next(-10, 10);
                        Console.Write(arr[i, j, m] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //неположительный массив
            Console.WriteLine("Неположительный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"{i}-й срез массива");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int m = 0; m < arr.GetLength(2); m++)
                    {
                        if (arr[i, j, m] > 0)
                        {
                            arr[i, j, m] = 0;
                        }
                        Console.Write(arr[i, j, m] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
    }
}
