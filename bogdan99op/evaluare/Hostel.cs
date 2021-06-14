using System;
using System.Collections.Generic;
using System.Text;

namespace evaluare
{
    class Hostel
    {
        string name;
        int levels;
        Hostel() { name = null;levels = 0; }
        Hostel(string name_of_hostel,int number_of_floors)
        {
            name = name_of_hostel;
            levels = number_of_floors;
        }
    }
}
