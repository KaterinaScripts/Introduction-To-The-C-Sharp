using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Задание 1

            Console.Title = "Задание 1";
            Console.WriteLine("Задайте двумерный массив размером m * n, заполненный случайными вещественными(тип double) числами.");

            Random random = new Random();

            Console.WriteLine("Введите количество рядов массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество ячеек массива: ");
            int n = int.Parse(Console.ReadLine());
            double[,] firstArray = new double[m, n];
            
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    Console.WriteLine((firstArray[i,j] = random.NextDouble()) + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();


            #endregion

            

            #region Задание 2

            Console.Title = "Задание 2";
            Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, " +
                "и возвращает значение этого элемента или же указание, что такого элемента нет.");

            //Объявление массива
            int[,] secondArray =
            {
                { 1, 4, 7, 2 },
                { 5, 9, 2, 3 },
                { 8 ,4 ,2, 4 }
            };
            
            Console.WriteLine("Дан массив чисел:\n");

            for (int i = 0; i < secondArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    Console.Write(secondArray[i,j] + "\t");
                }
                Console.WriteLine();
            }


            //Ввод пользователя
            Console.WriteLine("Введите № ряда массива: ");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите № столбца массива: ");
            int column = int.Parse(Console.ReadLine());


            //Проверка на корректность ввода данных
            if (row < 0 || column < 0) Console.WriteLine("Позиция элемента не может быть отрицательной.");


            //Проверка на наличие элемента в массиве
            if (row > secondArray.GetLength(0) && column > secondArray.GetLength(1)) Console.WriteLine("Такого элемента нет в данном массиве.");
            else
            {
                object result = secondArray.GetValue(row, column);
                Console.WriteLine($"Такой элемент существует. Его значение = {result}");
            }

            Console.ReadKey();
            Console.Clear();


            #endregion
            

            
            #region Задание 3

            Console.Title = "Задание 3";
            Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

            //Объявление массива
            int[,] numbers =
            {
               { 1,4,7,2 },
               { 5,9,2,3 },
               { 8,4,2,4 }
            };

            Console.WriteLine("Среднее арифметическое каждого столбца: ");

          


            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                double average = 0;

                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    average += numbers[j, i];
                }
                average = average / numbers.GetLength(0);
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {average}");

            }



            Console.ReadKey();
            Console.Clear();


            #endregion
            
        }
    }
}
