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
            string name = "Bogdanov";
            string surname = "Maxim";
            Console.WriteLine("До: Name: {0}, Surname: {1}", name, surname);
            (name, surname) = (surname, name);
            Console.WriteLine("После: Name: {0}, Surname: {1}", name, surname);
            Console.ReadKey();
        }
    }
}