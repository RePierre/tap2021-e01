namespace Pensiune
{
    class doubleRoomSimple : Room
    {
        public override decimal fee()
        {
            return 120;

        }
        public override decimal roomNr()
        {
            return 2;
        }
    }
}
