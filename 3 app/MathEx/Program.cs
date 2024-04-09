﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первая програма про обратное число.
            bool ProgramOpen = true;
            do
            {
                Console.Write("-Введите 3-значное число: ");
                int NumberByUser = Convert.ToInt32(Console.ReadLine());
                if (NumberByUser < 100 || NumberByUser > 999)
                {
                    Console.WriteLine("-Вы ввели что-то не так!");
                    continue;
                }

                int ReverseNumber = 0;
                int originalNumber = NumberByUser;
                while (NumberByUser > 0)
                {
                    int LastNum = NumberByUser % 10;
                    ReverseNumber = ReverseNumber * 10 + LastNum;
                    NumberByUser /= 10;
                }

                Console.WriteLine($"-Ваше число: {originalNumber}, число с переставленными цифрами: {ReverseNumber}");
                ProgramOpen = false;
            } while (ProgramOpen);


            //Втоая программа про  квадрат 
            Console.WriteLine("-Посчитайте периметр квадрата!");
            Thread.Sleep(900);
            Console.Write("-Напишите значение 1 стороны: ");
            int per_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Напишите значение 2 стороны: ");
            int per_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Напишите значение 3 стороны: ");
            int per_3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Напишите значение 4 стороны: ");
            int per_4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"-Ответ: {per_1 + per_2 + per_3 + per_4} ");

            //Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
            bool ProgOpen = true;
            while (ProgOpen)
            {
                Console.WriteLine("Введите трехзначное число:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 100 || number > 999)
                {
                    Console.WriteLine("-Вы ввели неправильно!");
                    continue;
                }
                if (number > 100 || number < 999)
                {


                    int firstDigit = number / 100;
                    int secondDigit = (number / 10) % 10;
                    int thirdDigit = number % 10;


                    int newNumber = secondDigit * 100 + firstDigit * 10 + thirdDigit;

                    Console.WriteLine($"Число, полученное после перестановки первой и второй цифр: {newNumber}");
                    ProgOpen = false;
                }

            }

            //4) Написати програму, яка обчислює середнє арифметичне двох чисел.
            Console.WriteLine("-Рассчитаем сред.арифмет. число!");
            Console.Write("-Напишите  первое число: ");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Напишите второе число: ");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Напишите третье число: ");
            int Third = Convert.ToInt32(Console.ReadLine());
            int AllNumbers = 3;

            double averge = (First + Second + Third) / AllNumbers;
            Console.WriteLine($"-Ваш ответ: {averge}");

            //5) Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат.
            Console.Write("-Рассчитаем радиус круга! \n-Введите раидус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double Pi = Math.PI;
            double area = Pi * radius * radius;

            Console.WriteLine($"Ваш ответ - {area}");


        }
    }
}
