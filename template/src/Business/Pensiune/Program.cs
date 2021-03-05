using System;

namespace Pensiune
{
    class FamilyRoom : Room
    {
        public FamilyRoom()
        {
            this.Price1day = 200;
        }
    }


    class DoubleRoom : Room
    {
        public DoubleRoom()
        {
            this.Price1day = 120;
        }
    }


    class DoubleRoomMountain : Room
    {
        public DoubleRoomMountain()
        {
            this.Price1day = 150;
        }
    }
    class Attic : Room
    {
        public Attic()
        {
            this.Price1day = 100;
        }
    }

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
    
    class Program
    {
        static void Main(string[] args)
        {
            string room;
            Console.WriteLine("Choose one type of room: \n");
            Console.WriteLine("1.Family Room \n" +
                "2.Double Room \n" +
                "3.Double Room + Mountain View \n" +
                "4.Attic Room \n");

            room = Console.ReadLine();

            Reception re = new Reception();

            decimal Price = Reception.;
            Console.WriteLine("Price is:"+ Price +"\n");
        }
    }
}
