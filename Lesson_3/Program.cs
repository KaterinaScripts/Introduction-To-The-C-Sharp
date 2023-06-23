using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string answer;
            bool appIsRunning;
            int N;

            double 
                x1 = 0.0, 
                y1 = 0.0, 
                z1 = 0.0, 
                x2 = 0.0, 
                y2 = 0.0, 
                z2 = 0.0, 
                distance;
            #endregion

            #region Methods
            bool Continue()
            {
                appIsRunning = true;
                Console.WriteLine("Продолжить подсчёты?\nОтветьте либо 'Да', либо 'Нет'");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "Да":
                    case "да":
                        appIsRunning = true;
                        break;
                    case "Нет":
                    case "нет":
                        appIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        Continue();
                        break;
                }
                return appIsRunning;
            }

            double Print(string coordinate, double number)
            {
                Console.Write($"Введите {coordinate}: ");
                return number = double.Parse(Console.ReadLine());
            }
            #endregion

            #region Tasks
            #region Задача 1

            Console.Title = "Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.";

            do
            {
                Console.Write("Введите пятизначное число: ");
                string input = Console.ReadLine();

                if (input.Length < 5 || input.Length > 5)
                {
                    Console.WriteLine("Это не пятизначное число!\nВведите корректное число.\n");
                }
                else
                {
                    if (input[0] == input[4] && input[1] == input[3]) Console.WriteLine($"Число {input} является палиндромом.\n");
                    else Console.WriteLine($"Число {input} не является палиндромом.\n");
                }
                
            }
            while (Continue());

            Console.Clear();
            #endregion
            

            #region Задача 2
            Console.Title = "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.";
           
            do
            {
                Console.Write("Введите координаты всех точек.\n");
            // ручной ввод точек

            x1 = Print("x1", x1);
            y1 = Print("y1", y1);
            z1 = Print("z1", z1);

            x2 = Print("x2", x2);
            y2 = Print("y2", y2);
            z2 = Print("z2", z2);

            distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

            Console.WriteLine($"\nРасстояние = {distance}");
            } while (Continue());

            Console.Clear();
            #endregion


            #region Задача 3
            Console.Title = "Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.";
            do
            {
                Console.Write("Введите число N: ");
                N = int.Parse(Console.ReadLine());
                double square;

                for(int i = 1; i <= N; i++)
                {
                    square = Math.Pow(i, 3);
                    Console.WriteLine(square);
                }
            } while (Continue());
            Console.ReadKey();
            Console.Clear();
            #endregion
            #endregion
        }
    }
}
