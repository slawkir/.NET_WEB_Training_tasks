using System;

namespace _3._3._3._PIZZA_TIME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order(new User("123"), PizzaMenu.Margarita);
            var order2 = new Order(new User("456"), PizzaMenu.FourChees);

            Pizzeria pizzeria = new Pizzeria();

            pizzeria.Define(order1);
            pizzeria.Define(order2);

            pizzeria.Cooking();
        }
    }
}
