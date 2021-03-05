using System;

namespace Pensiune
{

    class Program
    {
        static void Main(string[] args)
        {
            string room;
           int days;
            Console.WriteLine("Choose one type of room: \n");
            Console.WriteLine("1.Family Room \n" +
                "2.Double Room \n" +
                "3.Double Room + Mountain View \n" +
                "4.Attic Room \n");

            room = Console.ReadLine();
            days =  Convert.ToInt32(Console.ReadLine());
            Reception re = new Reception();

            decimal Price = Reception.ReservesPrice(days, room);// ??? Does not work
            Console.WriteLine("Price is:"+ Price +"\n");
        }
    }
}
