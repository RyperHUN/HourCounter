using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HourCounter
{
    public class ActivityContainer : Observable
    {
        private SortedList<string, Activity> Activities = new SortedList<string, Activity>();
        //Adding new activity to the list
        public void addActivity(Activity activity)
        {
            Activities.Add(activity.Name, activity);
        }
        public SortedList<string, Activity> GetList() { return Activities; }
    }
}