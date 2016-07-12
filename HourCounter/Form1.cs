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
    public partial class Form1 : Form
    {
        /// TODO ActivitityChanged Esemeny: Feliratkoznak ra a nezetek, es megkapjak a kivalasztott uj activityt
        bool _isAutomaticSave = true;
        Activity _activityContainer = new Activity("INIT");
        public Form1 ()
        {
            InitializeComponent ();

            loadActivities ();
            
            

            treeView.addActivityContainer (_activityContainer);
         

            _activityContainer.addObserver (treeView);
            _activityContainer.addObserver (detailedView);

            treeView.SelectChanged += detailedView.setSelectedActivity;
            treeView.SelectChanged += activityTimer.setSelectedActivity;

            splitContainerMain.Panel1.Controls.Add(treeView);
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
            saveActivities ();
        }

        private void saveActivities()
        {
            if(_isAutomaticSave)
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream("data.bin",
                                               FileMode.Create,
                                               FileAccess.Write, FileShare.None);
                formatter.Serialize (stream, _activityContainer);
                stream.Close ();
            }
        }

        private bool loadActivities()
        {
            try
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream("data.bin",
                                           FileMode.Open,
                                           FileAccess.Read,
                                           FileShare.Read);
                _activityContainer = (Activity)formatter.Deserialize (stream);
                stream.Close ();
            }
            catch (FileNotFoundException exc)
            {
                return false;
            }
            return true;
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
