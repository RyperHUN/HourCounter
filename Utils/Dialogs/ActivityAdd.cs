using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HourCounter;

namespace Dialogs
{
    public partial class ActivityAdd : Form
    {
        private Activity _activityContainer;
        public ActivityAdd (Activity activityContainer)
        {
            _activityContainer = activityContainer;
            InitializeComponent ();
            fillComboBox();
        }

        private void fillComboBox ()
        {
            LinkedList<String> comboItems = _activityContainer.GetListStringFormated(_activityContainer, "");
            if (comboItems != null)
            {
                foreach (String item in comboItems)
                {
                    comboActivityDropDown.Items.Add (item);
                }
            }
        }

        public void SetDefaultParent (Activity parent)
        {
            foreach(String comboBoxText in comboActivityDropDown.Items)
            {
                string activityName = comboBoxText.Trim (); //Removes formating
                if(activityName == parent.Name)
                {
                    comboActivityDropDown.SelectedItem = comboBoxText;
                    radioSubActivity.Select ();
                }
            }
        }

        private void radioSubActivity_CheckedChanged (object sender, EventArgs e)
        {
            comboActivityDropDown.Enabled = !comboActivityDropDown.Enabled; 
        }

        private void bAdd_Click (object sender, EventArgs e)
        {
            String activityName = tActivityName.Text;
            long timeSpentMin = 0;
            if(!IsValidArgumentsGivenForAdd (activityName, out timeSpentMin))
                return;

            Activity newActivity = new Activity (activityName, timeSpentMin);
            if (radioMainActivity.Checked)
            {
                 _activityContainer.AddSubActivity (newActivity);
            }
            else
            {
                string searchForParentActivity = (string)comboActivityDropDown.SelectedItem;
                searchForParentActivity        = searchForParentActivity.Trim(); //Remove spaces before activity ( tab )
                _activityContainer.AddBelowActivity(_activityContainer, newActivity, searchForParentActivity);
            }
            this.Close ();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsValidArgumentsGivenForAdd (string activityName, out long timeSpentMin)
        {
            timeSpentMin = 0;
            try
            {
                timeSpentMin = Utils.TimeConverter.ConvertStringToLongSafe (tTimeSpent.Text);
            }
            catch (InvalidOperationException /*exc*/)
            {
                MessageBox.Show ("Invalid string argument given. Please only fill the textbox with numbers");
                return false;
            }
            if (activityName == "")
            {
                MessageBox.Show ("Name cannot be empty");
                return false;
            }
            if (_activityContainer.Find (_activityContainer, activityName) != null)
            {
                MessageBox.Show ("Activity name already exists");
                return false;
            }
            return true;
        }
    }
}
