using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//    в) используя вывод со знаком $.

//Симонов


namespace Homework_1._1
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
            Console.Write("      Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("  Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("  Введите возраст: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Введите рост (см): ");
            byte height = byte.Parse(Console.ReadLine());
            Console.Write(" Введите вес (кг): ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ваши данные:\n");

            Console.Write(name + " " + surname + ", возраст " + age + ", рост " + height + " см., вес " + weight + " кг.\n");
            Console.WriteLine();

            string output = String.Format("{0} {1}, возраст {2}, рост {3} см., вес {4} кг.", name, surname, age, height, weight);
            Console.WriteLine(output);
            Console.WriteLine();

            Console.WriteLine($"    Имя: {name}\nФамилия: {surname}\nВозраст: {age}\n   Рост: {height}\n    Вес: {weight}\n");
            Pause();
            Console.Write("Нажмите ENTER для удаления персональных данных...") ;
            Pause();
            Console.Clear();
            PrintCenter("Персональные данные удалены.");
            Pause();
        }
    }
}
