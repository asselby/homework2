/*4.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekDays = 7;
            int days = 234;
            int result = days / weekDays;
            Console.WriteLine("В {0} днях = {1} недель!", days, result);
            Console.ReadLine();
        }
    }
}
