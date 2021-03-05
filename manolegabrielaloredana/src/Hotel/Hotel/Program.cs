using System;

namespace Hotel
{
    class Program
    {
        private const int numberofroom=2;
        private const int numberofroom2 = 5;
        int days=5;
        static void Main(string[] args)
        {
            var room = new MountainViewRoom();
            var room2 = new RoomWithAttic();
            room.Status(1);
            room2.Status(1);
            Console.WriteLine($"Camera {numberofroom} este ocupata.");
            Console.WriteLine($"Camera {numberofroom2} este ocupata.");
        }
    }
}
