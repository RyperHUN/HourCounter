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
            InitValues ();
            Settings.Get.SetRestorePoint ();
        }
        private void InitValues ()
        {
            Settings settings = Settings.Get;
            checkAutomaticSave.Checked    = settings.General.isAutomaticSave;
            checkEnableGDriveSave.Checked = settings.General.isGDriveSave;
        }

        private void checkAutomaticSave_CheckedChanged (object sender, EventArgs e)
        {
            Settings.Get.General.isAutomaticSave = checkAutomaticSave.Checked;
        }

        private void checkEnableGDriveLoad_CheckedChanged (object sender, EventArgs e)
        {
            Settings.Get.General.isGDriveSave    = checkAutomaticSave.Checked;
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

        private void checkEnableDriveLoad_CheckedChanged (object sender, EventArgs e)
        {
            groupLoading.Enabled = !groupLoading.Enabled;   
        }

        private void bAuthorizeGDrive_Click (object sender, EventArgs e)
        {
            if (lValueAuthorizedStatus.Text == "Off")
            {
                bool isAuthenticated = GDrive.CommandExecuter.IsAuthenticated ();
                if(isAuthenticated)
                {
                    lValueAuthorizedStatus.Text = "On";
                    groupBoxGDrive.Enabled      = true;
                }
            }
        }
    }
}
