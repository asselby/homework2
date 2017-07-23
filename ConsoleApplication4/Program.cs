/*5.	Дано двузначное число. Найти:
a.	число десятков в нем;
b.	число единиц в нем;
c.	сумму его цифр;
d.	произведение его цифр
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 45;
            int ten = 10;
            int des = number /ten;
            int units = number % ten;
            int summ = des + units;
            int multipl = des * units;
            Console.WriteLine("Число: {0};\nКоличество десятков: {1};\nКоличество единиц:{2};\nСумма цифр: {3};\nПроизведение чисел:{4}; ", number, des, units, summ, multipl);
            Console.ReadLine();
        }
    }
}
