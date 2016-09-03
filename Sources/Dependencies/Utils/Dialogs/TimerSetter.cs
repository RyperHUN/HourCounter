using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public partial class TimerSetter : Form
    {
        TimeFormatType _timeFormat;
        public TimerSetter ()
        {
            InitializeComponent ();
        }

        public Time ShowDialog (TimeFormatType timeFormatType)
        {
            _timeFormat = timeFormatType;
            SetTimeFormatLabel ();
            DialogResult result = base.ShowDialog ();
            if( result == DialogResult.OK)
                return ParseTime ();
            if( result == DialogResult.Cancel)
                return null;
            return null;
        }

        private void SetTimeFormatLabel ()
        {
            switch (_timeFormat)
            {
                case TimeFormatType.HH_MM_SS:
                    lFormatLabel.Text = "hh:mm:ss";
                    break;
                case TimeFormatType.MM:
                    lFormatLabel.Text = "min";
                    break;
                default:
                    throw new InvalidEnumArgumentException ();
            }
        }

        private void bOk_Click (object sender, EventArgs e)
        {
            try
            {
                Time parsed       = ParseTime ();
                this.DialogResult = DialogResult.OK;
                this.Close ();
            } 
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid time given");
            }
        }

        Time ParseTime ()
        {
            if (_timeFormat == TimeFormatType.HH_MM_SS)
            {
                return TimeConverter.StringToTimeHHMMSS (tTime.Text);
            }
            if (_timeFormat == TimeFormatType.MM)
            {
                return new Time (TimeConverter.ConvertMinToSec (TimeConverter.ConvertStringToLongSafe (tTime.Text)));
            }
            throw new InvalidEnumArgumentException ();
        }

        private void bCancel_Click (object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close ();
        }
    }

    public enum TimeFormatType
    {
        HH_MM_SS,
        MM
    }
}
