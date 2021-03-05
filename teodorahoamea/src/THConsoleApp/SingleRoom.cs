using System;
using System.Collections.Generic;
using System.Text;

namespace THConsoleApp
{
    class SingleRoom:Room
    {
        protected override decimal RoomPrice()
        {

            return 100m;
        }
    }
}
