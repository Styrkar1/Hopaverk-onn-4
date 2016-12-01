using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lokaverk_Jol_2016
{
    class Intro_and_shit
    {
        int counter = 20;
        int counter_2 = 10;
        public void intro()
        {
            bool visible = true;
            for (int i = 0; i < counter; i++)
            {
                do
                {

                    string alert = "welcome to the tower game";
                    Console.ForegroundColor = visible ? ConsoleColor.Red : ConsoleColor.White;
                    visible = !visible;
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (alert.Length / 2)) + "}", alert));
                    Thread.Sleep(100);
                } while (!true);

            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n");
            Console.ForegroundColor = ConsoleColor.Red;
            string alert_2 = "Press Any Key To Start...";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (alert_2.Length / 2)) + "}", alert_2));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
           
