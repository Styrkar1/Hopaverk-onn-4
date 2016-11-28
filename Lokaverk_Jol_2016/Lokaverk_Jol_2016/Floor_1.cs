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

        private int location =1;
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
        
        public string room_0()
        {
            return"inn komu room";
        }
        public string room_1()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_2()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_3()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_4()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_5()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_6()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_7()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_8()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_9()
        {
            int see = 1;
            int enemy = rnd.Next(1, 3);
            if (enemy==0)//battle
            {
                battle = true;
                return "enemy is near";
                see = 0;
            }
            else
            {
                if (see==1)
                {
                    return "no one here";
                    see = 0;
                }
                else
                {
                    return "i have been her before";

                }
            }
        }
        public string room_10()
        {
            //Boss = true;
            return "the boss is her";
        }
        

        public void Moveing()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (location)
            {
                case 0:
                    Console.WriteLine("Now entering the tower");
                    break;
                case 1:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 2:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 3:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 4:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 5:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 6:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 7:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 8:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                case 9:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = new value
                    break;
                case 10:
                    Console.WriteLine("\r\nRoom" + Location);
                    Console.WriteLine("\r\nGo North\r\nGo East\r\nMenu");
                    //if val = menu go to menu // if val = neew value
                    break;
                default:
                    break;
            }
        }
        public void upproom()
        {
            if (location==0)
	        {
		        Console.WriteLine(room_0());
	        }
            if (location==1)
            {
                Console.WriteLine(room_1());
            }
                /*
            else if (location == 2)
            {
                Console.WriteLine(room_2());
            }
            else if (location == 3)
            {
                Console.WriteLine(room_3());
            }
            else if (location == 4)
            {
                Console.WriteLine(room_4());
            }
            else if (location == 5)
            {
                Console.WriteLine(room_5());
            }
            else if (location == 6)
            {
                Console.WriteLine(room_6());
            }
            else if (location == 7)
            {
                Console.WriteLine(room_7());
            }
            else if (location == 8)
            {
                Console.WriteLine(room_8());
            }
            else if (location == 9)
            {
                Console.WriteLine(room_9());
            }
            else if (location == 10)
            {
                Console.WriteLine(room_10());
            }*/
        }
    }
}
