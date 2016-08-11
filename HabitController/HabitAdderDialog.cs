using HourCounter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitUtils
{
    public partial class HabitAdderDialog : Form
    {
        Dictionary<Activity,long> _habitContainer = null;

        public HabitAdderDialog ()
        {
            InitializeComponent ();
        }

        public void Initialize (Dictionary<Activity,long> habitContainer)
        {
            _habitContainer = habitContainer;
            FillPanelWithHabits ();
        }
        private void FillPanelWithHabits ()
        {
            foreach ( var habit in _habitContainer)
            {
                EditableHabitLine editableHabitLine = new EditableHabitLine ();
                editableHabitLine.Initialize (habit.Key, habit.Value);
                
                flowLayoutPanel.Controls.Add (editableHabitLine);
            }
        }
        private void bCancel_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void bAdd_Click (object sender, EventArgs e)
        {
            foreach (EditableHabitLine control in flowLayoutPanel.Controls)
            {
                control.HandleAdding ();
            }
            this.Close ();
        }
    }
}
