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
        public event TimerHandler TimerStoppedEvent;

        private SoundPlayer soundPlayer;

        private Activity _selectedActivity;

        public ActivityTimer()
        {
            InitializeComponent();
            Timer_Init ();

            Stop_timerSecond.Interval  = 1000;
            Pomod_timerSecond.Interval = 1000;

            Pomod_timerSecond.Tick += Pomod_timerSecond_Tick;

            //Automatic Start/Stop enable
            TimerStartedEvent += EnableTimerMode;
            TimerStoppedEvent += DisableTimerMode;

            TimerStoppedEvent ();

            soundPlayer = new SoundPlayer (@"Sound/SOUND_RING_ALARM.wav");
        }
        public void setSelectedActivity (Activity selectedActivity)
        {
            _selectedActivity = selectedActivity;
        }
        //Ugy allitja a gombokat hogy a modoknak megfelelo legyen
        private void EnableTimerMode ()
        {
            Timer_bStart.Enabled = false;
            Stop_bStart.Enabled  = false;
            Pomod_bStart.Enabled = false;

            Timer_bSetTime.Enabled     = false;
            Pomod_bSetRestTime.Enabled = false;
            Pomod_bSetWorkTime.Enabled = false;

            Timer_bPause.Enabled = true;
            Timer_bStop.Enabled  = true;
            Stop_bPause.Enabled  = true;
            Stop_bStop.Enabled   = true;
            Pomod_bPause.Enabled = true;
            Pomod_bStop.Enabled  = true;

            EnableTab (false);
        }
        private void DisableTimerMode ()
        {
            Timer_bSetTime.Enabled     = true;
            Pomod_bSetRestTime.Enabled = true;
            Pomod_bSetWorkTime.Enabled = true;

            Timer_bStart.Enabled = true;
            Stop_bStart.Enabled  = true;
            Pomod_bStart.Enabled = true;

            Timer_bPause.Enabled = false;
            Timer_bStop.Enabled  = false;
            Stop_bPause.Enabled  = false;
            Stop_bStop.Enabled   = false;
            Pomod_bPause.Enabled = false;
            Pomod_bStop.Enabled  = false;

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

        private Utils.TimerLogic Timer_Timer;

        private void Timer_Init ()
        {
            Timer_Timer                  = new TimerLogic ();
            Timer_Timer.TimeChangedEvent += Timer_TimeChangedHandler;
            Timer_Timer.TimerEndedEvent  += Timer_TimerEnded;
        }

        private void Timer_bSet_Click (object sender, EventArgs e)
        {
            String setTime = Timer_tSetTime.Text;
            try
            {
                Timer_Timer.InitTime       = new Time (TimeConverter.StringToTimeHHMMSS (setTime));
                Timer_lRemainingTime.Text  = TimeConverter.TimeToStringHHMMSS (Timer_Timer.InitTime.Seconds);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given. Please give in the following format: hh:mm:ss");
                Timer_Timer.isValidTimeSet = false;
            }
        }

        private void Timer_bStart_Click (object sender, EventArgs e)
        {
            if (Timer_Timer.isValidTimeSet)
            {
                Timer_Timer.Start ();
                TimerStartedEvent.Invoke ();
            }
            else
            {
                MessageBox.Show ("You must specify a time first.");
            }
        }

        private void Timer_bPause_Click (object sender, EventArgs e)
        {
            if (Timer_bPause.Text == "Pause")
            {
                Timer_bPause.Text = "Continue";
                Timer_Timer.Pause ();
            }
            else
            {
                Timer_bPause.Text = "Pause";
                Timer_Timer.Continue ();
            }
        }

        private void Timer_bStop_Click (object sender, EventArgs e)
        {
            Timer_Timer.Stop (); //Automaticly calls Timer_TimerEnded
        }

        private void Timer_TimeChangedHandler ()
        {
            Timer_lRemainingTime.Text = TimeConverter.TimeToStringHHMMSS (Timer_Timer.RemainTime.Seconds);
        }

        private void Timer_TimerEnded ()
        {
            TimerStoppedEvent.Invoke ();
            _selectedActivity.AddTime (Timer_Timer.GetElapsedTime ().Minutes);

            //Popup menu where you can modify your time minus plus +-(ha eppen nem sikerult olyan jól )
            soundPlayer.PlaySoundUntilStop ();
            MessageBox.Show ("Timer done");
            soundPlayer.StopSound ();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// STOPWATCH CODE GOES HERE ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private Time Stop_elapsedTime = new Time ();
        private void Stop_stopwatchSecond_Tick (object sender, EventArgs e)
        {
            Stop_elapsedTime = new Time(Stop_elapsedTime.Seconds + 1);
            Stop_lTime.Text  = TimeConverter.TimeToStringHHMMSS (Stop_elapsedTime.Seconds);
        }
     
        private void Stop_bStart_Click (object sender, EventArgs e)
        {
            Stop_elapsedTime = new Time ();
            Stop_lTime.Text = TimeConverter.TimeToStringHHMMSS (Stop_elapsedTime.Seconds);
            Stop_timerSecond.Start ();
            TimerStartedEvent.Invoke ();
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
            TimerStoppedEvent.Invoke ();
            _selectedActivity.AddTime (Stop_elapsedTime.Minutes);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// MANUAL ADD CODE GOES HERE ///////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void bManualAdd_Click (object sender, EventArgs e)
        {
            try
            {
                long needToAddTimeSec = TimeConverter.StringToTimeHHMMSS (Manual_tSetTime.Text);
                _selectedActivity.AddTime (needToAddTimeSec / 60);
            }
            catch(InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given. Please give in the following format: hh:mm:ss");
            }
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
                if(result == DialogResult.Yes)
                {
                    _selectedActivity.RemovedAsHabit ();
                    Habit_AddHabit ();
                }
            }
        }

        private void Habit_bRemoveFromHabbits_Click (object sender, EventArgs e)
        {
            _selectedActivity.RemovedAsHabit ();
        }
        private void Habit_AddHabit()
        {
            try
            {
                long habitTimeSec = TimeConverter.StringToTimeHHMMSS(Habit_tSetTime.Text);
                long habitTimeMin = habitTimeSec/60;
             
                _selectedActivity.AddedAsHabit (habitTimeMin);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given. Please give in the following format: hh:mm:ss");
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// POMODORO CODE GOES HERE /////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        enum Pomod_Status { Idle, Work, Rest };

        Pomod_Status Pomod_status = Pomod_Status.Idle;
        Timer Pomod_timerSecond = new Timer ();
        System.Diagnostics.Stopwatch Pomod_stopwatchIdle = new System.Diagnostics.Stopwatch ();
        bool Pomod_isValidWorkTimeSet = true;
        bool Pomod_isValidRestTimeSet = true;

        long Pomod_alreadySetWorkTimeSec = 1200; //These values ensures that if you click start, the timer start from the set time again
        long Pomod_alreadySetRestTimeSec = 300;

        long Pomod_startingWorkTimeSec = 1200; //Todo settingsbol mondjuk kinyerni ezeket?
        long Pomod_startingRestTimeSec = 300;
        long Pomod_remainingTimeSec;
        long Pomod_elapsedWorkTimeSec = 0;
        long Pomod_elapsedRestTimeSec = 0;
        
        private void Pomod_Init ()
        {
            ///TODO
        }

        private void Pomod_bStart_Click (object sender, EventArgs e)
        {
            if (Pomod_isValidWorkTimeSet && Pomod_isValidRestTimeSet)
            {
                Pomod_InitializeTimer ();

                Pomod_ChangeStatus (Pomod_Status.Work);
                Pomod_timerSecond.Start ();
                TimerStartedEvent.Invoke ();
            }
            else
            {
                MessageBox.Show ("You must specify a valid time first.");
            }
        }

        private void Pomod_timerSecond_Tick (object sender, EventArgs e)
        {
            Pomod_remainingTimeSec--;
            if (Pomod_remainingTimeSec == 0)
            {
                Pomod_timerSecond.Stop ();

                Pomod_OpenSetEndingDialog ();
                if (Pomod_status == Pomod_Status.Work)
                {
                    Pomod_elapsedWorkTimeSec += Pomod_startingWorkTimeSec;
                    Pomod_ChangeStatus (Pomod_Status.Rest);
                    Pomod_remainingTimeSec = Pomod_startingRestTimeSec;
                }
                else if (Pomod_status == Pomod_Status.Rest)
                {
                    Pomod_elapsedRestTimeSec += Pomod_startingRestTimeSec;
                    Pomod_ChangeStatus (Pomod_Status.Work);
                    Pomod_remainingTimeSec = Pomod_startingWorkTimeSec;
                }

                Pomod_timerSecond.Start ();
            }
            Pomod_lValueRemainingTime.Text = TimeConverter.TimeToStringMMSS (Pomod_remainingTimeSec);
        }
        private void Pomod_InitializeTimer ()
        {
            Pomod_startingRestTimeSec = Pomod_alreadySetRestTimeSec;
            Pomod_remainingTimeSec    = Pomod_alreadySetWorkTimeSec;
            Pomod_startingWorkTimeSec = Pomod_alreadySetWorkTimeSec;

            Pomod_lValueRemainingTime.Text = TimeConverter.TimeToStringMMSS (Pomod_alreadySetWorkTimeSec);
        }
        private void Pomod_OpenSetEndingDialog ()
        {
            Pomod_stopwatchIdle.Stop (); //Pause
            soundPlayer.PlaySoundUntilStop ();

            if (Pomod_status == Pomod_Status.Rest)
                MessageBox.Show ("Rest ended, It's time to work, good luck!");
            if (Pomod_status == Pomod_Status.Work)
                MessageBox.Show ("Work ended, It's time to rest, good luck!");

            soundPlayer.StopSound ();
            Pomod_stopwatchIdle.Start (); //Continue
        }
        private void Pomod_bPause_Click (object sender, EventArgs e)
        {
            if (Pomod_bPause.Text == "Pause")
            {
                Pomod_bPause.Text = "Continue";
                Pomod_stopwatchIdle.Start (); //Continue stopwatch
                Pomod_timerSecond.Stop ();
            }
            else
            {
                Pomod_bPause.Text = "Pause";
                Pomod_stopwatchIdle.Stop (); //Pause
                Pomod_timerSecond.Start ();
            }
        }
        private void Pomod_bStop_Click (object sender, EventArgs e)
        {
            Pomod_stopwatchIdle.Stop (); //Pause
            Pomod_timerSecond.Stop ();
            TimerStoppedEvent.Invoke ();

            if(Pomod_status == Pomod_Status.Work) //Adds remaining time to the whole time
                Pomod_elapsedWorkTimeSec += Pomod_startingWorkTimeSec - Pomod_remainingTimeSec;
            if(Pomod_status == Pomod_Status.Rest)
                Pomod_elapsedRestTimeSec += Pomod_startingRestTimeSec - Pomod_remainingTimeSec;
            Pomod_ChangeStatus (Pomod_Status.Idle);

            Pomod_OpenSummaryDialog ();
            Pomod_stopwatchIdle.Reset ();
        }
        private void Pomod_OpenSummaryDialog ()
        {
            PomodoroSummaryDialog dialog = new PomodoroSummaryDialog ();
            dialog.Initialize (_selectedActivity, 
                               Pomod_elapsedWorkTimeSec,
                               Pomod_elapsedRestTimeSec,
                               Pomod_stopwatchIdle.Elapsed.Seconds);
            dialog.ShowDialog ();
            Pomod_stopwatchIdle.Reset ();
        }
        private void Pomod_bSetWorkTime_Click (object sender, EventArgs e)
        {
            try
            {
                String setTime                 = Pomod_tValueSetWorkTimeMin.Text;
                Pomod_alreadySetWorkTimeSec    = TimeConverter.ConvertMinToSec (TimeConverter.ConvertStringToLongSafe (setTime));
                Pomod_remainingTimeSec         = Pomod_startingWorkTimeSec;
                Pomod_isValidWorkTimeSet       = true;
                Pomod_lValueRemainingTime.Text = TimeConverter.TimeToStringMMSS (Pomod_startingWorkTimeSec);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid work time given, please input only minutes");
                Pomod_isValidWorkTimeSet = false; //conversion failed
            }
        }
        private void Pomod_bSetRestTime_Click (object sender, EventArgs e)
        {
            try
            {
                String setTime                 = Pomod_tValueSetRestTimeMin.Text;
                Pomod_alreadySetRestTimeSec     = TimeConverter.ConvertMinToSec (TimeConverter.ConvertStringToLongSafe (setTime));
                Pomod_isValidRestTimeSet       = true;
                Pomod_lValueRemainingTime.Text = TimeConverter.TimeToStringMMSS (Pomod_startingWorkTimeSec);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid rest time given, please input only minutes");
                Pomod_isValidRestTimeSet = false; //conversion failed
            }
        }
        private void Pomod_ChangeStatus (Pomod_Status status)
        {
            if(status == Pomod_Status.Idle)
            {
                Pomod_status          = Pomod_Status.Idle; 
                Pomod_lValueMode.Text = "Idle";
            }
            else if (status == Pomod_Status.Work)
            {
                Pomod_status          = Pomod_Status.Work;
                Pomod_lValueMode.Text = "Work";
            }
            else if (status == Pomod_Status.Rest)
            {
                Pomod_status          = Pomod_Status.Rest;
                Pomod_lValueMode.Text = "Rest";
            }
        }

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
