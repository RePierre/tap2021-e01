using System;
using System.Collections.Generic;
using System.Text;

namespace evaluare
{
    class Date
    {
        private int day, month, year;
        Date() { year = 0; month = 0; day = 0; }
        Date(int y,int m,int d) { day = d;month = m;year = y; }
        public int get_day() { return day; }
        public int get_month() { return month; }
        public int get_year() { return year; }
    }
}
