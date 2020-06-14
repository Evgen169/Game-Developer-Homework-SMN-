using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

//Симонов

namespace Homework_1._5
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }
        static void PrintCenter(string name)
        {
            //Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - (name.Length / 2), Console.WindowHeight / 2);
            Console.WriteLine(name);
            //Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите имя, фамилию и город: ");
            string name = Console.ReadLine();

            //Console.Write("Введите фамилию: ");
            //string surname = Console.ReadLine();
            //Console.Write("Введите город: ");
            //string place = Console.ReadLine();    

            PrintCenter(name);

            Pause();
        }
    }
}
