using System;

namespace Task_1._1._7._ARRAY_PROCESSING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random array
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            Console.WriteLine("Случайный массив: ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.Write(arr[arr.Length - 1]);
            Console.WriteLine();

            //max value of array
            Console.WriteLine();
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Максимальное значение элемента в массиве: {max}");

            //min value of array
            Console.WriteLine();
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Минимальное значение элемента в массиве: {min}");

            //sorted array
            Console.WriteLine();
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.Write(arr[arr.Length - 1]);
            
            Console.ReadLine();
        }
    }
}
