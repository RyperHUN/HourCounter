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

namespace HabitUtils
{
    public partial class EditableHabitLine : UserControl
    {
        private Activity _selectedActivity;
        private bool _isAdding = false;
        public  bool IsAdding
        {
            get { return _isAdding; }
            private set { ; }
        }
        private long calculatedTime = 0;
        
        public EditableHabitLine ()
        {
            InitializeComponent ();
        }

        public void Initialize (Activity selectedActivity,long calculatedTime)
        {
            _selectedActivity   = selectedActivity;
            lActivityName.Text  = _selectedActivity.Name;
            string stringTime   = TimeConverter.TimeToStringHHMMSS (calculatedTime);
            tAddingTime.Text    = stringTime;

            SetStatusDoNothing ();
        }

        private void SetStatusAdding ()
        {
            _isAdding = true;
            lStatus.Text = "Status: Adding";
            lStatus.ForeColor = Color.Green;
        }

        private void SetStatusDoNothing ()
        {
            _isAdding = false;
            lStatus.Text = "Status: Do nothing";
            lStatus.ForeColor = Color.Red;
        }

        private void bAdd_Click (object sender, EventArgs e)
        {
            try
            { 
                calculatedTime = GetCalculatedTime ();
            }
            catch (InvalidOperationException /*exc*/)
            {
                SetStatusDoNothing ();
                return;
            }
            SetStatusAdding ();
        }

        private void bDoNothing_Click (object sender, EventArgs e)
        {
            SetStatusDoNothing ();
        }

        private long GetCalculatedTime () 
        {
            try
            {
                long convertedTime = TimeConverter.StringToTimeHHMMSS (tAddingTime.Text);
                return convertedTime;
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show ("Invalid string argument given. Please give in the following format: hh:mm:ss");
                throw exc;
            }
        }

        public void HandleAdding ()
        {
            if (IsAdding)
            {
                _selectedActivity.AddTime (calculatedTime);
            }
        }
    }
}
