using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1._GAME
{
    public interface IBody
    {
        int Health { get; }
        int Strench { get; }
        int Weight { get; }

        void SetStrench(int i);

        void SetHealth(int i);

        void GetDamage(int i);
    }
}
