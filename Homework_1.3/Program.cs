using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
//r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2). Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//
//б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

//Симонов

namespace Homework_1._3
{
    class Program
    {
        static double GetPointsDistance(double x1, double y1, double x2, double y2)
        {
            double range = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return range;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите координаты Х первой точки: ");
                double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты Y первой точки: ");
                double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты Х второй точки: ");
                double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты Y второй точки: ");
                double y2 = double.Parse(Console.ReadLine());

            Console.Write("Расстояние между точками: " + "{0:F2}", GetPointsDistance(x1, y1, x2, y2));

            Console.ReadLine();

        }
    }
}
