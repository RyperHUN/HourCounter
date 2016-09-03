using HabitUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourCounter
{
    public partial class App : Form
    {
        private Activity        _activityContainer;
        private HabitController _habitController;

        private Size _savedFormSize;

        public App ()
        {
            LoadEverything ();
            InitializeComponent ();

            InitializeConnections ();
        }

        private void InitializeConnections ()
        {
            treeView.addActivityContainer (_activityContainer);
         

            _activityContainer.addObserver (treeView);
            _activityContainer.addObserver (detailedView);

            treeView.SelectChanged += detailedView.setSelectedActivity;
            treeView.SelectChanged += activityTimer.setSelectedActivity;

            activityTimer.TimerStartedEvent += treeView.timerStartedHandler;
            activityTimer.TimerStartedEvent += detailedView.timerStartedHandler;
            activityTimer.TimerStoppedEvent += treeView.timerStoppedHandler;
            activityTimer.TimerStoppedEvent += detailedView.timerStoppedHandler;

            splitContainerMain.Panel1.Controls.Add(treeView);
            detailedView.InitializeActivityContainer (_activityContainer);
            
            if (_activityContainer.GetSubActivityList ().Count == 0) //Hide details if no activity added
                HideDetailsAndTimers ();

            _habitController.StartController (); 
        }

        private void HideDetailsAndTimers ()
        {
            _savedFormSize = this.Size;
            this.Size = splitContainerMain.Panel1.ClientSize;
            splitContainerMain.Panel2Collapsed = true;
            splitContainerMain.Panel2.Hide ();
        }

        private void EnableDetailsAndTimers ()
        {
            this.Size = _savedFormSize;
            splitContainerMain.Panel2Collapsed = false;
            splitContainerMain.Panel2.Show ();
        }

        private void menuAddNewActivity_Click (object sender, EventArgs e)
        {
            Dialogs.ActivityAdd activityAdd = new Dialogs.ActivityAdd(_activityContainer);
            activityAdd.ShowDialog();
            EnableDetailsAndTimers ();
        }

        private void menuSettings_Click (object sender, EventArgs e)
        {
            new Dialogs.SettingsDialog ().ShowDialog ();
        }

        private void treeView_AfterSelect (object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView.SelectedNode;
            String activityName   = selectedNode.Text;
            activityName          = Activity.removeFormat (activityName);
            Activity activity     = _activityContainer.Find(_activityContainer,activityName);
            treeView.SelectChangedFunction (activity);
        }
        private void Form1_FormClosing (object sender, FormClosingEventArgs e)
        {
            //SaveEverything(_isAutomaticSave);
            SaveEverything ();
        }

        private void SaveEverything ()
        {
            Serializer serializer         = new Serializer ();
            serializer._activityContainer = _activityContainer;
            serializer._habitController   = _habitController;
            activityTimer.Save_Settings (); //This saves the last remembered time settings, maybe do an event for saving?!
            serializer.Save ();
        }
        private void LoadEverything ()
        {
            Serializer serializer = Serializer.Load ();
            if(serializer != null) 
            {
                _activityContainer = serializer._activityContainer;
                _habitController   = serializer._habitController;
                _habitController.InitVariables (_activityContainer); //Maybe put init into serializer???
            }
            else //Failed serialization
            {
                _activityContainer = new Activity ("INIT");
                _habitController   = new HabitController (_activityContainer);
            }
        }

        private void showHabitAdderToolStripMenuItem_Click (object sender, EventArgs e)
        {
            _habitController.OpenHabbitAdderDialog ();
        }
    }
}
