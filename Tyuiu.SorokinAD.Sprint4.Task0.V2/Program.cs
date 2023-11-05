using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint4.Task0.V2.Lib;

namespace Tyuiu.SorokinAD.Sprint4.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил: Сорокин А. Д. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");
            int s = ds.GetSumOddArrEl(array);

            Console.WriteLine("Сумма нечетных элементов массива = " + s);
            Console.ReadKey();
        }
    }
}
