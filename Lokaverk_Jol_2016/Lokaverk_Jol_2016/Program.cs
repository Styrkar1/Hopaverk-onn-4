using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Error = false;

                    Text text = new Text();
                    Stats stats = new Stats();
                   
                    text.text_intro();
                    text.User_Name = Console.ReadLine();
                    text.text_runes();
           /* do
            {
                try
                {*/
                    stats.Touch= Convert.ToInt32(Console.ReadLine());
                    stats.stats_start();
            /*
                }
                catch (ArgumentOutOfRangeException ex_floor_1)
                {

                    Console.WriteLine(ex_floor_1.Message);
                    Error = true;
                }
            } while (Error);*/
                   
                    
            //Testing healing potion capabilities
            Console.WriteLine("Would you like to drink a potion?\r\n1.Yes\r\n2.No");
            int _Choice = Convert.ToInt32(Console.ReadLine());
            switch(_Choice)
            {
                case 1:
                    HealingPotion potion = new HealingPotion(World.ITEM_ID_HEALING_POTION, "A healing potion", "Healing Potions", 50, 30);
                    Console.WriteLine("But first we have to hurt you a little bit\r\n*OOF*");
                    stats.health = 50;
                    Console.WriteLine("You have " + stats.health + " Health");
                    Console.WriteLine("and then to give you a potion " + stats.potions++ + "\r\nYour belt feels heavyer as a potion materializes on it\r\n" + stats.potions);
                    Console.WriteLine("You quickly chug the potion to Heal Yourself");

                    stats.health = (stats.health + potion.AmountToHeal);

                    if (stats.health > 100)
                    {
                        stats.health = 100;
                    }
                    stats.potions--;
                    Console.WriteLine("Health: " + stats.health + "\r\nMax Health: " + stats.health);

                    break;

                default:
                    Console.WriteLine("That's the spirit!");
                    goto case 1;
            }
            Console.ReadLine();
        }
    }
}
