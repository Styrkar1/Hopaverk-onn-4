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
            //characther info and pick
            Character user = new Character();// start pick
            Floor_1 one = new Floor_1();//First floor of the tower
            Floor_2 two = new Floor_2();
            Floor_3 three = new Floor_3();
            Floor_4 four = new Floor_4();
            Floor_5 five = new Floor_5();
            Enemy enemy = new Enemy();//what enemy you will figth
            Battle battle = new Battle();//the figth beetween you and the enemy
            World world = new World();
            Shop buy = new Shop();
            Intro_and_shit text = new Intro_and_shit();

            text.intro();
            user.text_intro();
            user.User_Name = Console.ReadLine();
            user.text_runes();
            do
            {
                user.text_runes_2();// spyr
                try// error check
                {

                    user.Touch = Console.ReadLine().ToLower();
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
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            one.display_2();
            do//boss
            {
                one.display();
                try// error check
                {

                    one.Pick = Console.ReadLine().ToLower();
                    one.Moving();
                    one.room();
                    battle.figth();
                    if (one.battle)// if the are enemy there
                    {
                        //enemy.Enemy_Pick();
                        /*
                        do
                        {
                            battle.figth();
                        } while (battle.win == 1);
                        // text win*/
                    }//if  
                }
                catch (ArgumentOutOfRangeException ex_floor)
                {
                    Console.WriteLine(ex_floor.Message);
                }

            } while (!one.Boss_1);

            //shop
            Console.Clear();
            buy.display_market_1();
            do
            {
                buy.if_error();
                try//Error check
                {
                    buy.Pick = Console.ReadLine().ToLower();
                    buy.market_floor();
                    Error = false;
                }
                catch (ArgumentOutOfRangeException ex_shop)
                {
                    Console.WriteLine(ex_shop.Message);
                    Error = true;
                }

            } while (!buy.leaveing);


            //floor 2
            Console.Clear();
            two.display_2();
            do//boss
            {
                two.display();
                try// error check
                {
                    two.Pick = Console.ReadLine().ToLower();
                    two.Moving();
                    two.room();
                    battle.figth();
                    if (two.battle)// if the are enemy there
                    {
                        //enemy.Enemy_Pick();
                        /*
                        do
                        {
                            battle.figth();
                        } while (battle.win == 1);
                        // text win*/
                    }//if  
                }
                catch (ArgumentOutOfRangeException ex_floor)
                {
                    Console.WriteLine(ex_floor.Message);
                }

            } while (!two.Boss_2);

            //shop
            Console.Clear();
            buy.display_market_2();
            do
            {
                buy.if_error();
                try//Error check
                {
                    buy.Pick = Console.ReadLine().ToLower();
                    buy.market_floor();
                    Error = false;
                }
                catch (ArgumentOutOfRangeException ex_shop)
                {
                    Console.WriteLine(ex_shop.Message);
                    Error = true;
                }

            } while (!buy.leaveing);
            
            //floor 3
            Console.Clear();
            three.display_2();
            do//boss
            {
                three.display();
                try// error check
                {
                    three.Pick = Console.ReadLine().ToLower();
                    three.Moving();
                    three.room();
                    battle.figth();
                    if (three.battle)// if the are enemy there
                    {
                        //enemy.Enemy_Pick();
                        /*
                        do
                        {
                            battle.figth();
                        } while (battle.win == 1);
                        // text win*/
                    }//if  
                }
                catch (ArgumentOutOfRangeException ex_floor)
                {
                    Console.WriteLine(ex_floor.Message);
                }

            } while (!three.Boss_3);


            //shop
            Console.Clear();
            buy.display_market_2();
            do
            {
                buy.if_error();
                try//Error check
                {
                    buy.Pick = Console.ReadLine().ToLower();
                    buy.market_floor();
                    Error = false;
                }
                catch (ArgumentOutOfRangeException ex_shop)
                {
                    Console.WriteLine(ex_shop.Message);
                    Error = true;
                }

            } while (!buy.leaveing);

            //floor 4
            Console.Clear();
            four.display_2();
            do//boss
            {
                four.display();
                try// error check
                {
                    four.Pick = Console.ReadLine().ToLower();
                    four.Moving();
                    four.room();
                    battle.figth();
                    if (four.battle)// if the are enemy there
                    {
                        //enemy.Enemy_Pick();
                        /*
                        do
                        {
                            battle.figth();
                        } while (battle.win == 1);
                        // text win*/
                    }//if  
                }
                catch (ArgumentOutOfRangeException ex_floor)
                {
                    Console.WriteLine(ex_floor.Message);
                }

            } while (!four.Boss_4);

            //shop
            Console.Clear();
            buy.display_market_2();
            do
            {
                buy.if_error();
                try//Error check
                {
                    buy.Pick = Console.ReadLine().ToLower();
                    buy.market_floor();
                    Error = false;
                }
                catch (ArgumentOutOfRangeException ex_shop)
                {
                    Console.WriteLine(ex_shop.Message);
                    Error = true;
                }

            } while (!buy.leaveing);


            //floor 5
            Console.Clear();
            five.display_2();
            do//boss
            {
                five.display();
                try// error check
                {
                    five.Pick = Console.ReadLine().ToLower();
                    five.Moving();
                    five.room();
                    battle.figth();
                    if (three.battle)// if the are enemy there
                    {
                        //enemy.Enemy_Pick();
                        /*
                        do
                        {
                            battle.figth();
                        } while (battle.win == 1);
                        // text win*/
                    }//if  
                }
                catch (ArgumentOutOfRangeException ex_floor)
                {
                    Console.WriteLine(ex_floor.Message);
                }

            } while (!five.Boss_5);

            Console.ReadKey();
        }
    }
}
