using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._3._3._PIZZA_TIME
{
    public class Pizzeria
    {
        public event Action PizzaStatus = delegate { };
        public void Define(Order order) => PizzaStatus += order.OrderComleted;

        public void Cooking()
        {
            Console.WriteLine("Order completed successfully!");
            Thread.Sleep(5000);
            PizzaStatus();
        }
    }
}
