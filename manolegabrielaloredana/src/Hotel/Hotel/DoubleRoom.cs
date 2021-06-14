namespace Hotel
{
    public class DoubleRoom : Room
    {
        protected override int Price(int price)
        {
            return 120;
        }
        protected override int HappyCustomer(int days)
        {
            return 200 - 10 / 100 * 120;
        }
    }
}
