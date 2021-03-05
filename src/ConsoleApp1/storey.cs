namespace Tap2021Demo.Console
{

    public abstract partial class Pension
	{
        public class storey : Pension
		{
			protected int return_number()
			{
				return 2*Double_Mountain_Room+ Double_Room;
			}
		}

	}

}