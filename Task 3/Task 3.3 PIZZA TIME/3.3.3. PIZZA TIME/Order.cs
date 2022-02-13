using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3._PIZZA_TIME
{
    public class Order
    {
        public User User { get; set; }
        public PizzaMenu PizzaMenu{ get; set; }
        public Order(User user, PizzaMenu pizzaMenu)
        {
            PizzaMenu = pizzaMenu;
            User = user;
        }

        public void OrderComleted()
        {
            Console.WriteLine($"{PizzaMenu} with order-ID {User.ID} is cooked");
        }

    }
}
