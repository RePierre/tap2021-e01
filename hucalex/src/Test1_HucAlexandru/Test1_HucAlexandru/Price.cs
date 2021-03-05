using System;
using System.Collections.Generic;
using System.Text;

namespace Test1_HucAlexandru
{
    class Price
    {
        public decimal myPrice;

        public Price()
        {
            myPrice = 0;
        }

        public Price(int key)
        {
            if (key == 1)
            {
                this.myPrice = 200;
            }
            else if (key == 2)
            {
                this.myPrice = 120;
            }
            else if (key == 3)
            {
                this.myPrice = 150;
            }
            else if (key == 4)
            {
                this.myPrice = 100;
            }
        }

        public Price(int key, int nrOfDays)
        {
            if(nrOfDays <= 0)
            {
                if (key == 1)
                {
                    this.myPrice = 200 * nrOfDays;
                }
                else if (key == 2)
                {
                    this.myPrice = 120 * nrOfDays;
                }
                else if (key == 3)
                {
                    this.myPrice = 150 * nrOfDays;
                }
                else if (key == 4)
                {
                    this.myPrice = 100 * nrOfDays;
                }
            }
            else if(nrOfDays > 3)
            {
                if (key == 1)
                {
                    this.myPrice = (int)(200 * 3 + 200 * 0.1 * (nrOfDays - 3));
                }
                else if (key == 2)
                {
                    this.myPrice = (int)(120 * 3 + 120 * 0.1 * (nrOfDays - 3));
                }
                else if (key == 3)
                {
                    this.myPrice = (int)(150 * 3 + 150 * 0.1 * (nrOfDays - 3));
                }
                else if (key == 4)
                {
                    this.myPrice = (int)(100 * 3 + 100 * 0.1 * (nrOfDays - 3)); ;
                }
            }
        }
    }
}
