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

                    user.text_intro();
                    user.User_Name = Console.ReadLine().ToLower();
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

            Console.ReadKey();
        }
    }
}
