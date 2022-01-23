using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1._GAME
{
    public class Monster
    {
        protected int EnemyWeight = 10;
        protected int EnemyStrench = 10;
        protected int EnemyHealth = 10;
       
        public abstract int DamageValue { get; }
        public virtual void SetDamage(Player p)
        {
            p.GetDamage(DamageValue);
        }
    }
}
