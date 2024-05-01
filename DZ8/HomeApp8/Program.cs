using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeApp8
{
    internal class Program
    {
        static public int MoneyInCart = 0;
        enum goods
        {
            Food = 1,
            Clothing = 2,
            Electronics = 3,
            Books = 4,

        }

        static void Main(string[] args)
        {
            MenuMarket();
            BuyGoodsByUser();
            Console.WriteLine($"Total cost of all items in the cart: {MoneyInCart}$");

        }


        private static void MenuMarket()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\t Welcome to the Market-Loops");
            Console.BackgroundColor = ConsoleColor.Black;



        }

        private static void BuyGoodsByUser()
        {

            Console.WriteLine("In this market we have many types goods for you");
            Console.WriteLine($"You bought for {MoneyInCart} dollars");
            bool appOpen = true;
            while (appOpen)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("If you want end your shopping - write 'exit' ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Types of products");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("1) Food\n2) Clothing\n3) Electronics\n4) Books");
                Console.WriteLine("\n-Enter the number of what type of product you want to buy or write 'exit' for back to menu:  ");
                string userExit = Console.ReadLine();
                if (userExit == "exit".ToLower())
                {
                    appOpen = false;
                    continue;
                }


                int chooseUser = Convert.ToInt32(userExit);
                if (chooseUser > 4)
                {
                    Console.WriteLine("Error, please write types from 1 to 4 maximun, or write exit for back to menu");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (chooseUser <= 4)
                {
                    string usersItem;
                    int usersPrice;

                    Console.WriteLine($"You choose {((goods)chooseUser).ToString()} ");

                    Console.Write("Write what do you want: ");
                    usersItem = Console.ReadLine();
                    Console.Write("Wirte price: ");
                    usersPrice = Convert.ToInt32(Console.ReadLine());
                    MoneyInCart += usersPrice;

                    Console.WriteLine($"In your cart: {usersItem}, price of this product: {usersPrice} \nTotal now is:{MoneyInCart}$");
                    Console.WriteLine("\n-If you want continue shopping, choose another type.");
                }
            }


        }
    }
}
