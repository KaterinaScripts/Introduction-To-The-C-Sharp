using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1

            Console.Title = "Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.";

            Console.WriteLine("Введите число: ");
            int input = int.Parse(Console.ReadLine());

            Calculation(input);

            void Calculation(int number)
            {
                Console.WriteLine(--number);
                if (number == 0) return;
                Calculation(number);  
            }
            Console.ReadKey();
            Console.Clear();
            #endregion

            

            #region Задача 2

            Console.Title = "Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.";

            int result = 0;

            Console.WriteLine("Введите число M: ");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            Calculation2(M, N);

            void Calculation2(int number1, int number2)
            {
                result += number1;
                number1++;
                
                if(number1 > number2) return;
                Calculation2(number1, number2);
            }

            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {result}.");

            Console.ReadKey();
            Console.Clear();
            #endregion

            

            #region Задача 3

            Console.Title = "Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.";

            Console.WriteLine("Введите число m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            int A(int num1, int num2)
            {
                if (num1 == 0) return num2 + 1;
                else if (num2 == 0) return A(num1 - 1,1);
                else return A(num1 - 1, A(num1, num2 - 1));
            }

            Console.WriteLine($"A({m},{n}) = {A(m,n)}");

            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
