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
using Utils;

namespace ActivityTimer
{
    [Serializable]
    public partial class ActivityTimer : UserControl
    {
        public delegate void TimerHandler ();
        public event TimerHandler TimerStartedEvent;
        public event TimerHandler TimerStoppedEvent; ///TODO Ne lehessen tabot váltani!

        private Activity _selectedActivity;

        public ActivityTimer()
        {
            InitializeComponent();
            
            tabPicker.Dock  = DockStyle.Fill;
            Timer_timerSecond.Interval     = 1000; // 1 sec
            Stop_timerSecond.Interval = 1000;

            //Automatic Start/Stop enable
            TimerStartedEvent += EnableTimerMode;
            TimerStoppedEvent += DisableTimerMode;

            TimerStoppedEvent ();
        }
        public void setSelectedActivity(Activity selectedActivity)
        {
            _selectedActivity = selectedActivity;
        }
        //Ugy allitja a gombokat hogy a modoknak megfelelo legyen
        private void EnableTimerMode ()
        {
            Timer_bStart.Enabled = false;
            Stop_bStart.Enabled  = false;

            Timer_bSetTime.Enabled = false;
            Pomod_bSetRestTime.Enabled = false;
            Pomod_bSetWorkTime.Enabled = false;

            Timer_bPause.Enabled = true;
            Timer_bStop.Enabled  = true;
            Stop_bPause.Enabled  = true;
            Stop_bStop.Enabled   = true;

            EnableTab (false);
        }
        private void DisableTimerMode()
        {
            Timer_bSetTime.Enabled = true;
            Pomod_bSetRestTime.Enabled = true;
            Pomod_bSetWorkTime.Enabled = true;

            Timer_bStart.Enabled = true;
            Stop_bStart.Enabled  = true;

            Timer_bPause.Enabled = false;
            Timer_bStop.Enabled  = false;
            Stop_bPause.Enabled  = false;
            Stop_bStop.Enabled   = false;

            EnableTab (true);
        }
        private void EnableTab (bool enable)
        {
            foreach (TabPage ctl in tabPicker.Controls)
                ctl.Enabled = enable;

            tabPicker.TabPages[tabPicker.SelectedIndex].Enabled = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// TIMER CODE GOES HERE ////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private long Timer_remainingTimeSeconds;
        private long Timer_startingTimeSeconds;
        private bool Timer_isValidTimeSet = false;

        private void Timer_bSet_Click (object sender, EventArgs e)
        {
            String setTime        = Timer_tSetTime.Text;
            Timer_lRemainingTime.Text  = setTime;
            try
            {
                Timer_startingTimeSeconds = TimeConverter.stringToTime (setTime);
                Timer_remainingTimeSeconds = Timer_startingTimeSeconds;
                Timer_isValidTimeSet = true;
            }
            catch (InvalidOperationException /*exc*/)
            {
                Timer_isValidTimeSet = false; //conversion failed
            }
        }

        private void Timer_bStart_Click(object sender, EventArgs e)
        {
            if (Timer_isValidTimeSet)
            {
                Timer_timerSecond.Start ();
                if (TimerStartedEvent != null)
                    TimerStartedEvent ();
            }
            else
            {
                MessageBox.Show ("You must specify a time first.");
            }
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
        private void Timer_bPause_Click (object sender, EventArgs e)
        {
            if (Timer_bPause.Text == "Pause")
            {
                Timer_bPause.Text = "Continue";
                Timer_timerSecond.Stop ();
            }
            else
            {
                Timer_bPause.Text = "Pause";
                Timer_timerSecond.Start ();
            }
        }
        private void Timer_bStop_Click (object sender, EventArgs e)
        {
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
            try
            {
                long needToAddTimeSec = TimeConverter.stringToTime (Manual_tSetTime.Text);
                _selectedActivity.AddTime (needToAddTimeSec / 60);
            }
            catch(InvalidOperationException /*exc*/)
            {}
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// HABIT ADD CODE GOES HERE ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void bSetAsHabit_Click (object sender, EventArgs e)
        {
            try
            {
                Habit_AddHabit ();
            }
            catch (ArgumentException /*exc*/)
            {
                DialogResult result = MessageBox.Show("Do you want to overwrite existing habit?", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.OK)
                {
                    _selectedActivity.RemovedAsHabit ();
                    Habit_AddHabit ();
                }
            }
            catch (InvalidOperationException /*exc*/)
            { }
        }

        private void Habit_bRemoveFromHabbits_Click (object sender, EventArgs e)
        {
            _selectedActivity.RemovedAsHabit ();
        }
        private void Habit_AddHabit()
        {
            long habitTimeSec = TimeConverter.stringToTime(Habit_tSetTime.Text);
            long habitTimeMin = habitTimeSec/60;

            _selectedActivity.AddedAsHabit (habitTimeMin);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// POMODORO CODE GOES HERE /////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// OTHER CODE GOES HERE ////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Nem enged tabot valtani ha TImer modban vagyunk
        private void tabPicker_Selecting (object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }
    }

    
}
