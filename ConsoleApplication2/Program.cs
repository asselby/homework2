/*3.	Дано расстояние в сантиметрах.Найти число полных метров в нем.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1200;
            int second = 1300;
            int metres =first/100;
            int metresSecond = second / 100;
            Console.WriteLine(first+ "см. = " +metres+ "м.\n"+ second + "см. = " + metresSecond + "м.\n");
            Console.ReadLine();
        }
    }
}
