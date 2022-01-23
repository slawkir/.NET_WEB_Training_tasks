using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1._GAME
{
    public class GameField
    {
        public GameField(int width, int height)
        { 
        
        }
        private void FieldFill(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Field[i, j] = ".";
                }
            }
        }
    }
}
