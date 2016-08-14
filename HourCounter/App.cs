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
        bool _isAutomaticSave = true;
        Activity _activityContainer = new Activity("INIT");
        HabitController _habitController;
        private readonly string ACTIVITYSERIALIZEDFILE = "dataActivity.bin";
        private readonly string HABITCONTROLERSERIALIZEDFILE = "dataHabit.bin";

        public App ()
        {
            InitializeComponent ();

            loadActivities ();
            if(!loadHabitController ())
                _habitController = new HabitController (_activityContainer);

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

            
            _habitController.StartController ();
        }

        private void menuAddNewActivity_Click (object sender, EventArgs e)
        {
            ActivityAdd activityAdd = new ActivityAdd(_activityContainer);
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
            SaveEverything(_isAutomaticSave);
        }

        private void SaveEverything (bool allowedToSave)
        {
            saveActivities (allowedToSave);
            saveHabitController (allowedToSave);
        }

        private void saveActivities (bool allowedToSave)
        {
            if (allowedToSave)
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream (ACTIVITYSERIALIZEDFILE,
                                                FileMode.Create,
                                                FileAccess.Write, FileShare.None);
                formatter.Serialize (stream, _activityContainer);
                stream.Close ();
            }
        }
        private void saveHabitController (bool allowedToSave)
        {
            if (allowedToSave)
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream (HABITCONTROLERSERIALIZEDFILE,
                                                FileMode.Create,
                                                FileAccess.Write, FileShare.None);
                formatter.Serialize (stream, _habitController);
                stream.Close ();
            }
        }

        private bool loadActivities ()
        {
            try
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream (ACTIVITYSERIALIZEDFILE,
                                                FileMode.Open,
                                                FileAccess.Read,
                                                FileShare.Read);
                _activityContainer = (Activity)formatter.Deserialize (stream);
                stream.Close ();
            }
            catch (System.Runtime.Serialization.SerializationException exc)
            {
                Console.WriteLine ( exc.ToString() );
                return false;
            }
            catch (FileNotFoundException /*exc*/)
            {
                return false;
            }
            return true;
        }
        private bool loadHabitController ()
        {
            try
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream (HABITCONTROLERSERIALIZEDFILE,
                                                FileMode.Open,
                                                FileAccess.Read,
                                                FileShare.Read);
                _habitController = (HabitController) formatter.Deserialize (stream);
                _habitController.InitVariables (_activityContainer);
                stream.Close ();
            }
            catch (System.Runtime.Serialization.SerializationException exc)
            {
                Console.WriteLine (exc.ToString ());
                return false;
            }
            catch (FileNotFoundException /*exc*/)
            {
                return false;
            }
            return true;
        }

        private void showHabitAdderToolStripMenuItem_Click (object sender, EventArgs e)
        {
            _habitController.OpenHabbitAdderDialog ();
        }

        //private void initFromCode()
        //{
        //    //Activity suli = new Activity("suli");

        //    //Activity programozas = new Activity("Programozás");


        //    //Activity cpp = new Activity("C++");

        //    //Activity csharp = new Activity("C#");

        //    //suli.AddSubActivity (programozas);
        //    //programozas.AddSubActivity (cpp);
        //    //programozas.AddSubActivity (csharp);

        //    //_activityContainer.AddSubActivity (suli);
        //}
    }
}
