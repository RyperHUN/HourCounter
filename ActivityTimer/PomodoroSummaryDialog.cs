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

namespace ActivityTimer
{
    public partial class PomodoroSummaryDialog : Form
    {
        Activity _selectedActivity;
        long _workTimeSec;
        long _restTimeSec;
        long _idleTimeSec;
        bool _isInitialized = false;

        public PomodoroSummaryDialog ()
        {
            InitializeComponent ();
        }
        public void Initialize (Activity selectedActivity ,long workTimeSec, long restTimeSec, long idleTimeSec)
        {
            _isInitialized = true;

            _selectedActivity = selectedActivity;
            _workTimeSec      = workTimeSec;
            _restTimeSec      = restTimeSec;
            _idleTimeSec      = idleTimeSec;

            tWorkTime.Text      = Utils.TimeConverter.TimeToStringHHMMSS (_workTimeSec);
            tRestTime.Text      = Utils.TimeConverter.TimeToStringHHMMSS (_restTimeSec);
            lValueIdleTime.Text = Utils.TimeConverter.TimeToStringHHMMSS (_idleTimeSec);
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
                long elapsedTime = 0;
                if (cIncludeRestTime.Checked )
                {
                    elapsedTime += Utils.TimeConverter.StringToTimeHHMMSS (tRestTime.Text);
                }
                elapsedTime += Utils.TimeConverter.StringToTimeHHMMSS (tWorkTime.Text);
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
