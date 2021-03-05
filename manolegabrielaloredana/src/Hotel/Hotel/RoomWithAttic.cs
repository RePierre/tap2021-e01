namespace Hotel
{
    public class RoomWithAttic : Room
    {
        protected override int Price(int price)
        {
            return 100;
        }
        protected override int HappyCustomer(int days)
        {
            return 200 - 10 / 100 * 100;
        }
    }
}
