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
            this.lTextLoading = new System.Windows.Forms.Label();
            this.bLoadFromDrive = new System.Windows.Forms.Button();
            this.radioLetMeDecide = new System.Windows.Forms.RadioButton();
            this.radioLoadNewer = new System.Windows.Forms.RadioButton();
            this.checkEnableGDriveSave = new System.Windows.Forms.CheckBox();
            this.tabTimers = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Minutes = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBoxGDrive.SuspendLayout();
            this.groupLoading.SuspendLayout();
            this.tabTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(520, 398);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lValueAuthorizedStatus);
            this.tabGeneral.Controls.Add(this.lTextAuthorizedStatus);
            this.tabGeneral.Controls.Add(this.bAuthorizeGDrive);
            this.tabGeneral.Controls.Add(this.groupBoxGDrive);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(512, 372);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lValueAuthorizedStatus
            // 
            this.lValueAuthorizedStatus.AutoSize = true;
            this.lValueAuthorizedStatus.Location = new System.Drawing.Point(108, 72);
            this.lValueAuthorizedStatus.Name = "lValueAuthorizedStatus";
            this.lValueAuthorizedStatus.Size = new System.Drawing.Size(21, 13);
            this.lValueAuthorizedStatus.TabIndex = 1;
            this.lValueAuthorizedStatus.Text = "Off";
            // 
            // lTextAuthorizedStatus
            // 
            this.lTextAuthorizedStatus.AutoSize = true;
            this.lTextAuthorizedStatus.Location = new System.Drawing.Point(9, 72);
            this.lTextAuthorizedStatus.Name = "lTextAuthorizedStatus";
            this.lTextAuthorizedStatus.Size = new System.Drawing.Size(93, 13);
            this.lTextAuthorizedStatus.TabIndex = 0;
            this.lTextAuthorizedStatus.Text = "Authorized Status:";
            // 
            // bAuthorizeGDrive
            // 
            this.bAuthorizeGDrive.Location = new System.Drawing.Point(12, 37);
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
            this.groupBoxGDrive.Location = new System.Drawing.Point(12, 101);
            this.groupBoxGDrive.Name = "groupBoxGDrive";
            this.groupBoxGDrive.Size = new System.Drawing.Size(343, 166);
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
            this.checkEnableDriveLoad.CheckedChanged += new System.EventHandler(this.checkEnableDriveLoad_CheckedChanged);
            // 
            // groupLoading
            // 
            this.groupLoading.Controls.Add(this.lTextLoading);
            this.groupLoading.Controls.Add(this.bLoadFromDrive);
            this.groupLoading.Controls.Add(this.radioLetMeDecide);
            this.groupLoading.Controls.Add(this.radioLoadNewer);
            this.groupLoading.Enabled = false;
            this.groupLoading.Location = new System.Drawing.Point(161, 38);
            this.groupLoading.Name = "groupLoading";
            this.groupLoading.Size = new System.Drawing.Size(176, 122);
            this.groupLoading.TabIndex = 10;
            this.groupLoading.TabStop = false;
            this.groupLoading.Text = "Loading";
            // 
            // lTextLoading
            // 
            this.lTextLoading.AutoSize = true;
            this.lTextLoading.Location = new System.Drawing.Point(32, 45);
            this.lTextLoading.Name = "lTextLoading";
            this.lTextLoading.Size = new System.Drawing.Size(48, 13);
            this.lTextLoading.TabIndex = 7;
            this.lTextLoading.Text = "Loading:";
            // 
            // bLoadFromDrive
            // 
            this.bLoadFromDrive.Location = new System.Drawing.Point(35, 19);
            this.bLoadFromDrive.Name = "bLoadFromDrive";
            this.bLoadFromDrive.Size = new System.Drawing.Size(97, 23);
            this.bLoadFromDrive.TabIndex = 7;
            this.bLoadFromDrive.Text = "Load from drive";
            this.bLoadFromDrive.UseVisualStyleBackColor = true;
            // 
            // radioLetMeDecide
            // 
            this.radioLetMeDecide.AutoSize = true;
            this.radioLetMeDecide.Location = new System.Drawing.Point(49, 89);
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
            this.radioLoadNewer.Location = new System.Drawing.Point(49, 66);
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
            this.tabTimers.Controls.Add(this.label5);
            this.tabTimers.Controls.Add(this.checkBox1);
            this.tabTimers.Controls.Add(this.button1);
            this.tabTimers.Controls.Add(this.groupBox2);
            this.tabTimers.Controls.Add(this.groupBox1);
            this.tabTimers.Location = new System.Drawing.Point(4, 22);
            this.tabTimers.Name = "tabTimers";
            this.tabTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimers.Size = new System.Drawing.Size(512, 372);
            this.tabTimers.TabIndex = 1;
            this.tabTimers.Text = "Timers";
            this.tabTimers.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Size = new System.Drawing.Size(520, 451);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(433, 13);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Always remember last set time";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Set default time";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "hh:mm:ss";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Minutes);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(9, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pomodoro";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(178, 70);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(43, 13);
            this.Minutes.TabIndex = 3;
            this.Minutes.Text = "minutes";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 44);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Set default time";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(165, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Always remember last set time";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Work time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rest time:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "minutes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Replace timer music";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loaded file:";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 451);
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
            this.tabTimers.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button bLoadFromDrive;
        private System.Windows.Forms.RadioButton radioLetMeDecide;
        private System.Windows.Forms.RadioButton radioLoadNewer;
        private System.Windows.Forms.Label lTextLoading;
        private System.Windows.Forms.GroupBox groupLoading;
        private System.Windows.Forms.CheckBox checkEnableDriveLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}