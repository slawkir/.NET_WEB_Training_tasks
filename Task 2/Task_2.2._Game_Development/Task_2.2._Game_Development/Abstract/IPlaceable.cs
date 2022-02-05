using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development
{
    public interface IPlaceable
    {
        //свойства в методах лучше делать тоьлко с get (только возвращает значение)
        //свойство, которое можно переприсвоить, лучше для abstract class
        public Point Position { get; }
    }
}
