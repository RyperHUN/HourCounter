namespace Dialogs
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lValueAuthorizedStatus = new System.Windows.Forms.Label();
            this.lTextAuthorizedStatus = new System.Windows.Forms.Label();
            this.bAuthorizeGDrive = new System.Windows.Forms.Button();
            this.groupBoxGDrive = new System.Windows.Forms.GroupBox();
            this.checkEnableDriveLoad = new System.Windows.Forms.CheckBox();
            this.groupLoading = new System.Windows.Forms.GroupBox();
            this.radioLetMeDecide = new System.Windows.Forms.RadioButton();
            this.radioLoadNewer = new System.Windows.Forms.RadioButton();
            this.checkEnableGDriveSave = new System.Windows.Forms.CheckBox();
            this.tabTimers = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lValuePomodDefaultRest = new System.Windows.Forms.Label();
            this.lValuePomodDefaultWork = new System.Windows.Forms.Label();
            this.bPomodSetWork = new System.Windows.Forms.Button();
            this.bPomodSetRest = new System.Windows.Forms.Button();
            this.lPomodFormat2 = new System.Windows.Forms.Label();
            this.lTextRestTime = new System.Windows.Forms.Label();
            this.lTextWorkTime = new System.Windows.Forms.Label();
            this.lPomodFormat = new System.Windows.Forms.Label();
            this.radioPomodSetTime = new System.Windows.Forms.RadioButton();
            this.radioPomodAlwaysRememberLast = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lValueTimerDefaultTime = new System.Windows.Forms.Label();
            this.bTimerSet = new System.Windows.Forms.Button();
            this.lTextTimerDefault = new System.Windows.Forms.Label();
            this.lTimerFormat = new System.Windows.Forms.Label();
            this.radioTimerSetTime = new System.Windows.Forms.RadioButton();
            this.radioTimerAlwaysRememberLast = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.groupHabit = new System.Windows.Forms.GroupBox();
            this.checkHabitRemindHourly = new System.Windows.Forms.CheckBox();
            this.checkHabitRemindStartup = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBoxGDrive.SuspendLayout();
            this.groupLoading.SuspendLayout();
            this.tabTimers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupHabit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabTimers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(523, 361);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupHabit);
            this.tabGeneral.Controls.Add(this.lValueAuthorizedStatus);
            this.tabGeneral.Controls.Add(this.lTextAuthorizedStatus);
            this.tabGeneral.Controls.Add(this.bAuthorizeGDrive);
            this.tabGeneral.Controls.Add(this.groupBoxGDrive);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(515, 335);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lValueAuthorizedStatus
            // 
            this.lValueAuthorizedStatus.AutoSize = true;
            this.lValueAuthorizedStatus.Location = new System.Drawing.Point(107, 50);
            this.lValueAuthorizedStatus.Name = "lValueAuthorizedStatus";
            this.lValueAuthorizedStatus.Size = new System.Drawing.Size(21, 13);
            this.lValueAuthorizedStatus.TabIndex = 1;
            this.lValueAuthorizedStatus.Text = "Off";
            // 
            // lTextAuthorizedStatus
            // 
            this.lTextAuthorizedStatus.AutoSize = true;
            this.lTextAuthorizedStatus.Location = new System.Drawing.Point(8, 50);
            this.lTextAuthorizedStatus.Name = "lTextAuthorizedStatus";
            this.lTextAuthorizedStatus.Size = new System.Drawing.Size(93, 13);
            this.lTextAuthorizedStatus.TabIndex = 0;
            this.lTextAuthorizedStatus.Text = "Authorized Status:";
            // 
            // bAuthorizeGDrive
            // 
            this.bAuthorizeGDrive.Location = new System.Drawing.Point(9, 16);
            this.bAuthorizeGDrive.Name = "bAuthorizeGDrive";
            this.bAuthorizeGDrive.Size = new System.Drawing.Size(103, 22);
            this.bAuthorizeGDrive.TabIndex = 3;
            this.bAuthorizeGDrive.Text = "Authorize GDrive";
            this.bAuthorizeGDrive.UseVisualStyleBackColor = true;
            this.bAuthorizeGDrive.Click += new System.EventHandler(this.bAuthorizeGDrive_Click);
            // 
            // groupBoxGDrive
            // 
            this.groupBoxGDrive.Controls.Add(this.checkEnableDriveLoad);
            this.groupBoxGDrive.Controls.Add(this.groupLoading);
            this.groupBoxGDrive.Controls.Add(this.checkEnableGDriveSave);
            this.groupBoxGDrive.Enabled = false;
            this.groupBoxGDrive.Location = new System.Drawing.Point(5, 78);
            this.groupBoxGDrive.Name = "groupBoxGDrive";
            this.groupBoxGDrive.Size = new System.Drawing.Size(344, 116);
            this.groupBoxGDrive.TabIndex = 5;
            this.groupBoxGDrive.TabStop = false;
            this.groupBoxGDrive.Text = "Google Drive";
            // 
            // checkEnableDriveLoad
            // 
            this.checkEnableDriveLoad.AutoSize = true;
            this.checkEnableDriveLoad.Location = new System.Drawing.Point(161, 19);
            this.checkEnableDriveLoad.Name = "checkEnableDriveLoad";
            this.checkEnableDriveLoad.Size = new System.Drawing.Size(118, 17);
            this.checkEnableDriveLoad.TabIndex = 11;
            this.checkEnableDriveLoad.Text = "Enable GDrive load";
            this.checkEnableDriveLoad.UseVisualStyleBackColor = true;
            this.checkEnableDriveLoad.CheckedChanged += new System.EventHandler(this.selectableControlStateChanged);
            // 
            // groupLoading
            // 
            this.groupLoading.Controls.Add(this.radioLetMeDecide);
            this.groupLoading.Controls.Add(this.radioLoadNewer);
            this.groupLoading.Enabled = false;
            this.groupLoading.Location = new System.Drawing.Point(161, 38);
            this.groupLoading.Name = "groupLoading";
            this.groupLoading.Size = new System.Drawing.Size(176, 74);
            this.groupLoading.TabIndex = 10;
            this.groupLoading.TabStop = false;
            this.groupLoading.Text = "Loading";
            // 
            // radioLetMeDecide
            // 
            this.radioLetMeDecide.AutoSize = true;
            this.radioLetMeDecide.Location = new System.Drawing.Point(23, 42);
            this.radioLetMeDecide.Name = "radioLetMeDecide";
            this.radioLetMeDecide.Size = new System.Drawing.Size(92, 17);
            this.radioLetMeDecide.TabIndex = 9;
            this.radioLetMeDecide.Text = "Let me decide";
            this.radioLetMeDecide.UseVisualStyleBackColor = true;
            // 
            // radioLoadNewer
            // 
            this.radioLoadNewer.AutoSize = true;
            this.radioLoadNewer.Checked = true;
            this.radioLoadNewer.Location = new System.Drawing.Point(23, 19);
            this.radioLoadNewer.Name = "radioLoadNewer";
            this.radioLoadNewer.Size = new System.Drawing.Size(113, 17);
            this.radioLoadNewer.TabIndex = 8;
            this.radioLoadNewer.TabStop = true;
            this.radioLoadNewer.Text = "Always load newer";
            this.radioLoadNewer.UseVisualStyleBackColor = true;
            // 
            // checkEnableGDriveSave
            // 
            this.checkEnableGDriveSave.AutoSize = true;
            this.checkEnableGDriveSave.Location = new System.Drawing.Point(6, 19);
            this.checkEnableGDriveSave.Name = "checkEnableGDriveSave";
            this.checkEnableGDriveSave.Size = new System.Drawing.Size(121, 17);
            this.checkEnableGDriveSave.TabIndex = 7;
            this.checkEnableGDriveSave.Text = "Enable GDrive save";
            this.checkEnableGDriveSave.UseVisualStyleBackColor = true;
            // 
            // tabTimers
            // 
            this.tabTimers.Controls.Add(this.groupBox2);
            this.tabTimers.Controls.Add(this.groupBox1);
            this.tabTimers.Location = new System.Drawing.Point(4, 22);
            this.tabTimers.Name = "tabTimers";
            this.tabTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimers.Size = new System.Drawing.Size(461, 335);
            this.tabTimers.TabIndex = 1;
            this.tabTimers.Text = "Timers";
            this.tabTimers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lValuePomodDefaultRest);
            this.groupBox2.Controls.Add(this.lValuePomodDefaultWork);
            this.groupBox2.Controls.Add(this.bPomodSetWork);
            this.groupBox2.Controls.Add(this.bPomodSetRest);
            this.groupBox2.Controls.Add(this.lPomodFormat2);
            this.groupBox2.Controls.Add(this.lTextRestTime);
            this.groupBox2.Controls.Add(this.lTextWorkTime);
            this.groupBox2.Controls.Add(this.lPomodFormat);
            this.groupBox2.Controls.Add(this.radioPomodSetTime);
            this.groupBox2.Controls.Add(this.radioPomodAlwaysRememberLast);
            this.groupBox2.Location = new System.Drawing.Point(9, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pomodoro";
            // 
            // lValuePomodDefaultRest
            // 
            this.lValuePomodDefaultRest.AutoSize = true;
            this.lValuePomodDefaultRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lValuePomodDefaultRest.Location = new System.Drawing.Point(76, 100);
            this.lValuePomodDefaultRest.Name = "lValuePomodDefaultRest";
            this.lValuePomodDefaultRest.Size = new System.Drawing.Size(0, 13);
            this.lValuePomodDefaultRest.TabIndex = 11;
            // 
            // lValuePomodDefaultWork
            // 
            this.lValuePomodDefaultWork.AutoSize = true;
            this.lValuePomodDefaultWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lValuePomodDefaultWork.Location = new System.Drawing.Point(76, 70);
            this.lValuePomodDefaultWork.Name = "lValuePomodDefaultWork";
            this.lValuePomodDefaultWork.Size = new System.Drawing.Size(0, 13);
            this.lValuePomodDefaultWork.TabIndex = 11;
            // 
            // bPomodSetWork
            // 
            this.bPomodSetWork.Location = new System.Drawing.Point(236, 66);
            this.bPomodSetWork.Name = "bPomodSetWork";
            this.bPomodSetWork.Size = new System.Drawing.Size(44, 23);
            this.bPomodSetWork.TabIndex = 11;
            this.bPomodSetWork.Text = "Set";
            this.bPomodSetWork.UseVisualStyleBackColor = true;
            this.bPomodSetWork.Click += new System.EventHandler(this.bPomodSetWork_Click);
            // 
            // bPomodSetRest
            // 
            this.bPomodSetRest.Location = new System.Drawing.Point(236, 95);
            this.bPomodSetRest.Name = "bPomodSetRest";
            this.bPomodSetRest.Size = new System.Drawing.Size(44, 23);
            this.bPomodSetRest.TabIndex = 10;
            this.bPomodSetRest.Text = "Set";
            this.bPomodSetRest.UseVisualStyleBackColor = true;
            this.bPomodSetRest.Click += new System.EventHandler(this.bPomodSetRest_Click);
            // 
            // lPomodFormat2
            // 
            this.lPomodFormat2.AutoSize = true;
            this.lPomodFormat2.Location = new System.Drawing.Point(178, 100);
            this.lPomodFormat2.Name = "lPomodFormat2";
            this.lPomodFormat2.Size = new System.Drawing.Size(43, 13);
            this.lPomodFormat2.TabIndex = 7;
            this.lPomodFormat2.Text = "minutes";
            // 
            // lTextRestTime
            // 
            this.lTextRestTime.AutoSize = true;
            this.lTextRestTime.Location = new System.Drawing.Point(12, 100);
            this.lTextRestTime.Name = "lTextRestTime";
            this.lTextRestTime.Size = new System.Drawing.Size(54, 13);
            this.lTextRestTime.TabIndex = 5;
            this.lTextRestTime.Text = "Rest time:";
            // 
            // lTextWorkTime
            // 
            this.lTextWorkTime.AutoSize = true;
            this.lTextWorkTime.Location = new System.Drawing.Point(12, 70);
            this.lTextWorkTime.Name = "lTextWorkTime";
            this.lTextWorkTime.Size = new System.Drawing.Size(58, 13);
            this.lTextWorkTime.TabIndex = 4;
            this.lTextWorkTime.Text = "Work time:";
            // 
            // lPomodFormat
            // 
            this.lPomodFormat.AutoSize = true;
            this.lPomodFormat.Location = new System.Drawing.Point(178, 70);
            this.lPomodFormat.Name = "lPomodFormat";
            this.lPomodFormat.Size = new System.Drawing.Size(43, 13);
            this.lPomodFormat.TabIndex = 3;
            this.lPomodFormat.Text = "minutes";
            // 
            // radioPomodSetTime
            // 
            this.radioPomodSetTime.AutoSize = true;
            this.radioPomodSetTime.Location = new System.Drawing.Point(7, 44);
            this.radioPomodSetTime.Name = "radioPomodSetTime";
            this.radioPomodSetTime.Size = new System.Drawing.Size(98, 17);
            this.radioPomodSetTime.TabIndex = 1;
            this.radioPomodSetTime.TabStop = true;
            this.radioPomodSetTime.Text = "Set default time";
            this.radioPomodSetTime.UseVisualStyleBackColor = true;
            this.radioPomodSetTime.CheckedChanged += new System.EventHandler(this.selectableControlStateChanged);
            // 
            // radioPomodAlwaysRememberLast
            // 
            this.radioPomodAlwaysRememberLast.AutoSize = true;
            this.radioPomodAlwaysRememberLast.Location = new System.Drawing.Point(7, 20);
            this.radioPomodAlwaysRememberLast.Name = "radioPomodAlwaysRememberLast";
            this.radioPomodAlwaysRememberLast.Size = new System.Drawing.Size(165, 17);
            this.radioPomodAlwaysRememberLast.TabIndex = 0;
            this.radioPomodAlwaysRememberLast.TabStop = true;
            this.radioPomodAlwaysRememberLast.Text = "Always remember last set time";
            this.radioPomodAlwaysRememberLast.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lValueTimerDefaultTime);
            this.groupBox1.Controls.Add(this.bTimerSet);
            this.groupBox1.Controls.Add(this.lTextTimerDefault);
            this.groupBox1.Controls.Add(this.lTimerFormat);
            this.groupBox1.Controls.Add(this.radioTimerSetTime);
            this.groupBox1.Controls.Add(this.radioTimerAlwaysRememberLast);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // lValueTimerDefaultTime
            // 
            this.lValueTimerDefaultTime.AutoSize = true;
            this.lValueTimerDefaultTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lValueTimerDefaultTime.Location = new System.Drawing.Point(76, 79);
            this.lValueTimerDefaultTime.Name = "lValueTimerDefaultTime";
            this.lValueTimerDefaultTime.Size = new System.Drawing.Size(0, 13);
            this.lValueTimerDefaultTime.TabIndex = 10;
            // 
            // bTimerSet
            // 
            this.bTimerSet.Location = new System.Drawing.Point(236, 74);
            this.bTimerSet.Name = "bTimerSet";
            this.bTimerSet.Size = new System.Drawing.Size(44, 23);
            this.bTimerSet.TabIndex = 9;
            this.bTimerSet.Text = "Set";
            this.bTimerSet.UseVisualStyleBackColor = true;
            this.bTimerSet.Click += new System.EventHandler(this.bTimerSet_Click);
            // 
            // lTextTimerDefault
            // 
            this.lTextTimerDefault.AutoSize = true;
            this.lTextTimerDefault.Location = new System.Drawing.Point(9, 79);
            this.lTextTimerDefault.Name = "lTextTimerDefault";
            this.lTextTimerDefault.Size = new System.Drawing.Size(66, 13);
            this.lTextTimerDefault.TabIndex = 8;
            this.lTextTimerDefault.Text = "Default time:";
            // 
            // lTimerFormat
            // 
            this.lTimerFormat.AutoSize = true;
            this.lTimerFormat.Location = new System.Drawing.Point(170, 79);
            this.lTimerFormat.Name = "lTimerFormat";
            this.lTimerFormat.Size = new System.Drawing.Size(51, 13);
            this.lTimerFormat.TabIndex = 3;
            this.lTimerFormat.Text = "hh:mm:ss";
            // 
            // radioTimerSetTime
            // 
            this.radioTimerSetTime.AutoSize = true;
            this.radioTimerSetTime.Location = new System.Drawing.Point(7, 44);
            this.radioTimerSetTime.Name = "radioTimerSetTime";
            this.radioTimerSetTime.Size = new System.Drawing.Size(98, 17);
            this.radioTimerSetTime.TabIndex = 1;
            this.radioTimerSetTime.TabStop = true;
            this.radioTimerSetTime.Text = "Set default time";
            this.radioTimerSetTime.UseVisualStyleBackColor = true;
            this.radioTimerSetTime.CheckedChanged += new System.EventHandler(this.selectableControlStateChanged);
            // 
            // radioTimerAlwaysRememberLast
            // 
            this.radioTimerAlwaysRememberLast.AutoSize = true;
            this.radioTimerAlwaysRememberLast.Location = new System.Drawing.Point(7, 20);
            this.radioTimerAlwaysRememberLast.Name = "radioTimerAlwaysRememberLast";
            this.radioTimerAlwaysRememberLast.Size = new System.Drawing.Size(165, 17);
            this.radioTimerAlwaysRememberLast.TabIndex = 0;
            this.radioTimerAlwaysRememberLast.TabStop = true;
            this.radioTimerAlwaysRememberLast.Text = "Always remember last set time";
            this.radioTimerAlwaysRememberLast.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bCancel);
            this.splitContainer1.Panel2.Controls.Add(this.bOk);
            this.splitContainer1.Size = new System.Drawing.Size(523, 410);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(436, 13);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(13, 13);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // groupHabit
            // 
            this.groupHabit.Controls.Add(this.checkHabitRemindStartup);
            this.groupHabit.Controls.Add(this.checkHabitRemindHourly);
            this.groupHabit.Location = new System.Drawing.Point(6, 200);
            this.groupHabit.Name = "groupHabit";
            this.groupHabit.Size = new System.Drawing.Size(343, 75);
            this.groupHabit.TabIndex = 11;
            this.groupHabit.TabStop = false;
            this.groupHabit.Text = "Habbits";
            // 
            // checkHabitRemindHourly
            // 
            this.checkHabitRemindHourly.AutoSize = true;
            this.checkHabitRemindHourly.Checked = true;
            this.checkHabitRemindHourly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHabitRemindHourly.Location = new System.Drawing.Point(6, 19);
            this.checkHabitRemindHourly.Name = "checkHabitRemindHourly";
            this.checkHabitRemindHourly.Size = new System.Drawing.Size(201, 17);
            this.checkHabitRemindHourly.TabIndex = 12;
            this.checkHabitRemindHourly.Text = "Remind hourly for adding, until added";
            this.checkHabitRemindHourly.UseVisualStyleBackColor = true;
            // 
            // checkHabitRemindStartup
            // 
            this.checkHabitRemindStartup.AutoSize = true;
            this.checkHabitRemindStartup.Location = new System.Drawing.Point(6, 42);
            this.checkHabitRemindStartup.Name = "checkHabitRemindStartup";
            this.checkHabitRemindStartup.Size = new System.Drawing.Size(109, 17);
            this.checkHabitRemindStartup.TabIndex = 13;
            this.checkHabitRemindStartup.Text = "Remind at startup";
            this.checkHabitRemindStartup.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 410);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.groupBoxGDrive.ResumeLayout(false);
            this.groupBoxGDrive.PerformLayout();
            this.groupLoading.ResumeLayout(false);
            this.groupLoading.PerformLayout();
            this.tabTimers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupHabit.ResumeLayout(false);
            this.groupHabit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabTimers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label lValueAuthorizedStatus;
        private System.Windows.Forms.Label lTextAuthorizedStatus;
        private System.Windows.Forms.Button bAuthorizeGDrive;
        private System.Windows.Forms.GroupBox groupBoxGDrive;
        private System.Windows.Forms.CheckBox checkEnableGDriveSave;
        private System.Windows.Forms.RadioButton radioLetMeDecide;
        private System.Windows.Forms.RadioButton radioLoadNewer;
        private System.Windows.Forms.GroupBox groupLoading;
        private System.Windows.Forms.CheckBox checkEnableDriveLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lTimerFormat;
        private System.Windows.Forms.RadioButton radioTimerSetTime;
        private System.Windows.Forms.RadioButton radioTimerAlwaysRememberLast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lPomodFormat2;
        private System.Windows.Forms.Label lTextRestTime;
        private System.Windows.Forms.Label lTextWorkTime;
        private System.Windows.Forms.Label lPomodFormat;
        private System.Windows.Forms.RadioButton radioPomodSetTime;
        private System.Windows.Forms.RadioButton radioPomodAlwaysRememberLast;
        private System.Windows.Forms.Label lTextTimerDefault;
        private System.Windows.Forms.Button bPomodSetWork;
        private System.Windows.Forms.Button bPomodSetRest;
        private System.Windows.Forms.Button bTimerSet;
        private System.Windows.Forms.Label lValuePomodDefaultRest;
        private System.Windows.Forms.Label lValuePomodDefaultWork;
        private System.Windows.Forms.Label lValueTimerDefaultTime;
        private System.Windows.Forms.GroupBox groupHabit;
        private System.Windows.Forms.CheckBox checkHabitRemindHourly;
        private System.Windows.Forms.CheckBox checkHabitRemindStartup;
    }
}