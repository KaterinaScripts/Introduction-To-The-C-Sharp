using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double firstNumber;
            double secondNumber;
            double thirdNumber;

            bool evenNumber;

          
            #region Задача №1

            Console.WriteLine("Задача №1");
            Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.\n");

            Console.WriteLine("Введите число: ");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            secondNumber = double.Parse(Console.ReadLine());

            if (firstNumber == secondNumber) Console.WriteLine("Числа равны.");
            else if (firstNumber >= secondNumber) Console.WriteLine($"Число {firstNumber} больше, чем число {secondNumber}");
            else if (firstNumber <= secondNumber) Console.WriteLine($"Число {secondNumber} больше, чем число {firstNumber}");

            firstNumber = 0;
            secondNumber = 0;

            Console.ReadKey();
            Console.Clear();

            #endregion


            #region Задача №2
            Console.WriteLine("Задача №2");
            Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.\n");

            Console.WriteLine("Введите первое число: ");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber) Console.WriteLine("Все числа равны.");


            else if (firstNumber >= secondNumber && firstNumber >= thirdNumber) Console.WriteLine($"Наибольшее число: {firstNumber}");
            else if (secondNumber >=firstNumber && secondNumber >= thirdNumber) Console.WriteLine($"Наибольшее число: {secondNumber}");
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber) Console.WriteLine($"Наибольшее число:  {thirdNumber}");

            firstNumber = 0;
            secondNumber = 0;
            thirdNumber = 0;

            Console.ReadKey();
            Console.Clear();

            #endregion


            #region Задача №3
            Console.WriteLine("Задача №3");
            Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.");

            Console.WriteLine("Введите число: ");
            firstNumber = double.Parse(Console.ReadLine());

            evenNumber = firstNumber % 2 == 0;

            if (evenNumber) Console.WriteLine($"Число {firstNumber} - чётное");
            else Console.WriteLine($"Число {firstNumber} - нечётное");

            firstNumber = 0;
            evenNumber = false;

            Console.ReadKey();
            Console.Clear();

            #endregion
                                     

            #region Задача №4
            Console.WriteLine("Задача №4");
            Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

            Console.WriteLine("Введите число: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Чётные числа от 1 до {firstNumber}");

            for (int i = 0; i <= firstNumber; i++)
            {
                evenNumber = i % 2 == 0;
                if (evenNumber) Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();

            #endregion
        }
    }
}
