using System;

namespace src
{
    public class Reception
    {
        public static readonly Reception _instance = new Reception();

        public static Reception Instance => _instance;

        Room[] rooms;

        private Reception()
        {
            rooms = new Room[] {
                NewFamilyRoom(),

                NewDoubleRoom(),
                NewDoubleRoomWithMountainView(),
                NewDoubleRoomWithMountainView(),

                NewMansardRoom(),
                NewMansardRoom(),
            };
        }
        public int CalculateCost(int roomNumber, DateTime start, DateTime end)
        {
            roomNumber--;
            if (roomNumber < 0 || roomNumber >= rooms.Length)
            {
                throw new InvalidOperationException(
                    $"Room {roomNumber + 1} doesn't exist. We only have rooms 1..{rooms.Length}");
            }
            return rooms[roomNumber].CalculateCost(start, end);
        }
        
        private Room NewFamilyRoom() { return new Room(200, "Family Room"); }
        private Room NewDoubleRoom() { return new Room(120, "Double Room"); }
        private Room NewDoubleRoomWithMountainView() { return new Room(150, "Double Room With Mountain View"); }
        private Room NewMansardRoom() { return new MansardRoom(100, "Mansard Room"); }
    }
}
