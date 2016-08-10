using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HourCounter;

namespace ActivityTimer
{
    [Serializable]
    public partial class ActivityTimer : UserControl
    {
        //TODO Ha timer elindul akkor ne lehessen activityt váltani
        public delegate void TimerHandler ();
        public event TimerHandler TimerStartedEvent;
        public event TimerHandler TimerStoppedEvent; ///TODO Ne lehessen tabot váltani!

        private Activity _selectedActivity;
        private long _remainingTimeSeconds;
        private long _startingTimeSeconds;

        private long _stopWatchTimeSecond = 0;

        private Dictionary<Activity,long> _habitContainer = new Dictionary<Activity,long>();
        public ActivityTimer()
        {
            InitializeComponent();
            tabPicker.Dock           = DockStyle.Fill;
            timerSecond.Interval     = 1000; // 1 sec
            timerStopwatchSecond.Interval = 1000;
        }
        public void setSelectedActivity(Activity selectedActivity)
        {
            _selectedActivity = selectedActivity;
        }

        private void bSet_Click (object sender, EventArgs e)
        {
            String setTime        = tSetTime.Text;
            lRemainingTime.Text   = setTime;
            _startingTimeSeconds  = TimeConverter.stringToTime (setTime);
            _remainingTimeSeconds = _startingTimeSeconds;
        }

        private void bStart_Click(object sender, EventArgs e)
        { 
            timerSecond.Start ();
            if (TimerStartedEvent != null)
                TimerStartedEvent ();
            bSet.Enabled = false;
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            _remainingTimeSeconds--;
            if (_remainingTimeSeconds == 0)
            {
                timerSecond.Stop ();
                if(TimerStoppedEvent != null)
                    TimerStoppedEvent ();
                _selectedActivity.AddTime (_startingTimeSeconds / 60);
                ///TODO
                //Play sound??
                //Popup menu where you can modify your time minus plus +- ( ha eppen nem sikerult olyan jól )
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                //player.Play();
            }
            lRemainingTime.Text = TimeConverter.timeToString (_remainingTimeSeconds);
        }
        private void stopwatchSecond_Tick (object sender, EventArgs e)
        {
            _stopWatchTimeSecond++;
            lStopTime.Text = TimeConverter.timeToString (_stopWatchTimeSecond);
        }
        private class TimeConverter
        {
            static readonly long MINTOSEC  = 60;
            static readonly long HOURTOSEC = 3600;
            static public long stringToTime(string time)
            {
                String[] timeArray = time.Split(':');
                long timeSeconds = 0;
                timeSeconds += Int64.Parse (timeArray[0]) * HOURTOSEC;
                timeSeconds += Int64.Parse (timeArray[1]) * MINTOSEC;
                timeSeconds += Int64.Parse (timeArray[2]);

                return timeSeconds;
            }
            static public string timeToString(long time)
            {
                long hour = time / HOURTOSEC;
                time      = time % HOURTOSEC;
                long min  = time / MINTOSEC;
                time      = time % MINTOSEC;
                long sec  = time;

                string hourStr = "" + hour;
                string minStr  = "" + min;
                string secStr  = "" + sec;
                if (hour <= 9)
                    hourStr = "0" + hour;
                if (min <= 9)
                    minStr = "0" + min;
                if (sec <= 9)
                    secStr = "0" + sec;

                string result = hourStr + ":" + minStr + ":" + secStr;

                return result;
            }
        }

        private void bPause_Click (object sender, EventArgs e)
        {
            if(bTimerPause.Text == "Pause")
            {
                bTimerPause.Text = "Continue";
                timerSecond.Stop ();
            }
            else
            {
                bTimerPause.Text = "Pause";
                timerSecond.Start ();
            }
        }

        private void bStop_Click (object sender, EventArgs e)
        {
            bSet.Enabled = true;
            timerSecond.Stop ();
            if (TimerStoppedEvent != null)
                TimerStoppedEvent ();
            long elapsedTimeSeconds = _startingTimeSeconds - _remainingTimeSeconds;
            ///TODO Update activity
        }
        //TODO ha bármelyiket elindítuk a másikat ne lehessen elindítani

        private void bStopStart_Click (object sender, EventArgs e)
        {
            _stopWatchTimeSecond = 0;
            lStopTime.Text = TimeConverter.timeToString (_stopWatchTimeSecond);
            timerStopwatchSecond.Start ();
            if (TimerStartedEvent != null)
                TimerStartedEvent ();
        }

        private void bStopPause_Click (object sender, EventArgs e)
        {
            if (bStopPause.Text == "Pause")
            {
                bStopPause.Text = "Continue";
                timerStopwatchSecond.Stop ();
            }
            else
            {
                bStopPause.Text = "Pause";
                timerStopwatchSecond.Start ();
            }
        }

        private void bStopStop_Click (object sender, EventArgs e)
        {
            timerStopwatchSecond.Stop ();
            if (TimerStoppedEvent != null)
                TimerStoppedEvent ();
            long measuredMin = _stopWatchTimeSecond / 60;
            _selectedActivity.AddTime (measuredMin);

        }

        private void bManualAdd_Click (object sender, EventArgs e)
        {
            long needToAddTimeSec = TimeConverter.stringToTime (tManualSetTime.Text);
            _selectedActivity.AddTime (needToAddTimeSec / 60);
        }

        private void bSetAsHabit_Click (object sender, EventArgs e)
        {
            long habitTimeSec = TimeConverter.stringToTime(tHabitSetTime.Text);
            long habitTimeMin = habitTimeSec/60;

            //if (_habitContainer.ContainsKey (_selectedActivity))
            //    ;///TODO Popup -> Felülírja az előző activityt.

            _habitContainer.Add (_selectedActivity, habitTimeMin);

            _selectedActivity.AddedAsHabit ();
        }
    }

    
}
