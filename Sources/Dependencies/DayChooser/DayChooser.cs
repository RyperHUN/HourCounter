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

namespace DayChooser
{
    public partial class DayChooser : UserControl
    {
        Activity _activityContainer;
        public DayChooser ()
        {
            InitializeComponent ();
        }

        public void SetActivityContainer (Activity container) { _activityContainer = container; }

        private void CheckedChanged (object sender, EventArgs e)
        {
            if (radioAll.Checked)
                _activityContainer.notifySelectedDate ();
            else if (radioToday.Checked)
                _activityContainer.notifySelectedDate (DateTime.Now);
            else if (radioYesterday.Checked)
                _activityContainer.notifySelectedDate (DateTime.Now.AddDays (-1));
            else if (radioAllWeek.Checked)
                _activityContainer.notifySelectedDate (DateTime.Now.AddDays (-7), DateTime.Now);
        }
    }
}
