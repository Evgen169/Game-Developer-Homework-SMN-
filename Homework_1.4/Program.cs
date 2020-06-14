using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

//Симонов

namespace Homework_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(0, 6);
            int b = rnd.Next(6, 11);

            Console.WriteLine("Первая переменная: " + a);
            Console.WriteLine("Вторая переменная: " + b);

            Console.WriteLine();

            Console.WriteLine("Меняем значения переменных местами через третью переменную:");
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Первая переменная: " + a);
            Console.WriteLine("Вторая переменная: " + b);

            Console.WriteLine();

            Console.WriteLine("Меняем значения переменных обратно, но уже без третьей переменной:");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Первая переменная: " + a);
            Console.WriteLine("Вторая переменная: " + b);

            Console.ReadLine();
        }
    }
}
