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
        private bool IsCancellingChanges  = true;

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
            lValueTimerDefaultTime.Text          = TimeConverter.TimeToStringHHMMSS (settings.Timers.timerSetTime);

            radioPomodAlwaysRememberLast.Checked = settings.Timers.pomodRememberLastTime;
            radioPomodSetTime.Checked            = settings.Timers.pomodSetDefaultTime;
            lValuePomodDefaultRest.Text          = TimeConverter.TimeToStringMMSS (settings.Timers.pomodRestSetTime);
            lValuePomodDefaultWork.Text          = TimeConverter.TimeToStringMMSS (settings.Timers.pomodWorkSetTime);
        }

        private void InitGeneral ()
        {
            Settings settings = Settings.Get;
            checkEnableGDriveSave.Checked   = settings.General.isGDriveSave;
            checkEnableDriveLoad.Checked    = settings.General.isGDriveLoad;
            radioLetMeDecide.Checked        = settings.General.loadLetMeDecide;
            radioLoadNewer.Checked          = settings.General.loadAlwaysLoadNewer;

            checkHabitRemindHourly.Checked  = settings.General.habitRemindHourly;
            checkHabitRemindStartup.Checked = settings.General.habitRemindStartup;

            checkDayChooser.Checked         = settings.General.isDayChooserOn;
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

            Settings.Get.General.habitRemindHourly   = checkHabitRemindHourly.Checked;
            Settings.Get.General.habitRemindStartup  = checkHabitRemindStartup.Checked;

            Settings.Get.General.isDayChooserOn      = checkDayChooser.Checked;
        }
        private void SaveTimerSettings ()
        {
            //Pomod
            Settings.Get.Timers.pomodRememberLastTime = radioPomodAlwaysRememberLast.Checked;
            Settings.Get.Timers.pomodSetDefaultTime   = radioPomodSetTime.Checked;
            Settings.Get.Timers.pomodWorkSetTime      = TimeConverter.StringToTimeMMSS (lValuePomodDefaultWork.Text);
            Settings.Get.Timers.pomodRestSetTime      = TimeConverter.StringToTimeMMSS (lValuePomodDefaultRest.Text);

            //Timer
            Settings.Get.Timers.timerRememberLastTime = radioTimerAlwaysRememberLast.Checked;
            Settings.Get.Timers.timerSetDefaultTime   = radioTimerSetTime.Checked;
            Settings.Get.Timers.timerSetTime          = TimeConverter.StringToTimeHHMMSS (lValueTimerDefaultTime.Text);
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
            bTimerSet.Enabled     = radioTimerSetTime.Checked;
            bPomodSetWork.Enabled = radioPomodSetTime.Checked;
            bPomodSetRest.Enabled = radioPomodSetTime.Checked;
            
            //Enables load box in General
            groupLoading.Enabled = checkEnableDriveLoad.Checked;
        }

        private void bTimerSet_Click (object sender, EventArgs e)
        {
            Time parsedTime = new TimerSetter ().ShowDialog (TimeFormatType.HH_MM_SS);
            if (parsedTime != null)
                lValueTimerDefaultTime.Text = TimeConverter.TimeToStringHHMMSS (parsedTime);
        }

        private void bPomodSetWork_Click (object sender, EventArgs e)
        {
            Time parsedTime = new TimerSetter ().ShowDialog (TimeFormatType.MM);
            if (parsedTime != null)
                lValuePomodDefaultWork.Text = TimeConverter.TimeToStringMMSS (parsedTime);
        }

        private void bPomodSetRest_Click (object sender, EventArgs e)
        {
            Time parsedTime = new TimerSetter ().ShowDialog (TimeFormatType.MM);
            if (parsedTime != null)
                lValuePomodDefaultRest.Text = TimeConverter.TimeToStringMMSS (parsedTime);
        }
    }
}