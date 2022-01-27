using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._Game_Development.Common;






namespace Task_2._2._Game_Development
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Map map = new Map();
            map.InstantiantePlayer(Point.Zero); //создание игрока на карте
            
            for (int i = 0; i < 12; i++) // создание 12 зомбей
            {
                map.InstantianteZombie(new Point(10, 25));
            }
         
        }
       
    }
}
