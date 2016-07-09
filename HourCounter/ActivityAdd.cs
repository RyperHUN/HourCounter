﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourCounter
{
    public partial class ActivityAdd : Form
    {
        private Activity _activityContainer;
        public ActivityAdd (Activity activityContainer)
        {
            _activityContainer = activityContainer;
            InitializeComponent ();
        }

        private void radioSubActivity_CheckedChanged (object sender, EventArgs e)
        {
            comboActivityDropDown.Enabled = !comboActivityDropDown.Enabled;
        }

        private void bAdd_Click (object sender, EventArgs e)
        {
            String activityName = tActivityName.Text;
            long timeSpent;
            if (!Int64.TryParse (tTimeSpent.Text, out timeSpent))
                throw new System.IO.IOException ("Expected only number at the timeSpent textbox");

            Activity newActivity = new Activity (activityName, timeSpent);
            if (radioMainActivity.Checked)
            {
                ///TODO Check if activity exists error
                _activityContainer.AddSubActivity (newActivity);
            }
            else
            {
                throw new NotImplementedException();
            }
            this.Close ();
        }
    }
}
