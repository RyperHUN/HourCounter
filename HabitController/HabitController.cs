using HourCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitController
{
    //YOU HAVE TO START THE CONTROLLER MANUALLY
	[Serializable]
    public class HabitController : ISerializable
    {
        private Activity _activityContainer = null;
        private DateTime _lastTestedTime = DateTime.MinValue;
		//private Dictionary<Activity, bool> _whatIsAdded = new Dictionary<Activity, bool>(); //Maybe later
        private Timer    _hourCounterTimer;
		private bool _isInitialized = false;
		
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
			//if(!_isInitialized)
			//	throw new InitializationError;
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
			//if(!_isInitialized)
			//	throw new InitializationError;
		}
        public void HabitTimeAdderLogic ()
        {
			//if(!_isInitialized)
			//	throw new InitializationError;
		
            if (IsTodayAlreadyAdded ())
            {
                _hourCounterTimer.Stop ();
				OpenHabbitAdderDialog (); 
                return;
            }
            else
            {
				_hourCounterTimer.Stop (); //There will be no duplicated messages
                DialogResult result = MessageBox.Show ("Do you want to add habbits now?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.OK)
                {
                    _lastTestedTime = DateTime.Now;
                }
				else if (result == DialogResult.Cancel)
				{
					_hourCounterTimer.Start (); ///TODO Test if it is a problem if start is duplicated.
				}
            }
        }
        ///TODO Tovabbfejleszteni hogy kepes legyen lecsekkolni hogy mindegyik Habit megvan-e
        private bool IsTodayAlreadyAdded()
        {
            DateTime time = DateTime.Now;
            if (_lastTestedTime.DayOfYear == time.DayOfYear)
            {
                return true;
            }
            return false;
        }
    }
}