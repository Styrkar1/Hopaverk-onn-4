using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Text
    {


        //Name text 
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

        //Runes text
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
        //Name Text
        
        public void text_intro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("As you stand outside the tower you feel and ominous presence");
            Console.WriteLine("Steeling yourself you decide to enter the tower");
            Console.WriteLine("As you push open the massive wooden doors you find yourelf in a large room,\r\nas you approach the exit of the room a sudden electric pain shocks you");
            Console.WriteLine("You feel as if your head has been beaten against a rock, as you are grasping your poor head a voice calls out to you");
            Console.WriteLine("'Greetings, traveller i have probed your mind of everything you know' The massive door behind you slams shut");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n*Write your name*");
        }
        //Runes Text
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
        public void text_runes_2()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n1.Red rune\r\n2.Blue rune\r\n3.Green rune\r\n4.Ignore the runes");
        }
    }
}
