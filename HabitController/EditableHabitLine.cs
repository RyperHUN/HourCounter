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
        
        public EditableHabitLine ()
        {
            InitializeComponent ();
        }

        public void Initialize (Activity selectedActivity,long calculatedTime)
        {
            _selectedActivity   = selectedActivity;
            lActivityName.Text  = _selectedActivity.Name;
            string stringTime   = TimeConverter.timeToString (calculatedTime);
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
            SetStatusAdding ();
        }

        private void bDoNothing_Click (object sender, EventArgs e)
        {
            SetStatusDoNothing ();
        }

        private long GetCalculatedTime () //Todo maybe handle time when clicking add
        {
            try
            {
                long convertedTime = TimeConverter.stringToTime (tAddingTime.Text);
                return convertedTime;
            }
            catch (InvalidOperationException /*exc*/)
            {}
            return 0;
        }
        public void HandleAdding ()
        {
            if (IsAdding)
            {
                _selectedActivity.AddTime (GetCalculatedTime ());
            }
        }
    }
}
