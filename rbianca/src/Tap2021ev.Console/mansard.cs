namespace Tap2021ev.Console
{
    class mansard : guest_house
    {
        protected int nr, price;
        public mansard(int nr, int price)
        {
            this.nr = nr;
            this.price = price;
        }
        public override void scrie()
        {
            System.Console.WriteLine("Mansarda are ", nr, " camere de o persoana");
        }

    }
}
