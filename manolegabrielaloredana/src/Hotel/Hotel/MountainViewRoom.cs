namespace Hotel
{
    public class MountainViewRoom : Room
    {
        protected override int Price(int price)
        {
            return 150;
        }
        protected override int HappyCustomer(int days)
        {
            return 200 - 10 / 100 * 150;
        }
    }
}
