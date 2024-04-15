using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4app
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            bool IsOpen2 = true;
            while (IsOpen2)
            {
                Console.Write("Write your first number: ");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write your second number: ");
                int secondNum = Convert.ToInt32(Console.ReadLine());
                if (firstNum == secondNum)
                {
                    Console.WriteLine("-Numbers  are equal");

                }
                else if (firstNum > secondNum)
                {
                    Console.WriteLine("First number bigger then second");

                    IsOpen2 = false;

                }
                else
                {

                    Console.WriteLine("The first number is less than the second ");
                    IsOpen2 = false;

                }
                Thread.Sleep(1500);
            }


            //Написати програму, в якій користувач вводить номер місяця. Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»; 9-11 – «Осінь». У будь-якому іншому випадку - "Немає такого місяця на цій планеті" .

            bool isOpen3 = true;
            while (isOpen3)
            {
                Console.Write("-Write month number: ");
                int monthNumber = Convert.ToInt32(Console.ReadLine());
                switch (monthNumber)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Winter");
                        isOpen3 = false;
                        break;

                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Spring");
                        isOpen3 = false;

                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Summer");
                        isOpen3 = false;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("autumn");
                        isOpen3 = false;
                        break;

                    default:
                        Console.WriteLine("Error, unknowing month!");
                        break;

                }
                Thread.Sleep(1500);
            }


            //3*) Напишіть програму, яка приймає від користувача число від 1 до 100. При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz. Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz. Завдання може здатися очевидним, але потрібно отримати найбільш просте та красиве рішення.
            bool IsOpen4 = true;
            while (IsOpen4)
            {

                Console.WriteLine("Write number from 1 to 100:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 1 || number > 100)
                {
                    Console.WriteLine("Error! Please write number from 1 to 100");
                    continue;
                }

                if (number % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    IsOpen4 = false;
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    IsOpen4 = false;
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    IsOpen4 = false;
                }
                else
                {
                    Console.WriteLine(number);
                    IsOpen4 = false;
                }

                Thread.Sleep(1500);
            }


            //4
            int a = GenerateCoefficient();
            int b = GenerateCoefficient();
            int c = GenerateCoefficient();

            Console.WriteLine($"The formed equation: {a}x^2 + {b}x + {c} = 0");

            double discriminant = CalculateDiscriminant(a, b, c);
            AnalyzeDiscriminant(a, b, discriminant);


        }
        static int GenerateCoefficient()
        {
            return random.Next(-10, 11);
        }

        static double CalculateDiscriminant(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        static void AnalyzeDiscriminant(int a, int b, double discriminant)
        {
            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2.0 * a);
                Console.WriteLine("The equation has one root: x = " + root);
            }
            else
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDiscriminant) / (2 * a);
                double root2 = (-b - sqrtDiscriminant) / (2 * a);
                Console.WriteLine("The equation has two roots: x1 = " + root1 + ", x2 = " + root2);
            }
        }
    }
}
