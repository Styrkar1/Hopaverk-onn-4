using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    class Floor_1
    {
        int User_Locastion = 2;
        int User_Move = 0;

        public void floor()
        {
            do
            {
                if (User_Locastion == 1)
                {
                    Console.WriteLine("1.Go North\r\n2.Go East");
                    Console.WriteLine("Room: " + User_Locastion);
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go north");
                        User_Locastion = 4;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go east");
                        User_Locastion = 2;
                    }    
                }
                else if (User_Locastion == 2)
                {
                    Console.WriteLine("1.Go West\r\n2.Go North\r\n3.Go East");
                    Console.WriteLine("Room: " + User_Locastion);
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go west");
                        User_Locastion = 1;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go north");
                        User_Locastion = 5;
                    }
                    else if (User_Move == 3)
                    {
                        Console.WriteLine("you go east");
                        User_Locastion = 3;
                    }
                }
                else if (User_Locastion == 3)
                {
                    Console.WriteLine("1.Go West\r\n2.Go North");
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Room: " + User_Locastion);
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go west");
                        User_Locastion = 2;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go north");
                        User_Locastion = 6;
                    }
                }
                else if (User_Locastion == 4)
                {
                    Console.WriteLine("1.Go South\r\n2.Go North\r\n3.Go East");
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Room: " + User_Locastion);
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go south");
                        User_Locastion = 1;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go north");
                        User_Locastion = 7;
                    }
                    else if (User_Move == 3)
                    {
                        Console.WriteLine("you go east");
                        User_Locastion = 5;
                    }
                }
                else if (User_Locastion == 5)
                {
                    Console.WriteLine("1.GoSouth\r\n2.Go West\r\n3.Go North\r\n4.Go East");
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Room: " + User_Locastion);
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go south");
                        User_Locastion = 2;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go west");
                        User_Locastion = 4;
                    }
                    else if (User_Move == 3)
                    {
                        Console.WriteLine("you go north");
                        User_Locastion = 8;
                    }
                    else if (User_Move==4)
                    {
                        Console.WriteLine("you Go east");
                        User_Locastion = 6;
                    }
                }
                else if (User_Locastion == 6)
                {
                    Console.WriteLine("1.Go south\r\n2.Go west\r\n3.Go north");
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Room: " + User_Locastion);
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go south");
                        User_Locastion = 3;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go west");
                        User_Locastion = 5;
                    }
                    else if (User_Move == 3)
                    {
                        Console.WriteLine("you go north");
                        User_Locastion = 9;
                    }
                }
                else if (User_Locastion == 7)
                {
                    Console.WriteLine("1.Go South\r\n2.Go East");
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Room: " + User_Locastion);
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go south");
                        User_Locastion = 4;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go east");
                        User_Locastion = 8;
                    }
                }
                else if (User_Locastion == 8)
                {
                    Console.WriteLine("1.Go South\r\n2.Go West\r\n3.Go North\r\n4.Go East");
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Room: " + User_Locastion);
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go south");
                        User_Locastion = 7;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go west");
                        User_Locastion = 5;
                    }
                    else if (User_Move == 3)
                    {
                        Console.WriteLine("you go north");
                        User_Locastion = 10;
                    }
                    else if (User_Move == 4)
                    {
                        Console.WriteLine("you go east");
                        User_Locastion = 9;
                    }
                }
                else if (User_Locastion == 9)
                {
                    Console.WriteLine("1.Go South\r\n2.Go west");
                    User_Move = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Room: " + User_Locastion);
                    if (User_Move == 1)
                    {
                        Console.WriteLine("you go south");
                        User_Locastion = 6;
                    }
                    else if (User_Move == 2)
                    {
                        Console.WriteLine("you go west");
                        User_Locastion = 8;
                    }
                }
                else if (User_Locastion == 10)
                {
                }
            } while (User_Locastion != 11);

        }

    }
}
