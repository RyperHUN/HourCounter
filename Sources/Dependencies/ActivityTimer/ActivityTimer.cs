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
using Utils;

namespace ActivityTimer
{
    [Serializable]
    public partial class ActivityTimer : UserControl
    {
        public event Action TimerStartedEvent;
        public event Action TimerStoppedEvent;

        private SoundPlayer timerEndSoundPlayer;
        private SoundPlayer beepSoundPlayer;

        private Activity _selectedActivity;

        public ActivityTimer()
        {
            InitializeComponent();
            Timer_Init ();
            Pomod_Init ();
            Stopwatch_Init ();

            Stop_timerSecond.Interval  = 1000;

            //Automatic Start/Stop enable
            TimerStartedEvent += EnableTimerMode;
            TimerStoppedEvent += DisableTimerMode;

            TimerStoppedEvent ();

            Load_Settings ();
            CheckValidTimes ();
            timerEndSoundPlayer = new SoundPlayer (@"Data/SOUND_RING_ALARM.wav");
            beepSoundPlayer     = new SoundPlayer (@"Data/BLEEP.wav");
        }

        private void Load_Settings () //Maybe this could be called from app when settings got changed
        {
            Settings.TimerSettings setting = Settings.Get.Timers;
            if (setting.timerSetDefaultTime)
                Timer_Timer.InitTime = new Time (setting.timerSetTime);
            else
                Timer_Timer.InitTime = new Time (setting.timerLastSetTime);

            Timer_tSetTime.Text = TimeConverter.TimeToStringHHMMSS (Timer_Timer.InitTime); //Refresh input text

            if (setting.pomodSetDefaultTime)
            {
                Pomod_TimerRest.InitTime = new Time (setting.pomodRestSetTime);
                Pomod_TimerWork.InitTime = new Time (setting.pomodWorkSetTime);
            }
            else
            {
                Pomod_TimerRest.InitTime = new Time (setting.pomodLastSetRestTime);
                Pomod_TimerWork.InitTime = new Time (setting.pomodLastSetWorkTime);
            }

            Pomod_lValueRemainingTime.Text  = TimeConverter.TimeToStringMMSS (Pomod_TimerWork.RemainTime); //Refresh input text
            Pomod_tValueSetWorkTimeMin.Text = TimeConverter.TimeToStringMMSS (Pomod_TimerWork.RemainTime).Split (':')[0];
            Pomod_tValueSetRestTimeMin.Text = TimeConverter.TimeToStringMMSS (Pomod_TimerRest.RemainTime).Split (':')[0];
        }

        private void CheckValidTimes ()
        {
            if (Timer_Timer.isValidTimeSet)
                Timer_bStart.Enabled = true;
            else 
                Timer_bStart.Enabled = false;

            if (Pomod_TimerRest.isValidTimeSet && Pomod_TimerWork.isValidTimeSet)
                Pomod_bStart.Enabled = true;
            else
                Pomod_bStart.Enabled = false;

            Manual_tSetTime_checkInputFormat ();
            Habit_tSetTime_CheckFormat ();
            Stop_tBeepTime_CheckFormat ();
        }

        public void Save_Settings ()
        {
            Settings.TimerSettings setting = Settings.Get.Timers;
            if (setting.pomodRememberLastTime)
            {
                setting.pomodLastSetWorkTime = new Time (Pomod_TimerWork.InitTime);
                setting.pomodLastSetRestTime = new Time (Pomod_TimerRest.InitTime);
            }
            if(setting.timerRememberLastTime)
            {
                setting.timerLastSetTime = new Time (Timer_Timer.InitTime);
            }
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

            Pomod_bPause.Text = "Pause"; //Set pause button to init
            Stop_bPause.Text  = "Pause";
            Timer_bPause.Text = "Pause";

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

        private TimerLogic Timer_Timer;

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
                Timer_Timer.InitTime       = TimeConverter.StringToTime (setTime);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given.");
                Timer_Timer.isValidTimeSet = false;
            }
            CheckValidTimes ();
        }

        private void Timer_bStart_Click (object sender, EventArgs e)
        {
            if (Timer_Timer.isValidTimeSet)
            {
                Timer_Timer.Start ();
                TimerStartedEvent?.Invoke ();
            }
            else
            {
                MessageBox.Show ("You must specify a valid time first.");
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
            TimerStoppedEvent?.Invoke ();
            _selectedActivity.AddTime (Timer_Timer.GetElapsedTime ());
        }

        private void Timer_TimeChangedHandler ()
        {
            Timer_lRemainingTime.Text = TimeConverter.TimeToStringHHMMSS (Timer_Timer.RemainTime);
        }

        private void Timer_TimerEnded ()
        {
            TimerStoppedEvent?.Invoke ();
            _selectedActivity.AddTime (Timer_Timer.GetElapsedTime ());

            //Popup menu where you can modify your time minus plus +-(ha eppen nem sikerult olyan jól )
            timerEndSoundPlayer.PlaySoundUntilStop ();
            MessageBox.Show ("Timer done");
            timerEndSoundPlayer.StopSound ();
        }
        private void Timer_tSetTime_TextChanged (object sender, EventArgs e)
        {
            Timer_CheckInputFormat ();
        }
        private void Timer_CheckInputFormat ()
        {
            if (FormatChecker.SetInputColor (Timer_tSetTime, TimeConverter.isValidStringFormat (Timer_tSetTime.Text)))
                Timer_bSetTime.Enabled = true;
            else
                Timer_bSetTime.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// STOPWATCH CODE GOES HERE ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private Time Stop_elapsedTime = new Time ();
        private Timer Stop_beepTimer  = new Timer ();

        private void Stopwatch_Init ()
        {
            Stop_SetTime ();
            Stop_beepTimer.Tick += (object s, EventArgs e) => beepSoundPlayer.PlayOnce ();
        }
        private void Stop_stopwatchSecond_Tick (object sender, EventArgs e)
        {
            Stop_elapsedTime = new Time(Stop_elapsedTime.Seconds + 1);
            Stop_lTime.Text  = TimeConverter.TimeToStringHHMMSS (Stop_elapsedTime);
        }
     
        private void Stop_bStart_Click (object sender, EventArgs e)
        {
            Stop_elapsedTime = new Time ();
            Stop_lTime.Text = TimeConverter.TimeToStringHHMMSS (Stop_elapsedTime);
            Stop_timerSecond.Start ();
            if (Stop_CheckBeep.Checked)
                Stop_beepTimer.Start ();
            TimerStartedEvent?.Invoke ();
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
            Stop_beepTimer.Stop ();
            TimerStoppedEvent?.Invoke ();
            _selectedActivity.AddTime (Stop_elapsedTime);
        }

        private void Stop_tBeepTime_TextChanged (object sender, EventArgs e)
        {
            Stop_tBeepTime_CheckFormat ();
        }

        private void Stop_tBeepTime_CheckFormat ()
        {
            Stop_bSet.Enabled = FormatChecker.SetInputColor(Stop_tBeepTime, TimeConverter.isValidStringFormat(Stop_tBeepTime.Text));
        }
        private void Stop_CheckBeep_CheckedChanged (object sender, EventArgs e)
        {
            Stop_BeepPanel.Enabled = Stop_CheckBeep.Checked;
        }

        private void Stop_bSet_Click (object sender, EventArgs e)
        {
            Stop_SetTime ();
        }

        private void Stop_SetTime ()
        {
            Time beepTime = TimeConverter.StringToTime (Stop_tBeepTime.Text);
            Stop_beepTimer.Interval = (int)beepTime.Miliseconds;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// MANUAL ADD CODE GOES HERE ///////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void bManualAdd_Click (object sender, EventArgs e)
        {
            try
            {
                Time time = TimeConverter.StringToTime (Manual_tSetTime.Text);
                _selectedActivity.AddTime (time);
            }
            catch(InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given.");
            }
        }
        private void Manual_tSetTime_TextChanged (object sender, EventArgs e)
        {
            Manual_tSetTime_checkInputFormat ();
        }

        private void Manual_tSetTime_checkInputFormat ()
        {
            Manual_bAdd.Enabled = FormatChecker.SetInputColor (Manual_tSetTime, TimeConverter.isValidStringFormat (Manual_tSetTime.Text));
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
                Time habitTime = TimeConverter.StringToTime(Habit_tSetTime.Text);
                _selectedActivity.AddedAsHabit (habitTime);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given. Please give in the following format: hh:mm:ss");
            }
        }

        private void Habit_tSetTime_TextChanged (object sender, EventArgs e)
        {
            Habit_tSetTime_CheckFormat ();
        }

        private void Habit_tSetTime_CheckFormat ()
        {
            Habit_bSetAsHabit.Enabled = FormatChecker.SetInputColor (Habit_tSetTime, TimeConverter.isValidStringFormat (Habit_tSetTime.Text));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// POMODORO CODE GOES HERE /////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        enum Pomod_Status { Idle, Work, Rest };

        Pomod_Status Pomod_status;
        System.Diagnostics.Stopwatch Pomod_stopwatchIdle = new System.Diagnostics.Stopwatch ();
        
        TimerLogic Pomod_TimerWork;
        TimerLogic Pomod_TimerRest;

        Time Pomod_ElapsedWorkTime;
        Time Pomod_ElapsedRestTime;

        private void Pomod_Init ()
        {
            Pomod_ElapsedWorkTime = new Time (0);
            Pomod_ElapsedRestTime = new Time (0);

            Pomod_TimerWork                  = new TimerLogic ();
            Pomod_TimerWork.TimeChangedEvent += Pomod_ChangedWorkTime;
            Pomod_TimerWork.TimerEndedEvent  += Pomod_WorkTimerEnded;

            Pomod_TimerRest                  = new TimerLogic ();
            Pomod_TimerRest.TimeChangedEvent += Pomod_ChangedRestTime;
            Pomod_TimerRest.TimerEndedEvent  += Pomod_RestTimerEnded;

            Pomod_ChangeStatus (Pomod_Status.Idle);
        }

        private void Pomod_bStart_Click (object sender, EventArgs e)
        {
            if (Pomod_TimerWork.isValidTimeSet && Pomod_TimerRest.isValidTimeSet)
            {
                Pomod_ChangeStatus (Pomod_Status.Work);
                Pomod_TimerWork.Start ();
                TimerStartedEvent?.Invoke ();
            }
            else
            {
                MessageBox.Show ("You must specify a valid time first.");
            }
        }

        private void Pomod_ChangedWorkTime ()
        {
            if (Pomod_status == Pomod_Status.Work)
                Pomod_lValueRemainingTime.Text = TimeConverter.TimeToStringMMSS (Pomod_TimerWork.RemainTime);
        }

        private void Pomod_ChangedRestTime ()
        {
            if (Pomod_status == Pomod_Status.Rest)
                Pomod_lValueRemainingTime.Text = TimeConverter.TimeToStringMMSS (Pomod_TimerRest.RemainTime);
        }

        private void Pomod_WorkTimerEnded ()
        {
            Pomod_AddElapsedWorkTime ();
            Pomod_OpenSetEndingDialog ();   //Order is important, SetEnding uses old Status!
            Pomod_ChangeStatus (Pomod_Status.Rest);
            Pomod_TimerRest.Start ();
        }

        private void Pomod_RestTimerEnded ()
        {
            Pomod_AddElapsedRestTime ();
            Pomod_OpenSetEndingDialog ();   //Order is important, SetEnding uses old Status!
            Pomod_ChangeStatus (Pomod_Status.Work);
            Pomod_TimerWork.Start ();
        }

        private void Pomod_OpenSetEndingDialog ()
        {
            Pomod_stopwatchIdle.Stop (); //Pause
            timerEndSoundPlayer.PlaySoundUntilStop ();

            if (Pomod_status == Pomod_Status.Rest)
                MessageBox.Show ("Rest ended, It's time to work, good luck!");
            if (Pomod_status == Pomod_Status.Work)
                MessageBox.Show ("Work ended, It's time to rest, good luck!");

            timerEndSoundPlayer.StopSound ();
            Pomod_stopwatchIdle.Start (); //Continue
        }

        private void Pomod_AddElapsedWorkTime ()
        {
            Pomod_ElapsedWorkTime = new Time (Pomod_ElapsedWorkTime.Seconds + Pomod_TimerWork.GetElapsedTime ().Seconds);
        }

        private void Pomod_AddElapsedRestTime ()
        {
            Pomod_ElapsedRestTime = new Time (Pomod_ElapsedRestTime.Seconds + Pomod_TimerRest.GetElapsedTime ().Seconds);
        }
        
        private void Pomod_bPause_Click (object sender, EventArgs e)
        {
            if (Pomod_bPause.Text == "Pause")
            {
                Pomod_bPause.Text = "Continue";
                Pomod_stopwatchIdle.Start (); //Continue stopwatch
                if (Pomod_status == Pomod_Status.Work)
                    Pomod_TimerWork.Pause ();
                if (Pomod_status == Pomod_Status.Rest)
                    Pomod_TimerRest.Pause ();
            }
            else
            {
                Pomod_bPause.Text = "Pause";
                Pomod_stopwatchIdle.Stop (); //Pause
                if (Pomod_status == Pomod_Status.Work)
                    Pomod_TimerWork.Continue ();
                if (Pomod_status == Pomod_Status.Rest)
                    Pomod_TimerRest.Continue ();
            }
        }
        private void Pomod_bStop_Click (object sender, EventArgs e)
        {
            Pomod_stopwatchIdle.Stop (); //Pause
            TimerStoppedEvent?.Invoke ();

            if(Pomod_status == Pomod_Status.Work) //Adds remaining time to the whole time
            {
                Pomod_ElapsedWorkTime = new Time (Pomod_ElapsedWorkTime.Seconds + Pomod_TimerWork.GetElapsedTime ().Seconds );
                Pomod_TimerWork.Stop ();
            }
            if(Pomod_status == Pomod_Status.Rest)
            {
                Pomod_ElapsedRestTime = new Time (Pomod_ElapsedRestTime.Seconds + Pomod_TimerRest.GetElapsedTime ().Seconds );
                Pomod_TimerRest.Stop ();
            }
            Pomod_ChangeStatus (Pomod_Status.Idle);

            Pomod_OpenSummaryDialog ();

            Pomod_stopwatchIdle.Reset ();
            Pomod_ElapsedRestTime = new Time(0);
            Pomod_ElapsedWorkTime = new Time(0);
        }
        private void Pomod_OpenSummaryDialog ()
        {
            PomodoroSummaryDialog dialog = new PomodoroSummaryDialog ();
            dialog.Initialize (_selectedActivity, 
                               Pomod_ElapsedWorkTime,
                               Pomod_ElapsedRestTime,
                               new Time (Pomod_stopwatchIdle.Elapsed.Seconds));
            dialog.ShowDialog ();
            Pomod_stopwatchIdle.Reset ();
        }
        private void Pomod_bSetWorkTime_Click (object sender, EventArgs e)
        {
            try
            {
                String setTime                 = Pomod_tValueSetWorkTimeMin.Text;
                Pomod_TimerWork.InitTime       = TimeConverter.StringToTime (setTime);
                Pomod_lValueRemainingTime.Text = TimeConverter.TimeToStringMMSS (Pomod_TimerWork.InitTime);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid work time given, please input only minutes");
                Pomod_TimerWork.isValidTimeSet = false; //conversion failed
            }
            CheckValidTimes ();
        }
        private void Pomod_bSetRestTime_Click (object sender, EventArgs e)
        {
            try
            {
                String setTime           = Pomod_tValueSetRestTimeMin.Text;
                Pomod_TimerRest.InitTime = TimeConverter.StringToTime (setTime);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid rest time given, please input only minutes");
                Pomod_TimerRest.isValidTimeSet = false; //conversion failed
            }
            CheckValidTimes ();
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

        private void Pomod_input_TextChanged (object sender, EventArgs e)
        {
            Pomod_input_TextChanged ();
        }

        private void Pomod_input_TextChanged ()
        {
            Pomod_bSetRestTime.Enabled = FormatChecker.SetInputColor (Pomod_tValueSetRestTimeMin, TimeConverter.isValidStringFormat (Pomod_tValueSetRestTimeMin.Text));
            Pomod_bSetWorkTime.Enabled = FormatChecker.SetInputColor (Pomod_tValueSetWorkTimeMin, TimeConverter.isValidStringFormat (Pomod_tValueSetWorkTimeMin.Text));
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
