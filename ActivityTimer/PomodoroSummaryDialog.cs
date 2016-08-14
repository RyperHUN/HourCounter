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

        public PomodoroSummaryDialog ()
        {
            InitializeComponent ();
        }
        public void Initialize (Activity selectedActivity ,long workTimeSec, long restTimeSec)
        {
            _selectedActivity = selectedActivity;
            _workTimeSec      = workTimeSec;
            _restTimeSec      = restTimeSec;

            tWorkTime.Text = Utils.TimeConverter.TimeToStringHHMMSS (_workTimeSec);
            tRestTime.Text = Utils.TimeConverter.TimeToStringHHMMSS (_restTimeSec);
        }

        private void bCancel_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void bAdd_Click (object sender, EventArgs e)
        { //TODO maybe init guard
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
            {}
        }
    }
}
