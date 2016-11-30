using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lokaverk_Jol_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            // need move and stat class
            bool Error = false;
            bool Boss = false;
            //characther info and pick
                    Character user = new Character();// start pick
                    Floor_1 one = new Floor_1();//First floor of the tower
                    Enemy enemy = new Enemy();//what enemy you will figth
                    Battle battle = new Battle();//the figth beetween you and the enemy
                    World world = new World();

                    world.PopulateItems();

                    user.text_intro();
                    user.User_Name = Console.ReadLine();
                    user.text_runes();
            do
            {
                user.text_runes_2();// spyr
                try// error check
                {
                    
                    user.Touch = Console.ReadLine();
                    user.stats_start();//ef rett
                    Error = false;
            
                }
                catch (ArgumentOutOfRangeException ex_start)
                {
                    Console.WriteLine(ex_start.Message);//Character stats start
                    Error = true;
                }
            } while (Error);

            //floor 1
            do//boss
            {
                one.display();
                try// error check
                {
                    one.Pick =  Console.ReadLine().ToLower();
                    one.room();
                    if (one.battle)// if the are enemy there
                    {
                        enemy.rat();

                        do
                        {
                            battle.figth();
                        } while (battle.win == 1);
                        // text win
                    }//if  
                    else
                    {
                        one.Moving();
                    }
                }
                catch (ArgumentOutOfRangeException ex_floor_1)
                {
                    Console.WriteLine(ex_floor_1.Message);
                }
               
             } while (!Boss);
            //Testing healing potion capabilities
            /*Console.WriteLine("Would you like to drink a potion?\r\n1.Yes\r\n2.No");
            int _Choice = Convert.ToInt32(Console.ReadLine());
            switch(_Choice)
            {
                    
            
                case 1:
                    orld.PopulateItems();
                    HealingPotion potion = new HealingPotion(World.ITEM_ID_HEALING_POTION, "A healing potion", "Healing Potions", 50, 30);
                    Console.WriteLine("But first we have to hurt you a little bit\r\n*OOF*");
                    user.health = 50;
                    Console.WriteLine("You have " + user.health + " Health");
                    Console.WriteLine("and then to give you a potion " + user.potions++ + "\r\nYour belt feels heavyer as a potion materializes on it\r\n" + user.potions);
                    Console.WriteLine("You quickly chug the potion to Heal Yourself");

                    user.health = (user.health + potion.AmountToHeal);

                    if (user.health > user.max_health())
                    {
                        user.health = 100;
                    }
                    user.potions--;
                    Console.WriteLine("Health: " + user.health + "\r\nMax Health: " + user.health);

                    break;

                default:
                    Console.WriteLine("That's the spirit!");
                    goto case 1;
            }
            Console.ReadLine();*/
            Console.ReadKey();
        }
    }
}
