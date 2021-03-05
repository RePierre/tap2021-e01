using System;
using System.Collections.Generic;
using System.Text;

namespace THConsoleApp
{
    public abstract class Room
    {
        public  int Id { get; set; }
        public decimal Price { get; private set; }
        protected abstract decimal RoomPrice();
        public void CalcPrice(int time)
        {
            var Pr = RoomPrice();
            if (time > 3)
                this.Price = Pr - Pr * 10m / 100m;
            else
                this.Price = Pr;
        }
       
    }
}
