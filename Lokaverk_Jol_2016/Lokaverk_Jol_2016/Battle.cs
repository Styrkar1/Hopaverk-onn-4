using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Battle
    {
        public int win = 1;
        public void figth()// battle take enemy from enenmy need a stat class
        {
            Console.WriteLine("\r\nIt seems you've encountered an enemy");
            Console.WriteLine("1.Attack\r\n2.Magic\r\n3.Menu");
            int _choice = Convert.ToInt32(Console.ReadLine());


            switch(_choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            win = 0;//if win
            
        }


    }
}
