using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Shop
    {
        public  bool leaveing=false;
        private string pick;
        public string Pick
        {
            get
            {
                return pick;
            }
            set
            {
                pick = value;
            }
        }

        public void if_error()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\nBuy\r\nsell\r\nLeave");
        }
        public void display_market_1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You look a around and see a coke vender");
            Console.WriteLine("Let see what it is selling");
        }

        public void display_market_2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You look a around and see a coke vender");
            Console.WriteLine("Let see what it is selling");
        }

        public void market_floor()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            leaveing=false;
            switch (pick)
            {
                case "buy":
                    Console.WriteLine("buying");
                    //buy menu dispaly
                    break;
                case "sell":
                    Console.WriteLine("selling");
                    //selling menu psiplay
                    break;
                case "leave":
                    leaveing=true;
                    Console.WriteLine("leaving");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentOutOfRangeException("\r\nError: Take me to the candy shop",pick, "That is not a value Hint Buy, Sell, Leave!");
            }
        }

        
    }
}
