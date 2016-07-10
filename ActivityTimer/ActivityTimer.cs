using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityTimer
{
    public partial class ActivityTimer : UserControl
    {
        public ActivityTimer()
        {
            InitializeComponent();
            tabPicker.Dock = DockStyle.Fill;
        }
    }
}
