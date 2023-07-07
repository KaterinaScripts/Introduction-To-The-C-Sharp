using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1

            Console.Title = "Задание 1";
            Console.WriteLine("Задайте массив, заполненный случайными положительными трёхзначными числами\nНапишите программу, которая покажет количество чётных чисел в массиве.\n");

            int[] firstArray = { 345, 897, 568, 234 };
            int evenNumbers = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] % 2 == 0) evenNumbers++;
            }

            Console.WriteLine($"В данном массиве {evenNumbers} чётных чисел");

            Console.ReadKey();
            Console.Clear();


            #endregion
           

            #region Задание 2

            Console.Title = "Задание 2";
            Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.");

            int[] secondArray = { 3, 7, 23, 12 };
            int sum = 0;

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (i % 2 != 0) sum += secondArray[i];
            }
            Console.WriteLine($"Сумма чисел нечётных индексов = {sum}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            

            #region Задание 3

            Console.Title = "Задание 3";
            Console.WriteLine("Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементом массива.");

            int[] thirdArray = { 22, 42, 15, 77, 65 };
            int min = thirdArray[0];
            int max = thirdArray[0];

            for (int i = 1; i < thirdArray.Length; i++)
            {
                if (thirdArray[i] < min) min = thirdArray[i];
                if (thirdArray[i] > max) max = thirdArray[i];
            }
            Console.WriteLine($"Минимальное число = {min},\nМаксимальное число = {max},\nРазница чисел = {max - min}");

            Console.ReadKey();
            Console.Clear();
            #endregion


}
}
}
