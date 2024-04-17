using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 146);
            Console.WriteLine("-You should write correcct random number, from 1 to 146!");

            while (true)
            {
                Console.Write("Write your number: ");
                int userNumber;
                if (int.TryParse(Console.ReadLine(), out userNumber))
                {
                    if (userNumber < 1 || userNumber > 146)
                    {
                        Console.WriteLine("Please write number from 1 to 146");
                        continue;
                    }
                    if (userNumber > randomNum)
                    {
                        Console.WriteLine("No,number less");
                    }
                    else if (userNumber < randomNum)
                    {
                        Console.WriteLine("No,number bigger");
                    }
                    else
                    {
                        Console.WriteLine("Yes, it's correct number!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Plese enter a correct number");
                }
            }
        }
    }
}
