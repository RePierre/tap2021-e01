namespace Hotel
{
    public class FamilyRoom : Room
    {
        protected override int Price(int price)
        {
            return 200;
        }
       
        protected override int HappyCustomer(int days)
        {
             return 200 - 10 / 100 * 200;
        }
    }
}
