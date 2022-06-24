using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystals = 0;
            int buyCost = 70;
            Console.WriteLine("Введите количество денег.");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Привет! Сегодня у нас кристаллы по {0} монет за штуку!", buyCost);
            Console.WriteLine("Сколько кристаллов вы хотите купить?");
            int buyCount = Convert.ToInt32(Console.ReadLine());
            money = (money - (buyCount * buyCost));
            Console.WriteLine("Вы купили {0} кристаллов за {1} монет. У вас осталось {2} монет.", buyCount, buyCost*buyCount, money);
            crystals = crystals + buyCount;
            Console.WriteLine("Теперь у вас {0} и {1} монет.", crystals, money);
            Console.ReadKey();
        }
    }
}