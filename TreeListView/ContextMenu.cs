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
            Dialogs.ActivityAdd activityAdd = new Dialogs.ActivityAdd (_activityContainer);
            activityAdd.SetDefaultParent (_selectedActivity);
            activityAdd.ShowDialog ();
        }
        private void MenuRemoveActivity (object sender, EventArgs e)
        {
            new Dialogs.RemoveActivity (_activityContainer, _selectedActivity);
        }
        private void MenuMoveActivity (object sender, EventArgs e)
        {
            new Dialogs.MoveActivity (_activityContainer, _selectedActivity).ShowDialog ();
        }
    }
}
