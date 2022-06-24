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
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Ваш знак зодиака?");
            string sign = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            var age = Console.ReadLine();
            Console.WriteLine("Ваша профессия?");
            string job = Console.ReadLine();
            Console.WriteLine("Вас зовут {0}, вам {2} лет и вы {1}. Ваша профессия {3}.", name, sign, age, job);
            Console.ReadKey();
        }
    }
}