namespace Pensiune
{
    public abstract class Room
    {
        public decimal Price1day { get; set; }
        public decimal Reservedays(int numberdays)
        {
            decimal reserveprice;
            reserveprice = this.Price1day;
            if (numberdays>3)
            {
                reserveprice = this.Price1day * 90 /100 ;

            }
           
            return numberdays * reserveprice;
        }

    }
}
