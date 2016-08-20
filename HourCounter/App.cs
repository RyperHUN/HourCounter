﻿using HabitUtils;
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
        bool _isAutomaticSave       = true; ///TODO Berakni settingsbe és a serializatorba
        Activity        _activityContainer;
        HabitController _habitController;

        public App ()
        {
            LoadEverything ();
            InitializeComponent ();

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
            
            _habitController.StartController ();
        }

        private void menuAddNewActivity_Click (object sender, EventArgs e)
        {
            Dialogs.ActivityAdd activityAdd = new Dialogs.ActivityAdd(_activityContainer);
            activityAdd.ShowDialog();
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {

        }

        private void menuAutomaticSave_Click(object sender, EventArgs e)
        {
            if(_isAutomaticSave)
            {
                _isAutomaticSave = false;
                menuAutomaticSave.Text = "Automatic Save: OFF";
            }
            else
            {
                _isAutomaticSave = true;
                menuAutomaticSave.Text = "Automatic Save: ON";
            }
        }

        private void treeView_AfterSelect (object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView.SelectedNode;
            String activityName   = selectedNode.Text;
            activityName = Activity.removeFormat (activityName);
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
            serializer.Save ();
        }
        private void LoadEverything ()
        {
            Serializer serializer = Serializer.loadEverythingFromDisk ();
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
