using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Floor_3
    {
        Random rnd = new Random();
        Menu menu = new Menu();
        bool[] see = new bool[9];
        int[] enemy = new int[9];
        public int floor = 3;
        int back = 0;
        public bool Boss_3 = false;
        public bool battle = false;

        private int location = 1;
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
            Console.ForegroundColor = ConsoleColor.Green;
            battle = false;
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i] = rnd.Next() % 2;
            }
            switch (location)
            {
                case 1:
                    Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    see[0] = true;
                    break;
                case 2:
                    if (see[1] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[1] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[1] = 0;
                    see[1] = true;
                    break;
                case 3:
                    if (see[2] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[2] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[2] = 0;
                    see[2] = true;
                    break;
                case 4:
                    if (see[3] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[3] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[3] = 0;
                    see[3] = true;
                    break;
                case 5:
                    if (see[4] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[4] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[4] = 0;
                    see[4] = true;
                    break;
                case 6:
                    if (see[5] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[5] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[5] = 0;
                    see[5] = true;
                    break;
                case 7:
                    if (see[6] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[6] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[6] = 0;
                    see[6] = true;
                    break;
                case 8:
                    if (see[7] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[7] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[7] = 0;
                    see[7] = true;
                    break;
                case 9:
                    if (see[8] == true)
                    {
                        Console.WriteLine("Floor " + floor + " Room " + location + "\r\ni have been her before");
                    }
                    else
                    {
                        if (enemy[8] == 1)
                        {
                            battle = true;
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\nEnemy is here");
                        }
                        else
                        {
                            Console.WriteLine("Floor " + floor + " Room " + location + "\r\n no one here");
                        }
                    }
                    enemy[8] = 0;
                    see[8] = true;
                    break;
                case 10:
                    Boss_3 = true;
                    break;
                default:
                    break;
            }
            Console.Write("You to a door to the");
            if (location <= 6)//North
            {
                if (pick == "south")
                {
                    back = 1;
                }
                else
                {
                    Console.Write(" north,");
                }
            }
            if (location > 3)//South
            {
                if (pick == "north")
                {
                    back = 2;
                }
                else
                {
                    Console.Write(" South,");
                }

            }
            if (location != 1 && location != 4 && location != 7)//West
            {
                if (pick == "east")
                {
                    back = 3;
                }
                else
                {
                    Console.Write(" West,");
                }

            }
            if (location != 3 && location != 6)//East
            {
                if (pick == "west")
                {
                    back = 4;
                }
                else
                {
                    Console.Write(" East,");
                }
            }
            if (back == 1)
            {
                Console.Write(" or back South");
            }
            if (back == 2)
            {
                Console.Write(" or back North");
            }
            if (back == 3)
            {
                Console.Write(" or back West");
            }
            if (back == 4)
            {
                Console.Write(" or back East");
            }
            Console.WriteLine("\r\n");
        }

        public void Moving()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (pick)
            {
                case "north":
                    if (location <= 6)
                    {
                        location = location + 3;
                        Console.WriteLine("Moving North");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A rat hole, it is to small");
                    }
                    break;

                case "south":
                    if (location > 3)
                    {
                        location = location - 3;
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
                        location = location - 1;
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
                        location = location + 1;
                        Console.WriteLine("\r\nMoving East");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A picture of a whale, oh no that is your mom");
                    }
                    break;
                case "menu":
                    {
                        Console.WriteLine("menu");
                        menu.menu_display();
                        menu.Pick = Console.ReadLine().ToLower();
                        menu.menu();
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
            if (location > 3)
            {
                Console.WriteLine("Go South");
            }
            if (location <= 6)
            {
                Console.WriteLine("Go North");
            }
            if (location != 1 && location != 4 && location != 7)
            {
                Console.WriteLine("Go West");
            }
            if (location != 3 && location != 6)
            {
                Console.WriteLine("Go East");
            }
        }

        public void display_2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nYou look around the drak room and see a door to the north, south,");
            Console.WriteLine("Floor 1 Room 1 : no one here");

        }
    }//class
}//end