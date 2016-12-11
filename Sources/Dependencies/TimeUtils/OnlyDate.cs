using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class OnlyDate
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
        //Returns 0 if identical, +num if lhs, -Num if rhs
        public int compare (OnlyDate lhs, OnlyDate rhs)
        {
            int year = lhs.Year   - rhs.Year;
            int month = lhs.Month - rhs.Month;
            int day  = lhs.Day - rhs.Day;
            if (year == 0)
            {
                if (month == 0)
                    return day;
                else
                    return month;
            }
            else
            {
                return year;
            }
        }
    }
}
