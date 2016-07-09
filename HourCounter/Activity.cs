using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HourCounter
{
    [Serializable]
    public class Activity : Observable
    {
        /// TODO Kellene valami keresés amivel meglehet találni az egyes activityket

        private string _name = null; // Stores the activity name
        public string Name { get { return _name; } private set { } } // Only can be viewed
        private SortedList<string, Activity> _subActivities = new SortedList<string, Activity>(); //Stores all the subActivities
        public SortedList<string, Activity> GetList() { return _subActivities; }

        private long _minutesSpentOnActivity;
        //Vegigmegy az osszes subActivityn es hozzáadja az ő idejüket a Counterhez, és ezt fogja visszaadni mint össz idő.
        public long Counter
        {

            get
            {
                long sumMinutesSpent = _minutesSpentOnActivity;
                foreach (var de in _subActivities)
                {
                    Activity ac = (Activity)de.Value;
                    sumMinutesSpent += ac.Counter;
                }
                return sumMinutesSpent;
            }
            private set {; }
        } // Only can be viewed

        public Activity(String name)
        {
            _name = name;
            _minutesSpentOnActivity = 0;
        }
        public Activity(String name,long minutesSpentOnActivity)
        {
            _name = name;
            _minutesSpentOnActivity = minutesSpentOnActivity;
        }

        // Adds subactivity to the activity list 
        public void AddSubActivity(Activity subActivity)
        {
            _subActivities.Add(subActivity.Name, subActivity);
            updateAllViews(); ///TODO Ott is updatelni kell majd ahol inkrementálja egy activity idejét!!!!!
        }
        public LinkedList<String> GetListStringFormated(Activity startActivity, String tab)
        {
            SortedList<string, Activity> subActivities = startActivity.GetList();
            if (subActivities.Count == 0) //No more activities
                return null;
            LinkedList<String> activityStringList = new LinkedList<string>();

            foreach(var dict in subActivities)
            {
                string activityName = dict.Key;
                activityStringList.AddLast(tab + activityName);

                Activity subActivity = dict.Value;
                LinkedList<String> subList = GetListStringFormated(subActivity, tab + "  ");
                if(subList != null)
                {
                    foreach (String subSubActivityName in subList)
                    {
                        activityStringList.AddLast(subSubActivityName);
                    }
                } 
            }

            return activityStringList;
        }

        public string getFormatedStatus()
        {
            return _name + "    " + (Counter / 60) + "h";
        }
        public void AddBelowActivity (Activity rootActivity,Activity newActivity, string searchForActivity)
        {
            Activity activity = Find(rootActivity, searchForActivity);
            if (activity != null)
                activity.AddSubActivity(newActivity);

            updateAllViews ();
        }
        public Activity Find (Activity rootActivity,string searchForActivity)
        {
            SortedList<string, Activity> subActivities = rootActivity.GetList ();
            if (subActivities.Count == 0)
                return null;

            foreach(var dict in subActivities)
            {
                String activityName = dict.Key;
                Activity activity = dict.Value;
                if (activityName == searchForActivity)
                    return activity;
                Activity act = activity.Find(activity, searchForActivity);
                if (act != null && act.Name == searchForActivity)
                    return act;
            }

            return null;
        }
    }
}