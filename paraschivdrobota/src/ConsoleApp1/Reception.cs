using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Reception
    {
        private const int family_room = 200;
        private const int double_simple_romm =120;
        private const int double_mountain_view_room = 150;
        private const int attic_room = 100;

        static FamilyRoom c1 = new FamilyRoom();
        static DoubleSimpleRoom c2 = new DoubleSimpleRoom();
        static DoubleMountainViewRoom c3 = new DoubleMountainViewRoom();
        static DoubleMountainViewRoom c4 = new DoubleMountainViewRoom();
        static AtticRoom c5 = new AtticRoom();
        static AtticRoom c6 = new AtticRoom();

        public void ReceptionCall(int room_number,int days) {

            switch (room_number) {
                case 1:
                    if (c1.Status == false) {
                        c1.Status = true;
                        Console.WriteLine($"Room 1 :\nPrize:{family_room * days}"); }
                    else Console.WriteLine("Room ocupied ");
                    break;
                case 2:
                    if (c2.Status == false) {
                        c2.Status = true;
                        Console.WriteLine($"Room 2 :\nPrize:{double_simple_romm * days}");
                    }
                    else Console.WriteLine("Room ocupied ");
                    break;
                case 3:
                    if (c3.Status == false)
                    {
                        c3.Status = true;
                        Console.WriteLine($"Room 3 :\nPrize:{double_mountain_view_room * days}");
                    }
                    else Console.WriteLine("Room ocupied ");
                    break;
                case 4:
                    if (c4.Status == false) {
                        c4.Status = true;
                        Console.WriteLine($"Room 4 :\nPrize:{double_mountain_view_room * days}");
                    }
                    else Console.WriteLine("Room ocupied ");
                    break;
                case 5:
                    if (c5.Status == false) {
                        c5.Status = true;
                        Console.WriteLine($"Room 5 :\nPrize:{attic_room * days}");
                    }
                    else Console.WriteLine("Room ocupied ");
                    break;
                case 6:
                    if (c6.Status == false) {
                        c6.Status = true;
                        Console.WriteLine($"Room 6 :\nPrize:{attic_room * days}");
                    }
                    else Console.WriteLine( "Room ocupied ");
                    break;
                default:
                    Console.WriteLine("No rooms left");
                    break;

            }
            
        }
        public void ClearRoom(int x) {
            switch (x) {
                case 1:
                    c1.Status = false;
                    Console.WriteLine($"Room {x} is now available");
                    break;
                case 2:
                    c2.Status = false;
                    Console.WriteLine($"Room {x} is now available");
                    break;
                case 3:
                    c3.Status = false;
                    Console.WriteLine($"Room {x} is now available");
                    break;
                case 4:
                    c4.Status = false;
                    Console.WriteLine($"Room {x} is now available");
                    break;
                case 5:
                    c5.Status = false;
                    Console.WriteLine($"Room {x} is now available");
                    break;
                case 6:
                    c6.Status = false;
                    Console.WriteLine($"Room {x} is now available");
                    break;

            }
        }

    }
}
