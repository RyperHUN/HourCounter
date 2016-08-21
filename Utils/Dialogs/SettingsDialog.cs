using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Dialogs
{
    public partial class SettingsDialog : Form
    {
        private bool IsCancellingChanges = true;
        public SettingsDialog ()
        {
            InitializeComponent ();
            Settings.Get.SetRestorePoint ();
        }

        private void checkAutomaticSave_CheckedChanged (object sender, EventArgs e)
        {
            Settings.Get.General.isAutomaticSave = checkAutomaticSave.Checked;
        }

        private void bCancel_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void bOk_Click (object sender, EventArgs e)
        {
            IsCancellingChanges = false; //Prevents discard changes popup
            this.Close ();
        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e )
        {
            if(IsCancellingChanges)
            {
                DialogResult result = MessageBox.Show("Do you want to discard changes", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Settings.Get.Restore ();
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;  //Prevents closing the dialog!
            }
        }

        
    }
}
