using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Market market = new Market();
            Market.ShowMarket(market);
            Console.WriteLine();
            bool CheckBuy = true;
            while (CheckBuy)
            {
                Console.Write("-What you want buy?: ");
                string chooseUser = Console.ReadLine();
                if (chooseUser == "PS5" || chooseUser == "ps5")
                {
                    Console.WriteLine("Nice, you buy PS5");
                    CheckBuy = false;
                }
                else if (chooseUser == "XBOX ONE" || chooseUser == "Xbox one" || chooseUser == "Xbox One" || chooseUser == "xbox one")
                {
                    Console.WriteLine("-Nice you but XBOX ONE1");
                    CheckBuy = false;
                }
                else
                {
                    Console.WriteLine("-Plese write what you want buy!");
                }
            }
            
                
            

        }

        static void Menu() 
        {
            Console.WriteLine("================================================================ SHOP FROM GAMERS =================================================================");
            Console.WriteLine("-App made by vova_rtt");

        }

        public class Market
        {
            public string PS5 = "PS5";
            public int PricePS5 = 550;

            public string XBOXONE = "XBOX ONE";
            public int PriceXboxOne = 450;

           public static void ShowMarket(Market market) 
            {
                Console.WriteLine($"{market.PS5}. Price = {market.PricePS5}$");
                Console.WriteLine($"{market.XBOXONE}. Proce = {market.PriceXboxOne}$");

            }
        
        }

            
    }
}
