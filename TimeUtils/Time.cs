using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    [Serializable]
    public class Time : ISerializable
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

        //Serialization
        public void GetObjectData (SerializationInfo info, StreamingContext context)
        {
            info.AddValue ("Time.TimeInSeconds", _timeInSeconds);
        }

        protected Time (SerializationInfo info, StreamingContext context)
        {
            _timeInSeconds = (long)info.GetValue ("Time.TimeInSeconds", typeof(long));
        }

    }

    public class TIME
    {
        public static Time Seconds (int seconds)
        {
            return new Time (seconds);
        }

        public static Time Minutes (int minutes)
        {
            return new Time (minutes * 60);
        }

        public static Time Hours (int hours)
        {
            return new Time (hours * 3600);
        }
    }
}
