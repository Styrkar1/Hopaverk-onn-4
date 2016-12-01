﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lokaverk_Jol_2016
{
    class Character
    {
        //starts
        public int level = 1;
        public int exp = 0;
        public int health = 100;
        public int damage = 1;
        public int defence = 10;
        public int speed = 10;
        public int magic = 10;
        public int mana = 50;
        public int crit_chance = 5;
        public string touched;
        public int potions = 0;
        public string Class;
        public List<InventoryItem> Inventory { get; set; }

        public int Max_Healt()
        {
            return health + (10 * (level - 1));
        }
        public int Max_Mana()
        {
            return mana + (10 * (level - 1));
        }

        //Get and Set
        //Name
        private string user_name;
        public string User_Name
        {
            get
            {
                return user_name;
            }
            set
            {
                user_name = value;
            }
        }

        //Runes 
        private string user_runes;
        public string User_Runes
        {
            get
            {
                return user_runes;
            }
            set
            {
                user_runes = value;
            }
        }

        //Runes pick
        private string user_runes_2;
        public string User_Runes_2
        {
            get
            {
                return user_runes_2;
            }
            set
            {
                user_runes_2 = value;
            }
        }

        //Runes value
        private string touch;
        public string Touch
        {
            get
            {
                return touch;
            }
            set
            {
                touch = value;
            }
        }

        //user class form runes value
        private string user_class;
        public string User_Class
        {
            get
            {
                return user_class;
            }
            set
            {
                user_class = value;
            }
        }

        //the stats form runes pick + text to show stats
        public string stat_pick()
        {
            return Touch;
        }
        public void stats_start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (touch)
            {
                case "red rune":
                    Console.WriteLine("\r\nAs you touch the stone red you feel your muscles grow and any pain you had begins to numb");
                    health = 160;
                    defence = 40;
                    touched = "Red";
                    Class = "Warrior";
                    break;

                case "blue rune":
                    Console.WriteLine("\r\nAs you touch the blue stone you feel your mind burst with new knowledge and you can feel arcane power course through your body");
                    magic = 100;
                    mana = 200;
                    speed = 30;
                    crit_chance = 10;
                    touched = "Blue";
                    Class = "Mage";
                    break;

                case "green rune":
                    Console.WriteLine("\r\nAs you touch the green stone you feel as if you could run for miles and that you know where to aim to kill");
                    speed = 40;
                    magic = 20;
                    crit_chance = 30;
                    touched = "Green";
                    Class = "Rouge";
                    break;

                case "ignore":
                    Console.WriteLine("\r\nYou refuse to touch any of the stones, not risking whatever price you might have to pay");
                    touched = "ignore";
                    Class = "Resolute";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentOutOfRangeException("\r\nerror 001", Touch, "That is not a value !!!Hint  red rune, blue rune, green rune, ignore!!!");
            }
            Console.WriteLine("\r\nAs you take a step back from the stones they crumble into dust, as if they had never been there");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\nHealth: " + health + "\r\nMax Health: " + Max_Healt() + "\r\nDefence: " + defence + "\r\nSpeed: " + speed + "\r\nMagic: " + magic + "\r\nMana: " + mana + "\r\nMax Mana: " + Max_Mana() + "\r\nCritical Chance: " + crit_chance + "\r\nStone Touched: " + touched + "\r\nClass: " + Class + "\r\nLevel: " + level + "\r\nExp: " + exp + "/100");
        }

        //text file

        //Name Pick
        public void text_intro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nAs you stand outside the tower you feel and ominous presence");
            Console.WriteLine("Steeling yourself you decide to enter the tower");
            Console.WriteLine("As you push open the massive wooden doors you find yourelf in a large room,\r\nas you approach the exit of the room a sudden electric pain shocks you");
            Console.WriteLine("You feel as if your head has been beaten against a rock, as you are grasping your poor head a voice calls out to you");
            Console.WriteLine("'Greetings, traveller i have probed your mind of everything you know' The massive door behind you slams shut");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n*Write your name*");
        }
        //Runes 
        public void text_runes()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\n'Your name is " + User_Name + ", You come from the west seeking treasure, but i can promise you nothing but suffering'");
            Console.WriteLine("The voice dissipates untill it can't be heard anymore, the doors leading further into the tower open");
            Console.WriteLine("As you enter the next room you find three runes, one red one blue and one green with runes inscribed upon them, as if by magic you can understad the meaning of the runes");
            Console.WriteLine("The runes humm quitely, when suddenly the voice returns 'These runes will grant you knowledge in a ceratin field, you can only choose one, remember that nothing is free'");
            Console.WriteLine("The red rune will grant you physical power and strength, the blue rune in magic and arcane knowledge and the green rune in quickness and criticals");
            Console.WriteLine("Wich rune do you touch?");
        }
        //Runes pick
        public void text_runes_2()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\nRed rune\r\nBlue rune\r\nGreen rune\r\nIgnore the runes");
        }

        public void stats()
        {
            Console.WriteLine("\r\nLevel: " + level + "\r\nHealth: "+health+"/"+Max_Healt()+"\r\nDamage: "+damage);
            Console.WriteLine("nDefence: "+defence+"\r\nSpeed: "+speed+"\r\nMagic: "+magic+"\r\nMana: "+mana+"/"+Max_Mana());
            Console.WriteLine("nCrit chance: "+crit_chance+"\r\nWeapon: "/*+weapon+*/);
            Console.WriteLine("Press any key to continue\r\n");
            Console.ReadKey();
        }


        

    }
}
