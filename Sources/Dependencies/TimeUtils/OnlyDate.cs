using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    [Serializable]
    public class OnlyDate : IComparable<OnlyDate>, IComparer<OnlyDate>, ISerializable
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

        public int CompareTo (OnlyDate rhs)
        {
            int year = Year   - rhs.Year;
            int month = Month - rhs.Month;
            int day  = Day - rhs.Day;
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

        public int Compare (OnlyDate lhs, OnlyDate rhs)
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

        protected OnlyDate (SerializationInfo info, StreamingContext context)
        {
            Year = info.GetInt32 ("_year");
            Month = info.GetInt32 ("_month");
            Day = info.GetInt32 ("_day");
        }
        public void GetObjectData (SerializationInfo info, StreamingContext context)
        {
            info.AddValue ("_year", Year);
            info.AddValue ("_month", Month);
            info.AddValue ("_day", Day);
        }
    }
}
