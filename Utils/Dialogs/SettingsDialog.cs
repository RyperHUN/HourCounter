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
            InitGeneral ();
            InitTimer ();
            EnableAndDisableControls ();
        }

        private void InitTimer ()
        {
            Settings settings = Settings.Get;
            radioTimerAlwaysRememberLast.Checked = settings.Timers.timerRememberLastTime;
            radioTimerSetTime.Checked            = settings.Timers.timerSetDefaultTime;
            tTimerDefaultTime.Text               = TimeConverter.TimeToStringHHMMSS (settings.Timers.timerSetTime);

            radioPomodAlwaysRememberLast.Checked = settings.Timers.pomodRememberLastTime;
            radioPomodSetTime.Checked            = settings.Timers.pomodSetDefaultTime;
            tPomodWorkTime.Text                  = TimeConverter.TimeToStringMMSS (settings.Timers.pomodWorkSetTime); //Maybe convert to MIN
            tPomodRestTime.Text                  = TimeConverter.TimeToStringMMSS (settings.Timers.pomodRestSetTime);
        }

        private void InitGeneral ()
        {
            Settings settings = Settings.Get;
            checkEnableGDriveSave.Checked = settings.General.isGDriveSave;
            checkEnableDriveLoad.Checked  = settings.General.isGDriveLoad;
            radioLetMeDecide.Checked      = settings.General.loadLetMeDecide;
            radioLoadNewer.Checked        = settings.General.loadAlwaysLoadNewer;
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
			SaveGeneralSettings ();
            SaveTimerSettings ();
		}

        private void SaveGeneralSettings ()
        {
            Settings.Get.General.isGDriveSave        = checkEnableGDriveSave.Checked;
            Settings.Get.General.isGDriveLoad        = checkEnableDriveLoad.Checked;
            Settings.Get.General.loadLetMeDecide     = radioLetMeDecide.Checked;
            Settings.Get.General.loadAlwaysLoadNewer = radioLoadNewer.Checked;
        }

        private void SaveTimerSettings ()
        {
            Settings.Get.Timers.pomodRememberLastTime = radioPomodAlwaysRememberLast.Checked;
            Settings.Get.Timers.pomodSetDefaultTime   = radioPomodSetTime.Checked;
            ///TODO get set time

            Settings.Get.Timers.timerRememberLastTime = radioTimerAlwaysRememberLast.Checked;
            Settings.Get.Timers.timerSetDefaultTime   = radioTimerSetTime.Checked;
            ///TODO get set time
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

        private void selectableControlStateChanged (object sender, EventArgs e)
        {
            EnableAndDisableControls ();
        }

        private void EnableAndDisableControls ()
        {
            //Enables textboxes in Timer
            tPomodRestTime.Enabled = radioPomodSetTime.Checked;
            tPomodWorkTime.Enabled = radioPomodSetTime.Checked;

            tTimerDefaultTime.Enabled = radioTimerSetTime.Checked;
            bTimeBrowse.Enabled = checkReplaceTimerMusic.Checked;
            
            //Enables load box in General
            groupLoading.Enabled = checkEnableDriveLoad.Checked;
        }
    }
}