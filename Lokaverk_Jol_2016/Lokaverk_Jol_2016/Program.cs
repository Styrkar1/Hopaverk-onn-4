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

                    

            Console.WriteLine("the end");
            Console.ReadKey();
        }
    }
}
