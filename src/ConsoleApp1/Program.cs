using System;
using static Tap2021Demo.Console.Pension;

namespace Tap2021Demo.Console
{

    public abstract partial class Pension
	{
		public int Room { get; private set; }

        public int Family_Room => this.Room = 200;

		public int Double_Room => this.Room = 120;

		public int Double_Mountain_Room => this.Room = 150;

		public int Attic_Room => this.Room = 100;

	}



	class Program
	{
		private const int room = 1;
		static void Main(string[] args) {
			var room1 = new floor();
			System.Console.WriteLine($" {room1}");
		}

	}

}