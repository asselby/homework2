/*6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
a.	А или В; 
b.	А и В; 
c.	В или С.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;
            bool resultFirst = A ||B;
            bool resultSecond = A && B;
            bool resultThird = B || C;
            Console.WriteLine("А или В = {0}", resultFirst);
            Console.WriteLine("А и В = {0}", resultSecond);
            Console.WriteLine("В или С = {0}", resultThird);
            Console.ReadLine();
        }
    }
}
