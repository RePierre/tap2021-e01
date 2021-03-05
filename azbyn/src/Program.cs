using System;

namespace src
{
    public static class Program
    {
        static void Main(string[] args)
        {
            PrintPriceNicely(2, new DateTime(2021, 3, 5), new DateTime(2021, 3, 8));
            PrintPriceNicely(1, new DateTime(2021, 3, 5), new DateTime(2021, 3, 6));
            PrintPriceNicely(6, new DateTime(2021, 3, 5), new DateTime(2021, 3, 10));
            PrintPriceNicely(5, new DateTime(2021, 3, 10), new DateTime(2021, 3, 12));
        }
        static void PrintPriceNicely(int roomNumber, DateTime start, DateTime end) {
            double cost = Reception.Instance.CalculateCost(roomNumber, start, end);
            var name = Reception.Instance.GetRoomName(roomNumber);
            var delta = (end - start).Days;
            Console.WriteLine($"Room {roomNumber} “{name}” costs {cost} RON for {delta} days");
        }
    }
}
