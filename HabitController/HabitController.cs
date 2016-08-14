using HourCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitUtils
{
    //YOU HAVE TO START THE CONTROLLER MANUALLY
    /// -> InitAndStart ()
	[Serializable]
    public class HabitController : ISerializable
    {
        private Activity _activityContainer = null;
        private DateTime _lastTestedTime = DateTime.MinValue;
		//private Dictionary<Activity, bool> _whatIsAdded = new Dictionary<Activity, bool>(); //Maybe later
        private Timer    _hourCounterTimer;
		private bool     _isInitialized = false;
		
        public HabitController (Activity activityContainer)
        {
            InitVariables (activityContainer);
        }
		//Serialization
		protected HabitController (SerializationInfo info, StreamingContext context)
        {
			_lastTestedTime = (DateTime)info.GetValue ("DateTime_lastTestedTime99", typeof (DateTime));
		}
		public void GetObjectData (SerializationInfo info, StreamingContext context)
        {
            info.AddValue ("DateTime_lastTestedTime99", _lastTestedTime);
        }
		//Serialization done
		//Initializations
		public void InitVariables (Activity activityContainer)
		{
			_isInitialized     = true;
			_activityContainer = activityContainer;
			_hourCounterTimer  = new Timer ();
            _hourCounterTimer.Interval = 3600000; //1 hour
            _hourCounterTimer.Tick += hourCounter_Tick;
			if (_lastTestedTime == DateTime.MinValue)
			{
				DateTime yesterday = DateTime.Now.AddDays (-1);
				_lastTestedTime = yesterday;
			}
		}
		
		public void InitAndStart (Activity activityContainer)
		{
			InitVariables (activityContainer);
			StartController ();
		}
        public void StartController ()
        {
			Utils.Security.InitializationGuard (_isInitialized);

            HabitTimeAdderLogic ();
            _hourCounterTimer.Start ();
        }
		//InitDone
        private void hourCounter_Tick (object sender, EventArgs e)
        {
            HabitTimeAdderLogic ();
        }
		public void OpenHabbitAdderDialog ()
		{
            Utils.Security.InitializationGuard (_isInitialized);

            HabitAdderDialog dialog = new HabitAdderDialog ();
            dialog.Initialize (CreateElapsedHabitTimes ());
            dialog.ShowDialog ();
		}
        private void HabitTimeAdderLogic ()
        {
			if (IsTodayAlreadyAdded ())
            {
                //_hourCounterTimer.Stop ();
				//OpenHabbitAdderDialog (); 
                return;
            }
            else
            {
                if(_activityContainer.GetHabitList ().Count == 0) // If there is no habit don't show the dialog
                    return;

				_hourCounterTimer.Stop (); //There will be no duplicated messages if no respond for another thick
                DialogResult result = MessageBox.Show ("Do you want to add habbits now?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _lastTestedTime = DateTime.Now;
                    OpenHabbitAdderDialog ();
                }
				else if (result == DialogResult.No)
				{
					_hourCounterTimer.Start (); ///TODO Test if it is a problem if start is duplicated. => I think not!
				}
            }
        }
        ///TODO Tovabbfejleszteni hogy kepes legyen lecsekkolni hogy mindegyik Habit megvan-e
        private bool IsTodayAlreadyAdded ()
        {
            DateTime time = DateTime.Now;
            if (_lastTestedTime.DayOfYear == time.DayOfYear)
            {
                return true;
            }
            return false;
        }
        private long CalculateElapsedHabitTime (long timePerDay)
        {
            long passedDays = (long) (DateTime.Now - _lastTestedTime).TotalDays; //If opened twice a day, it will be zero

            if (passedDays > 0) //Solves the 0 passedDay problem 
                return timePerDay * passedDays;
            else
                return timePerDay;
        }

        private Dictionary<Activity, long> CreateElapsedHabitTimes ()
        {
            Dictionary<Activity,long> habitList = _activityContainer.GetHabitList ();
            Dictionary<Activity,long> calculatedHabitList = new Dictionary<Activity,long> ();
            foreach (var habit in habitList)
            {
                long calculatedTime = CalculateElapsedHabitTime (habit.Value);
                calculatedHabitList.Add (habit.Key, calculatedTime);
            }
            return calculatedHabitList;
        }
    }
}