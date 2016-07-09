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
        Activity activityContainer = new Activity("INIT");
        public Form1()
        {
            InitializeComponent();

            Activity suli = new Activity("suli");

            Activity programozas = new Activity("Programozás");
            

            Activity cpp = new Activity("C++");

            Activity csharp = new Activity("C#");

            suli.AddSubActivity(programozas);
            programozas.AddSubActivity(cpp);
            programozas.AddSubActivity(csharp);

            activityContainer.AddSubActivity(suli);
            activityContainer.AddSubActivity(programozas);
            TreeListView treeList = new TreeListView(activityContainer);

            treeList.Dock = DockStyle.Fill; //Így kitölti az egész szülő Containert
            treeList.ExpandAll();

            activityContainer.addObserver(treeList);

            splitContainer.Panel1.Controls.Add(treeList);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ActivityAdd activityAdd = new ActivityAdd(activityContainer);
            activityAdd.ShowDialog();
            
        }
    }
}
