using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoginMA.Sprint4.Task6.V14.Lib;

namespace Tyuiu.GoginMA.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Класс Array                                                      *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #14                                                            *");
            Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан строковый массив данных: Январь, Февраль, Март, Апрель, Май, Июнь, *");
            Console.WriteLine("* Июль. Используя класс Array, вывести элементы массива, длина которых   *");
            Console.WriteLine("* больше 3 символа.                                                      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            var months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= months.Length - 1; i++)
            {
                Console.WriteLine(months[i]);
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Элементы, длина которых > 3:");
            string[] months2 = ds.Calculate(months);
            for (int i = 0; i <= months2.Length - 1; i++)
            {
                Console.WriteLine(months2[i]);
            }
            Console.ReadKey();
        }
    }
}
