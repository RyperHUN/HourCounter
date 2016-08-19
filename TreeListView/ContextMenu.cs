using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HourCounter;

namespace TreeListView
{
    internal class TreeContextMenu : ContextMenu
    {
        private Activity _activityContainer;
        private Activity _selectedActivity;
        public TreeContextMenu (Activity activityContainer, string selectedActivityName)
        {
            _activityContainer = activityContainer;
            _selectedActivity  = _activityContainer.Find (_activityContainer, selectedActivityName);

            MenuItems.Add ("Add child Activity", MenuAddChildActivity);
            MenuItems.Add ("Remove", MenuRemoveActivity);
            MenuItems.Add ("Move", MenuMoveActivity);
        }
        
        private void MenuAddChildActivity (object sender,EventArgs e)
        {
            Utils.ActivityAdd activityAdd = new Utils.ActivityAdd (_activityContainer);
            activityAdd.SetDefaultParent (_selectedActivity);
            activityAdd.ShowDialog ();
        }
        private void MenuRemoveActivity (object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show ("Are you sure you want to remove this habit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _activityContainer.Remove (_activityContainer, _selectedActivity.Name);
            }
        }
        private void MenuMoveActivity (object sender, EventArgs e)
        {

        }
    }
}
