namespace Tap2021ev.Console
{
    class ground_floor : guest_house
    {
        protected int nr,price;
        public ground_floor(int nr,int price)
        {
            this.nr = nr;
            this.price = price;
        }
        public override void scrie()
        {
            System.Console.WriteLine("Parterul are ",nr," camera de familie care costa",price," RON/noapte");
           
        }

    }
}
