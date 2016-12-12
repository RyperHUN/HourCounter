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
                _activityContainer.notifySelectedDate (null, null);
            else if (radioToday.Checked)
                _activityContainer.notifySelectedDate (new OnlyDate (DateTime.Now), null);
            else if (radioYesterday.Checked)
                _activityContainer.notifySelectedDate (new OnlyDate (DateTime.Now.AddDays (-1)), null);
            else if (radioAllWeek.Checked)
                _activityContainer.notifySelectedDate (new OnlyDate (DateTime.Now.AddDays (-7)), new OnlyDate (DateTime.Now));
        }
    }
}
