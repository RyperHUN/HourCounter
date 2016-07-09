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
        ActivityContainer activityContainer = new ActivityContainer();
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

            activityContainer.addActivity(suli);
            activityContainer.addActivity(programozas);
            TreeListView treeList = new TreeListView(activityContainer);

            treeList.Dock = DockStyle.Fill; //Így kitölti az egész szülő Containert
            treeList.ExpandAll();

            splitContainer.Panel1.Controls.Add(treeList);
        }
    }
}
