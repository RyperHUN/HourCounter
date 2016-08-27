using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Time
    {
        private long _timeInSeconds;
        public Time ()
        {
        }
        
        public Time (long seconds)
        {
            init (seconds);
        }
        public Time (Time time)
        {
            init (time.Seconds);
        }
        private void init (long seconds)
        {
            _timeInSeconds = seconds;
        }

        public long Seconds
        {
            get { return _timeInSeconds; }
            set { _timeInSeconds = value; }
        }
        public long Minutes
        {
            get { return _timeInSeconds / 60; }
            set { _timeInSeconds = value * 60; }
        }
        public long Hours
        {
            get { return _timeInSeconds / 3600; }
            set { _timeInSeconds = value * 3600; }
        }
        public long Days
        {
            get { return _timeInSeconds / 86400; }
            set { _timeInSeconds = value * 86400; }
        }
    }
}
