using HourCounter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace ActivityTimer
{
    public partial class PomodoroSummaryDialog : Form
    {
        Activity _selectedActivity;
        Time _workTime;
        Time _restTime;
        Time _idleTime;
        bool _isInitialized = false;

        public PomodoroSummaryDialog ()
        {
            InitializeComponent ();
        }
        public void Initialize (Activity selectedActivity ,Time workTime, Time restTime, Time idleTime)
        {
            _isInitialized = true;

            _selectedActivity = selectedActivity;
            _workTime         = workTime;
            _restTime         = restTime;
            _idleTime         = idleTime;

            tWorkTime.Text      = Utils.TimeConverter.TimeToStringHHMMSS (_workTime);
            tRestTime.Text      = Utils.TimeConverter.TimeToStringHHMMSS (_restTime);
            lValueIdleTime.Text = Utils.TimeConverter.TimeToStringHHMMSS (_idleTime);
        }

        private void bCancel_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void bAdd_Click (object sender, EventArgs e)
        { 
            Utils.Security.InitializationGuard (_isInitialized);
            try
            {
                Time elapsedTime = new Time();
                if (cIncludeRestTime.Checked )
                {
                    elapsedTime = TimeConverter.StringToTimeHHMMSS (tRestTime.Text);
                }
                elapsedTime = new Time (elapsedTime.Seconds + TimeConverter.StringToTimeHHMMSS (tWorkTime.Text).Seconds);
                _selectedActivity.AddTime (elapsedTime);
                
                this.Close ();
            }
            catch ( InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given. Please give in the following format: hh:mm:ss");
            }
        }
    }
}
