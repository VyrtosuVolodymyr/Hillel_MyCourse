using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество предметов:");
            int subjectsCount = Convert.ToInt32(Console.ReadLine());

            int[] punkts = new int[3];
            string[] subjects = new string[subjectsCount];

            for (int i = 0; i < subjectsCount; i++)
            {
                Console.Write($"Введите название предмета {i + 1}: ");
                subjects[i] = Console.ReadLine();
                Console.Write($"Введите оценку по предмету {subjects[i]}: ");
                punkts[i] = Convert.ToInt32(Console.ReadLine());
            }

            double average = Average(punkts);

            Console.WriteLine("Оценки студента: ");
            for (int i = 0; i < subjectsCount; i++)
            {
                Console.WriteLine($"{subjects[i]}: {punkts[i]}");
            }
            Console.WriteLine($"Средняя оценка:{average} ");
        }

        static double Average(int[] punkts)
        {
            int sum = 0;
            foreach (int i in punkts)
            {
                sum += i;
            }

            return (double)sum / punkts.Length;
        }

    }
}
