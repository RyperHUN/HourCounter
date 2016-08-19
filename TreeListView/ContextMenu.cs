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
        public TreeContextMenu (Activity activityContainer)
        {
            _activityContainer = activityContainer;
            
            MenuItems.Add ("Add child Activity", MenuAddChildActivity);
            MenuItems.Add ("Remove", MenuRemoveActivity);
            MenuItems.Add ("Move", MenuMoveActivity);
        }
        
        private void MenuAddChildActivity (object sender,EventArgs e)
        {

        }
        private void MenuRemoveActivity (object sender, EventArgs e)
        {

        }
        private void MenuMoveActivity (object sender, EventArgs e)
        {

        }
    }
}
