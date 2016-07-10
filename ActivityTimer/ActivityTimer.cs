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
    public partial class ActivityTimer : UserControl
    {
        private Activity _activityContainer;
        private long _remainingTimeSeconds;
        private long _startingTimeSeconds;
        public ActivityTimer()
        {
            InitializeComponent();
            tabPicker.Dock = DockStyle.Fill;
            timerSecond.Interval = 1000; // 1 sec
        }
        public void setActivityContainer(Activity activityContainer)
        {
            _activityContainer = activityContainer;
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
            timerSecond.Start();
            bSet.Enabled = false;
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            _remainingTimeSeconds--;
            if (_remainingTimeSeconds == 0)
            {
                timerSecond.Stop();
                ///TODO
                //Play sound??
                //Add time to activity
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                //player.Play();
            }
            lRemainingTime.Text = TimeConverter.timeToString (_remainingTimeSeconds);
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

                string result = hour + ":" + min + ":" + sec;

                return result;
            }
        }

        private void bPause_Click (object sender, EventArgs e)
        {
            if(bPause.Text == "Pause")
            {
                bPause.Text = "Continue";
                timerSecond.Stop ();
            }
            else
            {
                bPause.Text = "Pause";
                timerSecond.Start ();
            }
        }

        private void bStop_Click (object sender, EventArgs e)
        {
            bSet.Enabled = true;
            timerSecond.Stop ();
            long elapsedTimeSeconds = _startingTimeSeconds - _remainingTimeSeconds;
            ///TODO Update activity
        }
    }

    
}
