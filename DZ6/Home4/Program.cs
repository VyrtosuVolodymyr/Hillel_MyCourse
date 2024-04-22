using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();


            int maxSize = 20;
            int[] array = new int[maxSize];

            for (int i = 0; i < maxSize; i++)
            {
                array[i] = rand.Next(-5, 6);
            }

            Console.WriteLine("Array elements until -1 is encountered:");
            foreach (int num in array)
            {
                if (num == -1)
                {
                    break;
                }
                Console.Write(num + " ");
            }
        }

    }
}
