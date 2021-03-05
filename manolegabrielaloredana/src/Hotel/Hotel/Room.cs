namespace Hotel
{
    public abstract class Room
    {
        public int Numar { get; private set; }
        
        public void Status(int status)
        {
            this.Numar = status;
        }
        protected abstract int Price(int price);
        protected abstract int HappyCustomer(int days);
    }
}
