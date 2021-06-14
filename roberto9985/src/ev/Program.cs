using System;
using System.Collections.Generic;

namespace ev
{
    class Program
    {
        static void Main(string[] args)
        {
            room room1 = new room(TypeOfRoom.FamillyRoom);
            room room2 = new room(TypeOfRoom.DoubleRoom);
            room room3 = new room(TypeOfRoom.DoubleRoom);
            room room4 = new room(TypeOfRoom.DoubleRoom);
            room room5 = new room(TypeOfRoom.SpecialDoubleRoom);
            room room6 = new room(TypeOfRoom.SingleRoom);

            List<room> EX = new List<room>();

            EX.Add(room1);
            EX.Add(room2);
            EX.Add(room3);
            EX.Add(room4);
            EX.Add(room5);
            EX.Add(room6);

            GuestHouse guestHouse = new GuestHouse(EX);

            foreach(room x in EX)
            {
                Console.WriteLine(x.CalculatePrice());
            }
            
        }
    }
}
