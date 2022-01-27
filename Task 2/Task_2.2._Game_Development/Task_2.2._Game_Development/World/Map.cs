using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development
{
    //хранит игроков, зомби, бонусы 
    //class map должен иметь размещения
    public class Map
    {
        public Player? Player { get; private set; } //можно init проверка: сущность будет указана в конструкторе или инициализаторе класса при создании экземпляра

        //public Zombie Zombie { get; private set; } //если зомби 1 на карте
        public List<Zombie> Zombies { get; private set; }
        public Map()
        {
            Zombies = new List<Zombie>();
        }


        public void InstantiantePlayer(Point spawnPoint) //создает экземпляр класса
        {
            Player = new Player(spawnPoint);
        }
        public void InstantianteZombie() //появляется зомби на карте - нужно вызывать этот метод
        {
            Zombies.Add(new Zombie(spawnPoint));
        }

        public void PrintState() // вывод состояния карты
        {
            Console.WriteLine("Map with existing objects: ");
            
            Console.WriteLine($"Player: {Player}");
            
            foreach (var item in Zombies) // вывод всех зомбей
            {
                Console.WriteLine(item);
            }
        }

    }
}
