/*9.Известны сопротивления двух несоединенных друг с другом участков электрической цепи и
  напряжение на каждом из них. По какому участку протекает меньший ток?*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int resFirst = 50;
            int voltFirst = 250;
            int resSecond = 36;
            int voltSecond = 550;
            int ampfirst = voltFirst / resFirst;
            int ampsecond = voltSecond / resSecond;
            int result;
            if (ampfirst < ampsecond)
            {
                result = ampfirst;
                Console.WriteLine("На первом участке меньше ток! Сила тока = {0}", result);
            }
            else
            {
                result = ampsecond;
                Console.WriteLine("На втором участке меньше ток! Сила Тока = {0}", result);
                
            }
            Console.ReadLine();
        }
    }
}
