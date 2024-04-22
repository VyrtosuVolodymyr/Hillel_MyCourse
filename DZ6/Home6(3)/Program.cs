using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

           
            int[] originalArray = new int[10];
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = rand.Next(-100, 101);
            }

         
            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));

            
            int newElement = rand.Next(-100, 101);

           
            int[] newArray = new int[11];

            newArray[0] = newElement;

            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i + 1] = originalArray[i];
            }

            Console.WriteLine("New Array with Element at Start: " + string.Join(", ", newArray));
        }
    }
}
