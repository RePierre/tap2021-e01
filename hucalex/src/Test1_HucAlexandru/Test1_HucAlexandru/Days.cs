using System;
using System.Collections.Generic;
using System.Text;

namespace Test1_HucAlexandru
{
    class Days
    {
        public int myDays;

        public Days()
        {
            Console.WriteLine("Days: ..waiting for clients..");
        }

        public Days(int nrOfDays)
        {
            this.myDays = nrOfDays;
            Console.WriteLine(this.myDays);
        }
    }
}
