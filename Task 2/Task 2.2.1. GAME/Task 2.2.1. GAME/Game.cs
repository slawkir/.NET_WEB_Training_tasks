using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1._GAME
{
    public class Game
    {
        private GameField gameField;
        public Game(int width, int height)
        {
            Width = width;
            Height = height;
            gameField = new GameField(width, height);
        }

        public static int Height { get; private set; }
        public static int Width { get; private set; }

        public void MoveController(ConsoleKey cli)
        {

        }
    }
}
