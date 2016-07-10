using System;
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
    public partial class Form1 : Form
    {
        bool _isAutomaticSave = true;
        Activity _activityContainer = new Activity("INIT");
        public Form1 ()
        {
            InitializeComponent ();
            //Neccesary for timer
            Activity suli = new Activity("suli");

            Activity programozas = new Activity("Programozás");


            Activity cpp = new Activity("C++");

            Activity csharp = new Activity("C#");

            suli.AddSubActivity(programozas);
            programozas.AddSubActivity(cpp);
            programozas.AddSubActivity(csharp);

            _activityContainer.AddSubActivity(suli);
            activityTimer.setActivityContainer(_activityContainer);
            //Neccesary for timer
            
            TreeListView treeList = new TreeListView(_activityContainer);

            treeList.Dock = DockStyle.Fill; //Így kitölti az egész szülő Containert

            _activityContainer.addObserver(treeList);

            splitContainerMain.Panel1.Controls.Add(treeList);
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
    }
}
