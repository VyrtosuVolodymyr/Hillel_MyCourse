using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliCCa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1; col <= 10; col++)
                {

                    Console.Write($"{col} x {row} = {col * row,2}");


                    if (col != 10)
                    {
                        Console.Write("\t");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
