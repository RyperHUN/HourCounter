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

namespace DetailedView
{
    public partial class DetailedView : UserControl, Observer
    {
        Activity _selectedActivity  = null;
        Activity _activityContainer = null;
        public DetailedView ()
        {
            InitializeComponent ();
        }
        //Update name and time
        public void update ()
        {
            if (_selectedActivity != null)
            {
                updateName ();
                updateHabitData ();
            }
        }
        public void InitializeActivityContainer (Activity activityContainer)
        {
            _activityContainer = activityContainer;
        }
        public void updateName ()
        {
            lActivityName.Text = _selectedActivity.Name;

            long minutesSpentOnActivity = _selectedActivity.Counter;

            long hours   = minutesSpentOnActivity / 60;
            minutesSpentOnActivity %= 60;
            long minutes = minutesSpentOnActivity;

            string timeWithActivityString = hours + "h " + minutes + "m";
            lTimeSpentOnActivity.Text = timeWithActivityString;
            this.Visible = true;
        }

        public void updateHabitData ()
        {
            const string HabitUnitSuffix = "min/day";
            Time habitTime = new Time (0);
            if ( _selectedActivity.IsHabit)
                habitTime = _selectedActivity.GetHabitTime ();

            lValueHabitTimeMin.Text = habitTime.Minutes + HabitUnitSuffix;
        }

        public void setSelectedActivity (Activity selectedActivity)
        {
            _selectedActivity = selectedActivity;
            update ();
        }
        //Simple enable ON/OFF
        public void timerStartedHandler ()
        {
            this.Enabled = false;
        }
        public void timerStoppedHandler ()
        {
            this.Enabled = true;
        }

        private void bRemoveActivity_Click (object sender, EventArgs e)
        {
            new Dialogs.RemoveActivity (_activityContainer, _selectedActivity);
        }

        private void bMove_Click (object sender, EventArgs e)
        {
            new Dialogs.MoveActivity (_activityContainer, _selectedActivity).ShowDialog ();
        }
    }
}
