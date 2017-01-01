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
using System.Globalization;

namespace DayChooser
{
    public partial class DayChooser : UserControl
    {
        Activity _activityContainer;
        private readonly String[] DateFormatString = { "yyyy.MM.dd", "yyyy.M.d", "yyyy.MM.d", "yyyy.M.dd" };
        Color originalTextBackground;
        DateTime from, to;
        public DayChooser ()
        {
            InitializeComponent ();
            radioCustom.Enabled = true;
            originalTextBackground = Color.White;
            textFrom.Text = DateTime.Now.ToString(DateFormatString[0]);
            textTo.Text   = textFrom.Text;
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
            else 
                UpdateRadioCustom ();
        }

        private void UpdateRadioCustom ()
        {
            if (radioCustom.Checked)
            {
                if (radioCustom.Enabled == false)
                    radioAll.Checked = true;
                else
                    _activityContainer.notifySelectedDate (new OnlyDate (from), new OnlyDate (to));
            }
        }

        private void IntervalTextChanged (object sender, EventArgs e)
        {
            if (FormatChecker.SetInputColor (textFrom, DateTime.TryParseExact (textFrom.Text, DateFormatString, CultureInfo.InvariantCulture,DateTimeStyles.None, out from)) &&
                FormatChecker.SetInputColor (textTo, DateTime.TryParseExact (textTo.Text, DateFormatString, CultureInfo.InvariantCulture,DateTimeStyles.None, out to))
                )
            {
                radioCustom.Enabled = true;
                UpdateRadioCustom ();
                return;
            }
            else
                radioCustom.Enabled = false;
        }

        public void Disable ()
        {
            radioAll.Checked = true;
            this.Enabled = false;
        }
    }
}
