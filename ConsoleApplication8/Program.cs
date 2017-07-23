/*8.	 Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacityOxy = 25;
            double massOxy = 15;
            double capacityGas = 35;
            double massGas = 15;
            double densityOxy = massOxy / capacityOxy;
            double densityGas = massGas / capacityGas;
            double result;
            if (densityOxy < densityGas)
            {
                result = densityGas;
                Console.WriteLine("Плотность второго материала больше " + densityGas);
            }
            else
            {
                result = densityOxy;
                Console.WriteLine("Плотность первого материала больше " + densityOxy);
            }
            Console.ReadLine();
        }
    }
}
