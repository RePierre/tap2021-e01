namespace Tap2021ev.Console
{
    class floor : guest_house
    {
        protected int nr, price;
        public floor(int nr, int price)
        {
            this.nr = nr;
            this.price = price;
        }
        public override void scrie()
        {
            System.Console.WriteLine("Etajul are ", nr, " camere duble");
            System.Console.WriteLine("Dintre care ", nr-1, " camere duble cu vedere la mare");


        }

    }
}
