using System;
using System.Collections.Generic;
using System.Text;

namespace Test1_HucAlexandru
{
    class Resorts
    {
        public string clientOpinion = string.Empty;
        public Resorts()
        {
            this.clientOpinion = "..waiting for clients..";
        }

        public Resorts(int key, int nrOfDays, string opinion)
        {
            Room clientRoom = new Room(key);
            Price clientPrice = new Price(key);
            Days clientDays = new Days(nrOfDays);

            if(clientDays.myDays <= 0)
            {
                clientRoom = new Room();
                clientPrice = new Price();
                clientDays = new Days();
                this.clientOpinion = "Resorts: ..waiting for clients..";
            }
            else if(clientDays.myDays > 0 && clientDays.myDays <= 3)
            {
                this.clientOpinion = opinion;
            }
            else if(clientDays.myDays > 3)
            {
                clientPrice = new Price(key, nrOfDays);
                this.clientOpinion = opinion;
            }

            Console.WriteLine(
            "Room: {0}" +
            "Days: {1}" +
            "Price: {2}" +
            "Client Opinion: {3}",
            clientRoom.myRoom,
            clientDays.myDays,
            clientPrice.myPrice,
            this.clientOpinion
            );
        }
    }
}
