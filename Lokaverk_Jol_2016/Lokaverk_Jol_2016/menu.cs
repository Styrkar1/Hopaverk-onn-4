using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Menu
    {
        Character chara = new Character();

        public bool leavring_menu = false;
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

        public void menu_display()
        {
            Console.WriteLine("gambit");
            Console.WriteLine("stats");
            Console.WriteLine("inventory");
            Console.WriteLine("Exit");
        }
        public void menu()
        {
            switch (pick)
            {
                case "inventory":
                    //inv
                    Console.WriteLine("Invt");
                    break;
                case "stats":
                    //chara.stats();
                    Console.WriteLine("Stats");
                    break;
                case "gambit":
                    Console.WriteLine("Gamit");
                    //gambit
                    break;
                case "exit":
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }
        //invetory 
        //item
        //stat
        //info
    }
}
