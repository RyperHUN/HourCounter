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

        private Nullable<Size> _savedFormSize = null;
        public event Action SettingsChanged;
        Serializer _serializer;
        public App ()
        {
            LoadEverything ();
            InitializeComponent ();
            InitSettings ();

            InitializeConnections ();
        }

        private void InitSettings ()
        {
            InitDayChooser ();
        }

        private void InitDayChooser ()
        {
            int sumPaddingMargin = 20;
            if (Utils.Settings.Get.General.isDayChooserOn)
            {
                dayChooser.Enabled = true;
                this.Height = mainPanel.Height + dayChooser.Height + menuBar.Height * 2 + sumPaddingMargin;
            }
            else
            {
                dayChooser.Disable();
                this.Height = mainPanel.Height + menuBar.Height * 2 + sumPaddingMargin;
            }
        }

        private void InitializeConnections ()
        {
            treeView.addActivityContainer (_activityContainer);
         
            dayChooser.SetActivityContainer (_activityContainer);

            _activityContainer.addObserver (treeView);
            _activityContainer.addObserver (detailedView);

            treeView.SelectChanged += detailedView.setSelectedActivity;
            treeView.SelectChanged += activityTimer.setSelectedActivity;

            activityTimer.TimerStartedEvent += treeView.timerStartedHandler;
            activityTimer.TimerStartedEvent += detailedView.timerStartedHandler;
            activityTimer.TimerStoppedEvent += treeView.timerStoppedHandler;
            activityTimer.TimerStoppedEvent += detailedView.timerStoppedHandler;
            SettingsChanged += InitSettings;

            splitContainerMain.Panel1.Controls.Add(treeView);
            detailedView.InitializeActivityContainer (_activityContainer);
            
            if (_activityContainer.GetSubActivityList ().Count == 0) //Hide details if no activity added
                HideDetailsAndTimers ();

            _habitController.StartController ();

            InitSerializer ();
        }

        private void InitSerializer ()
        {
            _serializer                    = new Serializer ();
            _serializer._activityContainer = _activityContainer;
            _serializer._habitController   = _habitController;
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
            if (_savedFormSize != null)
            {
                this.Size = _savedFormSize.Value;
                splitContainerMain.Panel2Collapsed = false;
                splitContainerMain.Panel2.Show ();
            }
        }

        private void menuAddNewActivity_Click (object sender, EventArgs e)
        {
            Dialogs.ActivityAdd activityAdd = new Dialogs.ActivityAdd(_activityContainer);
            activityAdd.ShowDialog();
            EnableDetailsAndTimers ();
        }        
        private void menuSettings_Click (object sender, EventArgs e)
        {
            DialogResult result = new Dialogs.SettingsDialog ().ShowDialog (); //TODO notification if settings changed/ (clicked ok)
            if (DialogResult.OK == result)
            {
                SettingsChanged?.Invoke ();
            }
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
            SaveEverything ();
            activityTimer.Save_Settings (); //This saves the last remembered time settings, 
                                            //TODO maybe do an event for saving?!
        }

        private void SaveEverything ()
        {
            _serializer.Save ();
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
