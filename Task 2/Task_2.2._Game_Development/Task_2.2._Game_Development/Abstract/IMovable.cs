using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development
{
    public interface IMovable
    {
        //для движущихся элементов на карте: игрок, монстры
        void Move(Point to);
    }
}
