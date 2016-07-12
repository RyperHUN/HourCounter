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

namespace DetailedView
{
    public partial class DetailedView : UserControl, Observer
    {
        Activity _selectedActivity = null;
        public DetailedView ()
        {
            InitializeComponent ();
        }
        //Update name and time
        public void update ()
        {
            if (_selectedActivity != null)
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
        }

        public void setSelectedActivity (Activity selectedActivity)
        {
            _selectedActivity = selectedActivity;
            update ();
        }
    }
}
