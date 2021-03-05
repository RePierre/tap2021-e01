using System;

namespace Pensiune
{
    class Reception
    {
        public decimal ReservesPrices(double days, string roomType)
        {
          
               
                decimal Priceday = 0m;
                Room room;
                switch (roomType)
                {
                    case "1":
                        room = new FamilyRoom();
                    Priceday = room.Reservedays((int)days);
                        break;
                    case "2":
                        room = new DoubleRoom();
                    Priceday = room.Reservedays((int)days);
                        break;
                    case "3":
                        room = new DoubleRoomMountain();
                    Priceday = room.Reservedays((int)days);
                        break;
                    case "4":
                        room = new Attic();
                    Priceday = room.Reservedays((int)days);
                        break;
                    default:
                        throw new InvalidOperationException("Non-existent room");
                }
                return Priceday;
            
        }



    }
}
