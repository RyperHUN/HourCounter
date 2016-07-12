using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HourCounter;

namespace DetailedView
{
    public partial class DetailedView : UserControl
    {
        Activity _selectedActivity = null;
        public DetailedView ()
        {
            InitializeComponent ();
        }
        void addActivity (Activity selectedActivity)
        {
            _selectedActivity = selectedActivity;
        }
    }
}
