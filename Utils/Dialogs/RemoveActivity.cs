using HourCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public class RemoveActivity
    {
        public RemoveActivity (Activity activityContainer, Activity selectedActivity)
        {
            DialogResult result = MessageBox.Show ("Are you sure you want to remove this habit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                activityContainer.Remove (activityContainer, selectedActivity.Name);
            }
        }
    }
}
