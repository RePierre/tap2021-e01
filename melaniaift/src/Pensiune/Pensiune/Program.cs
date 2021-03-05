using System;

namespace Pensiune
{

    class Reception
    {

        static void Main(string[] args)
        {
            var camera = new loftRoom1();
            System.Console.Write(camera.roomNr()) ;

            System.Console.Write($"Pretul camerei: {camera.fee()} RON");
           
        }
    }
}
