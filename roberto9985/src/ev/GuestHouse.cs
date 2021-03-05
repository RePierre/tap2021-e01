using System;
using System.Collections.Generic;
using System.Text;

namespace ev
{
    class GuestHouse {

        List<room> ListOfRooms = new List<room>(6);
 

        public GuestHouse(List<room> x)
        {
            for (int i = 1; i <=  6; ++i)
            {   

                ListOfRooms[i] = x[i];
            }

        }

        public void reserve(TypeOfRoom)
        {

        }


    }
}
