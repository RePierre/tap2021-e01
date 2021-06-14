using System;

namespace src
{
    public class MansardRoom : Room
    {
        public MansardRoom(int perNightCost, string name)
            : base(perNightCost, name)
        {
        }
        protected override int CalculateCost(int duration)
        {
            double price = perNightCost * duration;
            if (duration > 3) {
                price -= 0.1 * (duration - 3) * perNightCost;
            }
            return (int)price;
        }
    }
}
