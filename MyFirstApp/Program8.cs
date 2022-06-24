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
            int countOfRow;
            int minutesOfVisit = 10;
            int minutesInHour = 60;
            Console.WriteLine("Введите количество бабусек в очереди.");
            countOfRow = Convert.ToInt32(Console.ReadLine());

            int minutesOfWait = minutesOfVisit * countOfRow;
            int hoursOfWait = minutesOfWait / minutesInHour;
            int minutesOutHours = minutesOfWait - hoursOfWait * minutesInHour;

            Console.WriteLine("Вы должны протерпеть в очереди {0}ч {1}м", hoursOfWait, minutesOutHours);
            Console.ReadKey();
        }
    }
}
