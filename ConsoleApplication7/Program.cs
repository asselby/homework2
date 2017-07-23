/*7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            double side = 2.5;
            double areaCircle = Math.PI * Math.Pow(radius,2);
            double areaSquare = Math.Pow(side, 2);
            double result;
            if (areaCircle < areaSquare)
            {
                result = areaSquare;
                Console.WriteLine("Площадь квадрата больше: " + areaSquare);
            }
            else {
                result = areaCircle;
                Console.WriteLine("Площадь круга больше: " + areaCircle);
            }
            Console.ReadLine();
        }

    }
}
