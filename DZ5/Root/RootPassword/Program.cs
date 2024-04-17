using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "root";
            while (true)
            {
                Console.Write("-Write correct password: ");
                string userPass = Console.ReadLine();
                if (userPass == correctPassword)
                {
                    Console.WriteLine("-Good! You write correct password!");
                    break;

                }
                else
                {
                    Console.WriteLine("Error!No correct password!");

                }
            }
        }
    }
}
