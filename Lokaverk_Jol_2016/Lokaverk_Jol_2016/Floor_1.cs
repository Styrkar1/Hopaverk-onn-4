using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Floor_1
    {
        // 1=true 0=false 

        Random rnd = new Random();
        public bool battle = false;

        private int location=1;
        public int Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        private string pick;
        public string Pick
        {
            get
            {
                return pick;
            }
            set
            {
                pick = value;
            }
        }

        public void room()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            switch (location)
            {
                case 1:
                if (enemy==0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");
                
                }
                else
                {
                    if (see==1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 2:
                if (enemy==0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");
                
                }
                else
                {
                    if (see==1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 3:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 4:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 5:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 6:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 7:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 8:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 9:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                case 10:
                if (enemy == 0)//battle
                {
                    battle = true;
                    see = 0;

                    Console.WriteLine("Enemy is here");

                }
                else
                {
                    if (see == 1)
                    {
                        see = 0;
                        Console.WriteLine("no one here");
                    }
                    else
                    {
                        Console.WriteLine("i have been her before");

                    }
                }
                break;
                default:
                break;
            }
        }

        public void Moving()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (pick)
            {
                case "north":
                    if (location <= 6)
	                {
		                location=location+3; 
                        Console.WriteLine("Moving North");
	                }
                    else
	                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A rat hole, it is to small");
	                }
                    break;

                case "south":
                    if (location >=3)
	                {
		                location=location-3; 
                        Console.WriteLine("Moving South");
	                }
                    else
	                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is a wall!");
	                }
                    break;

                case "west":
                    if (location != 1 && location != 4 && location != 7)
	                {
		                location=location-1;
	                }
                    else
	                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A very fine looking wall");
	                }
                    break;

                case "east":
                    if (location != 3 && location != 6)
	                {
		                location=location+1;
	                }
                    else
	                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A picture of a whale, oh no that is your mom");
	                }
                    break;
                default:
                     Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentOutOfRangeException("\r\nError 101", pick, "That is not a value Hint  North, South, West, East!");
       }//switch    
    }//void

            public void display()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\r\nRoom: " + location);
                if (location>=3)
                {
                    Console.WriteLine("Go South");
                }
                if (location <= 6)
                {
                    Console.WriteLine("Go North");
                }
                if (location!=1&&location!=4&&location!=7)
                {
                    Console.WriteLine("Go West");
                }
                if (location!=3&&location!=6)
                {
                    Console.WriteLine("Go East");
                }
            }
  }//class
 
}//end
