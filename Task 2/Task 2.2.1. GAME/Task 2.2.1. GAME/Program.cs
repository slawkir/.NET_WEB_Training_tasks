using System;

namespace Task_2._2._1._GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(10, 50);
            while (true)
            {
                game.MoveController(Console.ReadKey().Key);
            }
        }
    }
}
