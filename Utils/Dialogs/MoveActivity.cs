using HourCounter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class MoveActivity : Form
    {
        Activity _activityContainer;
        Activity _selectedActivity;
        public MoveActivity (Activity activityContainer, Activity selectedActivity)
        {
            InitializeComponent ();
            _activityContainer = activityContainer;
            _selectedActivity  = selectedActivity;

            fillComboBox ();
        }
        private void fillComboBox ()
        {
            LinkedList<String> comboItems = _activityContainer.GetListStringFormated(_activityContainer, "");
            if (comboItems != null)
            {
                foreach (String item in comboItems)
                {
                    if(item.Trim () != _selectedActivity.Name) //Does not add the selected activity, move to the same place is unneccesary
                        comboBox.Items.Add (item);
                }
            }
        }

        private void bCancel_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void bMove_Click (object sender, EventArgs e)
        {
            if(comboBox.SelectedItem == null)
            {
                MessageBox.Show ("You have to select an item"); //Maybe throw exception?!
                return;
            }
            _activityContainer.Remove (_activityContainer, _selectedActivity.Name);

            string SearchForParentActivity = (string)comboBox.SelectedItem;
            SearchForParentActivity        = SearchForParentActivity.Trim (); //Remove spaces before activity ( tab )
            _activityContainer.AddBelowActivity (_activityContainer, _selectedActivity, SearchForParentActivity);

            this.Close ();
        }
    }
}
