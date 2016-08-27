using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class TimerLogic
    {
        public  Time InitTime   = new Time ();
        public  Time StartTime  = new Time ();
        private Time RemainTime = new Time ();

        public Time GetElapsedTime ()
        {
            return new Time (StartTime.Seconds - RemainTime.Seconds);
        }

        //Timer start event
        //Timer end event
    }
}
