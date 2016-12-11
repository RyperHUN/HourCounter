using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using Utils;

namespace HourCounter
{
    [Serializable]
    public class Activity : Observable, ISerializable
    {
        /// TODO Kellene valami keresés amivel meglehet találni az egyes activityket

        private string _name = null; // Stores the activity name
        public  string Name { get { return _name; } private set { } } // Only can be viewed
        private SortedList<string, Activity> _subActivities = new SortedList<string, Activity>(); //Stores all the subActivities
        public  SortedList<string, Activity> GetSubActivityList() { return _subActivities; }

        private static Dictionary<Activity, Time> _habitContainer = new Dictionary<Activity, Time>(); //Stores who is habit and who is not.
        public Dictionary<Activity, Time> GetHabitList () { return _habitContainer; }

        private bool _isHabit = false;
        public bool IsHabit { get { return _isHabit; } private set { } }

        private static bool _isDateSettingOn = false;

        private Time _spentOnActivity;
        private SortedList<OnlyDate,Time> _dailyTime = new SortedList<OnlyDate, Time>();
        public void GetObjectData (SerializationInfo info, StreamingContext context)
        {
            info.AddValue ("0", _name);
            info.AddValue ("1", _isHabit);
            info.AddValue ("UpdatedTime323", _spentOnActivity);
            info.AddValue ("3", _subActivities);
            info.AddValue ("HabitContainer191923", _habitContainer);
            info.AddValue ("_isHabit1281263", _isHabit);
        }
        protected Activity (SerializationInfo info, StreamingContext context)
        {
            _name    = info.GetString ("0");
            _isHabit = info.GetBoolean ("1");
            _subActivities = (SortedList<string, Activity>)info.GetValue ("3", typeof (SortedList<string, Activity>));
            try
            { //New attributes can be added here <- If they are not exist EXCEPTION
                _habitContainer = (Dictionary <Activity, Time>)info.GetValue ("HabitContainer191923", typeof (Dictionary<Activity, Time>));
            }
            catch (SerializationException exception)
            {
                string exceptionStr = exception.ToString ();
                if (exceptionStr.Contains ("not found") && exceptionStr.Contains ("HabitContainer191923"))
                {
                    //Found which variable
                    _habitContainer = new Dictionary<Activity, Time> ();
                }
            }
            try
            { //New attributes can be added here <- If they are not exist EXCEPTION
                _isHabit = info.GetBoolean ("_isHabit1281263");
            }
            catch (SerializationException exception)
            {
                string exceptionStr = exception.ToString ();
                if (exceptionStr.Contains ("not found") && exceptionStr.Contains ("_isHabit1281263"))
                {
                    //Found which variable
                    _isHabit = false;
                }
            }
            bool loadedTime = false;
            try
            {
                _spentOnActivity = (Time)info.GetValue ("UpdatedTime323", typeof(Time));  //Newer time version
                loadedTime = true;
            }
            catch (SerializationException /*exception*/){/*nop*/}
            try
            {
                _spentOnActivity = new Time (TimeConverter.ConvertMinToSec((long)info.GetValue ("2", typeof(long)))); // Old version compatibility
                loadedTime = true;
            }
            catch (SerializationException /*exception*/)
            {
                if (!loadedTime) //If full file load was unsucessful
                    throw;
            }
            
        }
    //Vegigmegy az osszes subActivityn es hozzáadja az ő idejüket a Counterhez, és ezt fogja visszaadni mint össz idő.
        public Time Counter
        {
            get
            {
                Time sumSpent = _spentOnActivity;
                foreach (var de in _subActivities)
                {
                    Activity ac = (Activity)de.Value;
                    sumSpent = new Time(sumSpent.Seconds + ac.Counter.Seconds);
                }
                return sumSpent;
            }
            private set {; }
        } // Only can be viewed

        /// TODO
        //public Time CounterDate (OnlyDate from, OnlyDate to)
        //{
        //    Time sumSpent = _spentOnActivity;
        //    foreach (var de in _subActivities)
        //    {
        //        Activity ac = (Activity)de.Value;
        //        sumSpent = new Time(sumSpent.Seconds + ac.Counter.Seconds);
        //    }
        //    return sumSpent;
        //}
        ///TODO Test
        public Time CounterDate (OnlyDate date)
        {
            Time sumSpent = new Time(0);
            if (_dailyTime.TryGetValue (date,out sumSpent))
            {
                foreach (var de in _subActivities)
                {
                    Activity ac = (Activity)de.Value;
                    sumSpent = new Time (sumSpent.Seconds + ac.CounterDate(date).Seconds);
                }
                return sumSpent;
            }
            return new Time (0);
        }
        private static OnlyDate _savedDate = null;
        public void notifySelectedDate ()
        {
            _isDateSettingOn = false;
            updateAllViews ();
        }

        public void notifySelectedDate (DateTime date)
        {
            _isDateSettingOn = true;
            _savedDate = new OnlyDate (date);
            updateAllViews ();
        }

        public Activity(String name)
        {
            _name = name;
            _spentOnActivity = new Time(0);
        }
        public Activity (String name,long minutesSpentOnActivity)
        {
            _name = name;
            _spentOnActivity = new Time(TimeConverter.ConvertMinToSec(minutesSpentOnActivity));
        }

        // Adds subactivity to the activity list 
        public void AddSubActivity(Activity subActivity)
        {
            _subActivities.Add(subActivity.Name, subActivity);
            updateAllViews();
        }
        public LinkedList<String> GetListStringIndentation(Activity startActivity, String tab)
        {
            SortedList<string, Activity> subActivities = startActivity.GetSubActivityList();
            if (subActivities.Count == 0) //No more activities
                return null;
            LinkedList<String> activityStringList = new LinkedList<string>();

            foreach(var dict in subActivities)
            {
                string activityName = dict.Key;
                activityStringList.AddLast(tab + activityName);

                Activity subActivity = dict.Value;
                LinkedList<String> subList = GetListStringIndentation(subActivity, tab + "  ");
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
            if (_isDateSettingOn)
                return _name + "    " + CounterDate (_savedDate).Hours + "h";
            else
                return _name + "    " + Counter.Hours + "h";
        }
        public static string removeFormat (string formated)
        {
            string pattern      = @"    [0-9]*h";
            string replacement  = "";
            string result       = Regex.Replace (formated,pattern,replacement);

            return result;
        }
        public void AddBelowActivity (Activity rootActivity,Activity newActivity, string searchForActivity)
        {
            Activity activity = Find(rootActivity, searchForActivity);
            if (activity != null)
                activity.AddSubActivity(newActivity);

            updateAllViews ();
        }
        /// Returns activity if found, else null
        public Activity Find (Activity rootActivity,string searchForActivity)
        {
            SortedList<string, Activity> subActivities = rootActivity.GetSubActivityList ();
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
        public Activity FindParent (Activity rootActivity, string searchForActivity)
        {
            SortedList<string, Activity> subActivities = rootActivity.GetSubActivityList ();
            if (subActivities.Count == 0)
                return null;

            foreach (var dict in subActivities)
            {
                String activityName = dict.Key;
                Activity activity = dict.Value;
                if (activityName == searchForActivity)
                    return rootActivity;
                Activity act = activity.Find(activity, searchForActivity);
                if (act != null )//&& act.Name != "INIT")//&& act.Find(act,searchForActivity) != null) //If child is
                    return act;
            }

            return null;
        }
        private bool remove (Activity rootActivity,string searchForActivity)
        {
            SortedList<string, Activity> subActivities = rootActivity.GetSubActivityList ();
            if (subActivities.Count == 0)
                return false;

            foreach (var dict in subActivities)
            {
                String activityName = dict.Key;
                Activity activity = dict.Value;
                if (activityName == searchForActivity)
                {
                    subActivities.Remove (activityName);
                    updateAllViews ();
                    return true;
                }
                bool founded = activity.Remove(activity, searchForActivity);
                if (founded == true)
                    return true;
            }

            return false;
        }
        public bool Remove (Activity rootActivity, string searchForActivity)
        {
            bool found = remove (rootActivity, searchForActivity);
            updateAllViews ();
            return found;
        }
        public void AddTime (Time time)
        {
            _spentOnActivity = new Time(_spentOnActivity.Seconds + time.Seconds);
            Time todayTime = new Time(0);
            OnlyDate today = new OnlyDate(DateTime.Now); ///TODO only add for today, or add for selected?
            if (_dailyTime.TryGetValue (today, out todayTime))
            {
                _dailyTime.Add(today, new Time (todayTime.Seconds + time.Seconds));
            }
            else
            {
                _dailyTime.Add(today, new Time (time.Seconds));
            }

            updateAllViews ();
        }
        public Time GetHabitTime ()
        {
            if(IsHabit)
            {
                return _habitContainer[this];
            }
            return null;
        }
        public void AddedAsHabit (Time time)
        {
            if (_habitContainer.ContainsKey (this))
            {
                throw new ArgumentException ("Key is already used");
            }
            else
            {
                _isHabit = true;
                _habitContainer.Add (this, time);
                updateAllViews ();
            }
        }
        public void RemovedAsHabit ()
        {
            _isHabit = false;
            _habitContainer.Remove (this);
            updateAllViews ();
        }
    }
}