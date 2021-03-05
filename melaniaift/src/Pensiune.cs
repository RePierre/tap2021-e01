using System;

namespace Pensiune
{
    public abstract class Room
    {
        protected abstract decimal roomNr(decimal amount);

    }
    class familyRoom : Room
    {
        protected override decimal roomNr(decimal amount)
        {
            return 1;
        }
    }

    class doubleRoomSimple : Room
    {
        protected override decimal roomNr(decimal amount)
        {
            return 1;
        }
    }

    class doubleRoomView : Room
    {
        protected override decimal roomNr(decimal amount)
        {
            return 1;
        }
    }

    class loftRoom : Room
    {
        protected override decimal roomNr(decimal amount)
        {
            return 1;
        }
    }

    class Reception
    {

        static void Main(string[] args)
        {
            var camera = new loftRoom();
            System.Console.Write(camera.roomNr(10));
        }
    }
}
