using System;
using System.Collections.Generic;
using System.Text;

namespace THConsoleApp
{
    class DoubleRoom:Room
    {
        protected override decimal RoomPrice()
        {
            return 120m;
        }
    }
}
