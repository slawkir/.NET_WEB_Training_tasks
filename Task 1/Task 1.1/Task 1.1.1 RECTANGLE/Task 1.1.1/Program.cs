using System;

namespace Task_1._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA;
            int sideB;
            
            do
            {
                Console.WriteLine("Enter length of side A: ");
                sideA = int.Parse(Console.ReadLine());
                if (sideA <= 0)
                {
                    Console.WriteLine("ERROR!!! You entered incorrect data");
                }
            } while (sideA <= 0);

            do
            {
                Console.WriteLine("Enter length of side B: ");
                sideB = int.Parse(Console.ReadLine());
                if (sideB <= 0)
                {
                    Console.WriteLine("ERROR!!! You entered incorrect data");
                }
            } while (sideB <= 0);

            int areaofRectangle = sideA * sideB;
            Console.WriteLine("Area of the rectangle equals: {0}", areaofRectangle);
        }
    }
}
