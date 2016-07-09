using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HourCounter
{
    [Serializable]
    public class Activity
    {
        /// TODO Kellene valami keresés amivel meglehet találni az egyes activityket

        private string _name = null; // Stores the activity name
        public string Name { get { return _name; } private set { } } // Only can be viewed
        private SortedList<string,Activity> subActivities = new SortedList<string, Activity>(); //Stores all the subActivities
        public SortedList<string, Activity> GetList() { return subActivities; }

        private long minutesSpentOnActivity;
        //Vegigmegy az osszes subActivityn es hozzáadja az ő idejüket a Counterhez, és ezt fogja visszaadni mint össz idő.
        public long Counter 
        {

            get
            {
                long sumMinutesSpent = minutesSpentOnActivity;
                foreach(var de in subActivities)
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
            minutesSpentOnActivity = 0;
        }
        
        // Adds subactivity to the activity list 
        public void AddSubActivity(Activity subActivity)
        {
            subActivities.Add(subActivity.Name,subActivity);
        }
        public string getFormatedStatus()
        {
            return _name + "    " + (Counter / 60) + "h";
        }
    }
}