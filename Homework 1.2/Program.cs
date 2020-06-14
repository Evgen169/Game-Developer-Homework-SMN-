using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); 
//где m — масса тела в килограммах, h — рост в метрах.

//Симонов

namespace Homework_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите рост (см): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите вес (кг): ");
            double weight = double.Parse(Console.ReadLine());

            double massIndex = weight / (height/100 * height/100);
            Console.Write("Индекс массы тела: " + "{0:F1}", massIndex);

            //if (massIndex <= 18.5)
            //    Console.Write(", недостаточная масса тела.");
            //else if (massIndex > 18.5 && massIndex <= 25)
            //    Console.Write(", масса тела в норме.");
            //else if (massIndex > 25 && massIndex <= 30)
            //    Console.Write(", избыточная масса тела.");
            //else if (massIndex > 30 && massIndex <=40)
            //    Console.Write(", пришло время задуматься о питании салатами.");
            //else if (massIndex > 40)
            //    Console.Write(", масса подходит к критической, угроза взрыва сверхновой!");

            Console.ReadLine();
        }
    }
}
