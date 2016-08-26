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
        }
        private void InitValues ()
        {
            Settings settings = Settings.Get;
            checkEnableGDriveSave.Checked = settings.General.isGDriveSave;
            checkEnableDriveLoad.Checked  = settings.General.isGDriveLoad;
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
                    e.Cancel = false; //Closes the dialog
                else
                    e.Cancel = true;  //Prevents closing the dialog!
            }
			else//Clicked ok
				SaveSettingsChanges ();
        }
		
		private void SaveSettingsChanges ()
		{
			Settings.Get.General.isGDriveSave    = checkEnableGDriveSave.Checked;
            Settings.Get.General.isGDriveLoad    = checkEnableDriveLoad.Checked;
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