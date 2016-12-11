using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeUtils
{
    class OnlyDate
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public OnlyDate (DateTime dateTime)
        {
            Year      = dateTime.Year;
            Month     = dateTime.Month;
            Day       = dateTime.Day;
        }
        public OnlyDate AddDays (int days)
        {
            DateTime date = new DateTime(Year,Month,Day);
            return new OnlyDate (date.AddDays (days));            
        }
    }
}
