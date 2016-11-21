using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Stats
    {
        int level = 1;
        int exp = 0;
        int health = 100;
        int defence = 10;
        int speed = 10;
        int magic = 10;
        int mana = 50;
        int crit_chance = 5;
        int touched;
        string Class;

        private int touch;
        public int Touch
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

        private int user_class;
        public int User_Class
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

        public int strat_pick()
        {
            return Touch;
        }
        public void stats_start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (touch)
            {
                case 1:
                    Console.WriteLine("As you touch the stone red you feel your muscles grow and any pain you had begins to numb");
                    health = 160;
                    defence = 40;
                    touched = 1;
                    Class = "Warrior";
                    break;

                case 2:
                    Console.WriteLine("As you touch the blue stone you feel your mind burst with new knowledge and you can feel arcane power course through your body");
                    magic = 100;
                    mana = 200;
                    speed = 30;
                    crit_chance = 10;
                    touched = 2;
                    Class = "Mage";
                    break;

                case 3:
                    Console.WriteLine("As you touch the green stone you feel as if you could run for miles and that you know where to aim to kill");
                    speed = 40;
                    magic = 20;
                    crit_chance = 30;
                    touched = 3;
                    Class = "Rouge";
                    break;

                case 4:
                    Console.WriteLine("You refuse to touch any of the stones, not risking whatever price you might have to pay");
                    touched = 4;
                    Class = "Resolute";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentOutOfRangeException("error 001",Touch,"er ekki valkostur");
            }
            int max_health = health + (10 * (level-1));
            int max_mana = mana + (10 * (level-1));
            Console.WriteLine("As you take a step back from the stones they crumble into dust, as if they had never been there");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\nHealth: " + health + "\r\nMax Health: " + max_health + "\r\nDefence: " + defence + "\r\nSpeed: " + speed + "\r\nMagic: " + magic + "\r\nMana: " + mana + "\r\nMax Mana: " + max_mana + "\r\nCritical Chance: " + crit_chance + "\r\nStone Touched: " + touched + "\r\nClass: " + Class + "\r\nLevel: " + level + "\r\nExp: " + exp + "/100");
        }



    }
}
