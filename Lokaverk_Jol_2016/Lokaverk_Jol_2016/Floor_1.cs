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
            bool[] see = new bool[10];
            int enemy = rnd.Next(1, 3);
            switch (location)
            {
                case 1:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 2:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 3:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 4:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 5:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 6:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 7:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 8:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 9:
                    see[0] = true;
                    if (see[0])
                    {
                        Console.WriteLine("i have been her before");  
                    }
                    else  
                    {
                        if (enemy==1)
                        {
                            battle = true;
                            Console.WriteLine("Enemy is here");
                        }
                        else
	                    { 
                            Console.WriteLine("no one here");    
	                    }
                     }
                    see[0] = true;
                break;
                case 10:
                //boss
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
                        Console.WriteLine("\r\nMoving South");
	                }
                    else
	                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\nThat is a wall!");
	                }
                    break;

                case "west":
                    if (location != 1 && location != 4 && location != 7)
	                {
		                location=location-1;
                        Console.WriteLine("\r\nMoving West");
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
                        Console.WriteLine("\r\nMoving East");
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
    }

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
