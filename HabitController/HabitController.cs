using HourCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitController
{
    //YOU HAVE TO START THE CONTROLLER MANUALLY
    public class HabitController
    {
        private Activity _activityContainer;
        private DateTime _lastTestedTime; ///TODO Kiserializalni es ezalapjan megmondani az elmaradt napokat, abbol pedig idot kalkulalni vagy valami ilyesmi!
        private Timer    _hourCounterTimer = new Timer ();

        //public Timer HourTime
        //{
        //    get { return _hourCounterTimer; }
        //    private set {; }
        //}
        
        public HabitController (Activity activityContainer)
        {
            _activityContainer = activityContainer;
            _hourCounterTimer.Interval = 3600000; //1 hour
            _hourCounterTimer.Tick += hourCounter_Tick;
        }
        public void StartController ()
        {
            HabitTimeAdderLogic ();
            _hourCounterTimer.Start ();
        }

        private void hourCounter_Tick (object sender, EventArgs e)
        {
            HabitTimeAdderLogic ();
        }
        public void HabitTimeAdderLogic ()
        {
            if (IsTodayAlreadyAdded ())
            {
                _hourCounterTimer.Stop ();
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show ("Do you want to add habbits now?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.OK)
                {
                    _lastTestedTime = DateTime.Now;
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
