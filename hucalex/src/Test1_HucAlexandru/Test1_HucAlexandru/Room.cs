using System;
using System.Collections.Generic;
using System.Text;

namespace Test1_HucAlexandru
{
    class Room
    {
        public string myRoom = string.Empty;

        public Room()
        {
            this.myRoom = "Room: ..waiting for clients..";
        }

        public Room(int key)
        {
            if (key == 1)
            {
                this.myRoom = "Camera de familie";
            }
            else if (key == 2)
            {
                this.myRoom = "Camera dubla simpla";
            }
            else if (key == 3)
            {
                this.myRoom = "Camera dubla cu vedere la munte";
            }
            else if (key == 4)
            {
                this.myRoom = "Camera la mansarda";
            }
        }
    }
}
