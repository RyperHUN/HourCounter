using HourCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeListView
{
    //Ez egy olyan nézet lesz amibe megjelennek a tevékenységek, és mellettük külön oszlopba az eltöltött óra
    public class TreeListView : TreeView, Observer
    {
        private Activity activityContainer;
        public  delegate void SelectChangeHandler (Activity ac);
        public  event SelectChangeHandler SelectChanged;
        
        public TreeListView ()
        {
        }
        public void addActivityContainer (Activity ac)
        {
            activityContainer = ac;
            BuildTree ();
        }
        void BuildTree ()
        {
            this.Nodes.Clear ();
            SortedList<string,Activity> activities = activityContainer.GetList();
            foreach (var dict in activities)
            {
                Activity activity = dict.Value;
                TreeNode Root = new TreeNode(activity.getFormatedStatus());
                LinkedList<TreeNode> childs = GetChilds(activity);

                if (childs != null)
                {
                    foreach (var childNode in childs)
                    {
                        Root.Nodes.Add (childNode);
                    }
                }

                this.Nodes.Add (Root);
            }
            this.ExpandAll ();
        }
        LinkedList<TreeNode> GetChilds (Activity activity)
        {
            LinkedList<TreeNode> treeNodes = new LinkedList<TreeNode>();
            SortedList<string, Activity> activities = activity.GetList();
            if (activities.Count == 0)
                return null; //Recursion end if no more childs

            foreach (var dict in activities)
            {
                Activity childActivity = dict.Value;
                TreeNode ChildNode = new TreeNode(childActivity.getFormatedStatus());
                LinkedList<TreeNode> childChildNodes = GetChilds(childActivity);
                if (childChildNodes != null)// Ha vannak még gyerekek
                {
                    foreach (var childChildNode in childChildNodes)
                        ChildNode.Nodes.Add (childChildNode);
                }
                treeNodes.AddLast (ChildNode);
            }

            return treeNodes;
        }
        public void update ()
        {
            BuildTree ();
        }
        public void SelectChangedFunction (Activity activity)
        {
            if(SelectChanged != null)
                SelectChanged (activity);
        }
        //Simple enable ON/OFF
        public void timerStartedHandler ()
        {
            this.Enabled = false;
        }
        public void timerStoppedHandler ()
        {
            this.Enabled = true;
        }
    }
}
