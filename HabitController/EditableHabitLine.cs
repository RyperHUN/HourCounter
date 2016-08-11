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
        public  bool Status
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
        }

        private void bAdd_Click (object sender, EventArgs e)
        {
            _isAdding    = true;
            lStatus.Text = "Status: Adding";
            //TODO Maybe set green color 
        }

        private void bDoNothing_Click (object sender, EventArgs e)
        {
            _isAdding    = false;
            lStatus.Text = "Status: Do nothing";
        }

        private long GetCalculatedTime ()
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
    }
}
