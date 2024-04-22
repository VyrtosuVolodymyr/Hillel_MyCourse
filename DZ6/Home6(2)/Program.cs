using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1)
            int[] originalArray = { 5, -9, 8, 7 };
            int[] reversedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                reversedArray[i] = originalArray[originalArray.Length - 1 - i];
            }

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Reversed Array: " + string.Join(", ", reversedArray));

            //2)


            int[] array = { 5, -9, 8, 7 };

            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            Console.WriteLine("Reversed Array: " + string.Join(", ", array));
        }
    }
}
