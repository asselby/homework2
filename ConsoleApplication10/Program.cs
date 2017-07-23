/*10.	 Напечатать "столбиком": 
a.	все целые числа от 20 до 35;
b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFirst = 20;
            int numberSecond = 25;
            int ten = 10;
            int fifty = 50;
            for (; numberFirst <= numberSecond; numberFirst++)
            {
                Console.WriteLine(numberFirst);
            }
            Console.WriteLine("Введите число Б, число должно быть больше 10: ");
            int numberB = Int32.Parse(Console.ReadLine());
            for (; ten < numberB; ten++)
            {
                Console.WriteLine(Math.Pow(ten, 2));
            }

            Console.WriteLine("Введите число A, число должно быть меньше 50: ");
            int numberA = Int32.Parse(Console.ReadLine());
            for (;  numberA<fifty; numberA++)
            {
                Console.WriteLine(Math.Pow(numberA, 3));

            }

            Console.WriteLine("Введите числа а и b, число а должно быть меньше b: ");
            int a= Int32.Parse(Console.ReadLine());
            int b= Int32.Parse(Console.ReadLine());
            for (; a < b; a++) {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
