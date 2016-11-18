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
            int health = 100;
            int max_health = 100;
            int defence = 10;
            int speed = 10;
            int magic = 10;
            int mana = 50;
            int crit_chance = 5;
            int touch = 0;
            int touched;
            string Name = "Default";
            string Class = "Deprived";
            Console.WriteLine("As you stand outside the tower you feel and ominous presence");
            Console.WriteLine("Steeling yourself you decide to enter the tower");
            Console.WriteLine("As you push open the massive wooden doors you find yourelf in a large room,\r\nas you approach the exit of the room a sudden electric pain shocks you");
            Console.WriteLine("You feel as if your head has been beaten against a rock, as you are grasping your poor head a voice calls out to you");
            Console.WriteLine("'Greetings, traveller i have probed your mind of everything you know' The massive door behind you slams shut");
            Console.WriteLine("*Write your name*");
            Name = Console.ReadLine();
            Console.WriteLine("'Your name is "+ Name +", You come from the west seeking treasure, but i can promise you nothing but suffering'");
            Console.WriteLine("The voice dissipates untill it can't be heard anymore, the doors leading further into the tower open");
            Console.WriteLine("As you enter the next room you find three runes, one red one blue and one green with runes inscribed upon them, as if by magic you can understad the meaning of the runes");
            Console.WriteLine("The runes humm quitely, when suddenly the voice returns 'These runes will grant you knowledge in a ceratin field, you can only choose one, remember that nothing is free'");
            Console.WriteLine("The red rune will grant you physical power and strength, the blue rune in magic and arcane knowledge and the green rune in quickness and criticals");
            Console.WriteLine("Wich rune do you touch?");
            Console.WriteLine("\r\n1:Red rune\r\n2.Blue rune\r\n3.Green rune\r\n4.Ignore the runes");
            touch = Convert.ToInt32(Console.ReadLine());
            switch(touch)
            {
                case 1:
                    Console.WriteLine("As you touch the stone red you feel your muscles grow and any pain you had begins to numb");
                    health = 160;
                    max_health = 160;
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
                    goto case 4;
            }
            Console.WriteLine("As you take a step back from the stones they crumble into dust, as if they had never been there");
            Console.WriteLine( "\r\nHealth: " + health +"Max Health: " + max_health + "\r\nDefence: " + defence + "\r\nSpeed: " + speed + "\r\nMagic: " + magic + "\r\nMana: "+ mana + "\r\nCritical Chance: " + crit_chance + "\r\nStone Touched: " + touched + "\r\nClass: " + Class);
            Console.ReadLine();
        }
    }
}
