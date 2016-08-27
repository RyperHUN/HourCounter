using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public class TimerLogic
    {
        private  Timer timer       = new Timer ();
        private  Time _initTime    = new Time ();
        private  Time _startTime   = new Time ();
        private  Time _remainTime  = new Time ();
        public bool isValidTimeSet = false;

        public TimerLogic ()
        {
            timer.Interval  = 1000;
            timer.Tick      += timeChanged;
            TimerEndedEvent += TimerEndedHandler;
        }

        public Time InitTime
        {
            get { return _initTime; }
            set
            {
                _initTime      = value;
                isValidTimeSet = true;
            }
        }
        public Time RemainTime
        {
            get { return _remainTime; }
        }

        public Time GetElapsedTime ()
        {
            return new Time (_startTime.Seconds - _remainTime.Seconds);
        }

        public void Start ()
        {
            _startTime = new Time(_initTime);
            TimeChangedEvent.Invoke ();
            timer.Start ();
        }

        public void Pause ()
        {
            timer.Stop ();
        }

        public void Continue ()
        {
            timer.Start ();
        }

        public void Stop ()
        {
            TimerEndedEvent.Invoke ();
        }

        private void timeChanged (object sender, EventArgs e)
        {
            _remainTime = new Time (_remainTime.Seconds - 1);
            TimeChangedEvent.Invoke ();
            
            if (_remainTime.Seconds == 0)
                TimerEndedEvent.Invoke ();
        }

        private void TimerEndedHandler ()
        {
            timer.Stop ();
        }

        public delegate void TimeChange ();
        public event TimeChange TimeChangedEvent;
        public event TimeChange TimerEndedEvent;

        //Timer start event
        //Timer end event
    }
}
