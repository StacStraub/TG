using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Program
    {
        public static void parseRooms(string filename, ref List<Room> RoomList)
        {
            Room ReadRoom = new Room();
            string row;
            int val = 0;
            if (File.Exists(filename) == true)
            {
                Console.WriteLine("File Exists");
                StreamReader read = new StreamReader(filename);


                while (read.ReadLine() != null)
                {
                    while (val < 8)
                    {
                        row = read.ReadLine();

                        switch (val)
                        {
                            case 0:
                                {
                                    ReadRoom.id = Convert.ToInt32(row);
                                    val++;
                                    break;
                                }
                            case 1:
                                {
                                    ReadRoom.RoomName = row;
                                    val++;
                                    break;
                                }
                            case 2:
                                {
                                    ReadRoom.Description = row;
                                    val++;
                                    break;
                                }
                            case 3:
                                {
                                    ReadRoom.otherItems = row;
                                    val++;
                                    break;
                                }
                            case 4:
                                {
                                    ReadRoom.northid = Convert.ToInt32(row);
                                    val++;
                                    break;
                                }
                            case 5:
                                {
                                    ReadRoom.eastid = Convert.ToInt32(row);
                                    val++;
                                    break;
                                }
                            case 6:
                                {
                                    ReadRoom.southid = Convert.ToInt32(row);
                                    val++;
                                    break;
                                }
                            case 7:
                                {
                                    ReadRoom.westid = Convert.ToInt32(row);
                                    RoomList.Add(ReadRoom);
                                    Console.WriteLine("Added Room: " + ReadRoom.RoomName);
                                    val++;
                                    break;
                                }
                        };
                    }
                    val = 0;
                }
            }
            else
            {
                Console.WriteLine("File Doesn't exist");
                return;
            }
        }

        static void Main(string[] args)
        {
            Player p = new Player();
            Monster minion = new Monster(1, false, "LittleDude");
            Monster boss = new Monster(2, true, "BigDude");
            int damagetaken;
            bool monsterdead = false;
            bool playerdead = false;
            List<Room> RoomList = new List<Room>();
            string filename = "D:/Rooms.txt";

            parseRooms(filename, ref RoomList);

            Console.WriteLine("The number of rooms created is: " + RoomList.Count);
            for (int i = 0; i < RoomList.Count; i++)
            {
                Console.WriteLine("RoomName is: " + RoomList[i].RoomName);
            }
                //while (monsterdead == false && playerdead == false)
                //{
                //    damagetaken = p.attack();
                //    Console.WriteLine("Player attacks for: " + damagetaken);
                //    monsterdead = boss.DamageFromPlayer(damagetaken);
                //    if (monsterdead == true)
                //    {
                //        Console.WriteLine("Player won");
                //        break;
                //    }
                //    damagetaken = boss.generateDamage();
                //    Console.WriteLine("Boss attack for: " + damagetaken);
                //    playerdead = p.takeDamage(damagetaken);
                //    if (playerdead == true)
                //    {
                //        Console.WriteLine("Player Lost");
                //        break;
                //    }
                //    System.Threading.Thread.Sleep(3000);
                //}


            Console.WriteLine("Curr HP IS: " + p.currHP);

        }
    }
}
