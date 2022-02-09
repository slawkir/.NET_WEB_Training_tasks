using System;

namespace Task_3._1._Weakest_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int PeopleInCircle = InputNumber.SetNumber();

            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
            int removedNumber = InputNumber.SetNumber();

            int round = 0;
            while (PeopleInCircle >= removedNumber)
            {
                round += 1;
                PeopleInCircle -= 1;
                Console.WriteLine($"Раунд {round}.Вычеркнут человек.Людей осталось: {PeopleInCircle}");
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");           
        }
    }
}
