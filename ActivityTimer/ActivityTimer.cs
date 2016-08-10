﻿using System;
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
        private Dictionary<Activity,long> _habitContainer;

        public ActivityTimer()
        {
            InitializeComponent();
            _habitContainer = new Dictionary<Activity,long>(); ///TODO Esetleg átrakni ACTIVITYBE es szerializálni
            tabPicker.Dock  = DockStyle.Fill;
            Timer_timerSecond.Interval     = 1000; // 1 sec
            Stop_timerSecond.Interval = 1000;
        }
        public void setSelectedActivity(Activity selectedActivity)
        {
            _selectedActivity = selectedActivity;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// TIMER CODE GOES HERE ////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private long Timer_remainingTimeSeconds;
        private long Timer_startingTimeSeconds;

        private void Timer_bSet_Click (object sender, EventArgs e)
        {
            String setTime        = Timer_tSetTime.Text;
            Timer_lRemainingTime.Text   = setTime;
            Timer_startingTimeSeconds  = TimeConverter.stringToTime (setTime);
            Timer_remainingTimeSeconds = Timer_startingTimeSeconds;
        }

        private void Timer_bStart_Click(object sender, EventArgs e)
        { 
            Timer_timerSecond.Start ();
            if (TimerStartedEvent != null)
                TimerStartedEvent ();
            Timer_bSetTime.Enabled = false;
        }

        private void Timer_timerSecond_Tick(object sender, EventArgs e)
        {
            Timer_remainingTimeSeconds--;
            if (Timer_remainingTimeSeconds == 0)
            {
                Timer_timerSecond.Stop ();
                if(TimerStoppedEvent != null)
                    TimerStoppedEvent ();
                _selectedActivity.AddTime (Timer_startingTimeSeconds / 60);
                ///TODO
                //Play sound??
                //Popup menu where you can modify your time minus plus +- ( ha eppen nem sikerult olyan jól )
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                //player.Play();
            }
            Timer_lRemainingTime.Text = TimeConverter.timeToString (Timer_remainingTimeSeconds);
        }
        private void bPause_Click (object sender, EventArgs e)
        {
            if (Timer_bTimerPause.Text == "Pause")
            {
                Timer_bTimerPause.Text = "Continue";
                Timer_timerSecond.Stop ();
            }
            else
            {
                Timer_bTimerPause.Text = "Pause";
                Timer_timerSecond.Start ();
            }
        }
        private void bStop_Click (object sender, EventArgs e)
        {
            Timer_bSetTime.Enabled = true;
            Timer_timerSecond.Stop ();
            if (TimerStoppedEvent != null)
                TimerStoppedEvent ();
            long elapsedTimeSeconds = Timer_startingTimeSeconds - Timer_remainingTimeSeconds;
            ///TODO Update activity
        }
        //TODO ha bármelyiket elindítuk a másikat ne lehessen elindítani
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// STOPWATCH CODE GOES HERE ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private long Stop_sTimeSecond = 0;
        private void Stop_stopwatchSecond_Tick (object sender, EventArgs e)
        {
            Stop_sTimeSecond++;
            Stop_lTime.Text = TimeConverter.timeToString (Stop_sTimeSecond);
        }
     
        private void Stop_bStart_Click (object sender, EventArgs e)
        {
            Stop_sTimeSecond = 0;
            Stop_lTime.Text = TimeConverter.timeToString (Stop_sTimeSecond);
            Stop_timerSecond.Start ();
            if (TimerStartedEvent != null)
                TimerStartedEvent ();
        }

        private void Stop_bPause_Click (object sender, EventArgs e)
        {
            if (Stop_bPause.Text == "Pause")
            {
                Stop_bPause.Text = "Continue";
                Stop_timerSecond.Stop ();
            }
            else
            {
                Stop_bPause.Text = "Pause";
                Stop_timerSecond.Start ();
            }
        }

        private void Stop_bStop_Click (object sender, EventArgs e)
        {
            Stop_timerSecond.Stop ();
            if (TimerStoppedEvent != null)
                TimerStoppedEvent ();
            long measuredMin = Stop_sTimeSecond / 60;
            _selectedActivity.AddTime (measuredMin);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// MANUAL ADD CODE GOES HERE ///////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void bManualAdd_Click (object sender, EventArgs e)
        {
            long needToAddTimeSec = TimeConverter.stringToTime (Manual_tSetTime.Text);
            _selectedActivity.AddTime (needToAddTimeSec / 60);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// HABIT ADD CODE GOES HERE ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void bSetAsHabit_Click (object sender, EventArgs e)
        {
            long habitTimeSec = TimeConverter.stringToTime(Habit_tSetTime.Text);
            long habitTimeMin = habitTimeSec/60;

            //if (_habitContainer.ContainsKey (_selectedActivity))
            //    ;///TODO Popup -> Felülírja az előző activityt.

            _habitContainer.Add (_selectedActivity, habitTimeMin);

            _selectedActivity.AddedAsHabit ();
        }
        private class TimeConverter
        {
            static readonly long MINTOSEC  = 60;
            static readonly long HOURTOSEC = 3600;
            static public long stringToTime (string time)
            {
                String[] timeArray = time.Split(':');
                long timeSeconds = 0;
                timeSeconds += Int64.Parse (timeArray[0]) * HOURTOSEC;
                timeSeconds += Int64.Parse (timeArray[1]) * MINTOSEC;
                timeSeconds += Int64.Parse (timeArray[2]);

                return timeSeconds;
            }
            static public string timeToString (long time)
            {
                long hour = time / HOURTOSEC;
                time = time % HOURTOSEC;
                long min  = time / MINTOSEC;
                time = time % MINTOSEC;
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
    }

    
}
