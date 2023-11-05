using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint4.Task1.V5.Lib;

namespace Tyuiu.SorokinAD.Sprint4.Task1.V5
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = new int[15];
            Console.WriteLine("Введите элементы массива ");
            for (int i = 0; i <= 14; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива от 5 до 9: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");
            int s = ds.Calculate(array);

            Console.WriteLine("Сумма четных элементов массива = " + s);
            Console.ReadKey();
        }
    }
}
