using System;
using System.Collections.Generic;
using System.Text;

namespace THConsoleApp
{
    public abstract class Room
    {
        public  int Id { get; private set; }
        public decimal Price { get; private set; }
        protected abstract decimal RoomPrice();
        public void CalcPrice(int time)
        {
            var Pr = RoomPrice();
            if (time > 3)
                this.Price -= Pr * 10m / 100m;
        }
       
    }
}
