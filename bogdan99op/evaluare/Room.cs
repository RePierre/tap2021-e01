using System;
using System.Collections.Generic;
using System.Text;

namespace evaluare
{
    class Room
    {
        int floor, price, tenants;
        //in floor retinem etajul;
        //in price pretul,si tennants retinem umarul de chiriasi pe care il poate avea,astefel imi dau seama de ce fel e camera: daca tenants=2 inseamna ca e dubla,mai mare strict ca 2 inseamna ca e de familiee
        bool nice_view;
        //asa vad eu daca camera are vedere spre munte sau nu
        Room() { floor = 0;price = 0;tenants = 0;nice_view = false; }
        Room (int floor_level, int price_for_room, int numer_of_tenants, bool room_nice_view)
        {
            floor= floor_level;
            price = price_for_room;
            tenants = numer_of_tenants;
            nice_view = room_nice_view;

        }
      
    }
}
