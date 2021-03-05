using System;

namespace THConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _room1 = new DoubleRoom();
            var _room2 = new SingleRoom();

            Console.WriteLine($"Your room price is {_room1.Price}");
            Console.WriteLine($"Your room price is {_room2.Price}");
        }
    }
}
