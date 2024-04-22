using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            int countPositive = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 101);
                if (array[i] > 0)
                {
                    countPositive++;
                }
            }

            Console.Write("Array: ");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nPositive numbers: " + countPositive);
        }
    }
}
