namespace ActivityTimer
{
    partial class ActivityTimer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Stop_timerSecond = new System.Windows.Forms.Timer(this.components);
            this.Timer_bStart = new System.Windows.Forms.Button();
            this.Timer_bPause = new System.Windows.Forms.Button();
            this.Timer_bStop = new System.Windows.Forms.Button();
            this.Timer_tSetTime = new System.Windows.Forms.TextBox();
            this.Timer_lTextRemainingTime = new System.Windows.Forms.Label();
            this.Timer_lRemainingTime = new System.Windows.Forms.Label();
            this.tabPicker = new System.Windows.Forms.TabControl();
            this.tabStopwatch = new System.Windows.Forms.TabPage();
            this.Stop_bStop = new System.Windows.Forms.Button();
            this.Stop_bPause = new System.Windows.Forms.Button();
            this.Stop_bStart = new System.Windows.Forms.Button();
            this.Stop_lTime = new System.Windows.Forms.Label();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.Timer_bSetTime = new System.Windows.Forms.Button();
            this.Timer_lTextSetTheTime = new System.Windows.Forms.Label();
            this.tabPomodoro = new System.Windows.Forms.TabPage();
            this.Pomod_lValueRemainingTime = new System.Windows.Forms.Label();
            this.Pomod_lTextMode = new System.Windows.Forms.Label();
            this.Pomod_bSetRestTime = new System.Windows.Forms.Button();
            this.Pomod_tValueSetRestTimeMin = new System.Windows.Forms.TextBox();
            this.Pomod_lTextSetRestTIme = new System.Windows.Forms.Label();
            this.Pomod_bSetWorkTime = new System.Windows.Forms.Button();
            this.Pomod_lTextSetWorkTime = new System.Windows.Forms.Label();
            this.Pomod_lTextRemainingTime = new System.Windows.Forms.Label();
            this.Pomod_bStart = new System.Windows.Forms.Button();
            this.Pomod_bPause = new System.Windows.Forms.Button();
            this.Pomod_tValueSetWorkTimeMin = new System.Windows.Forms.TextBox();
            this.Pomod_bStop = new System.Windows.Forms.Button();
            this.Pomod_lValueMode = new System.Windows.Forms.Label();
            this.tabManualAdd = new System.Windows.Forms.TabPage();
            this.Manual_bAdd = new System.Windows.Forms.Button();
            this.Manual_lTextSetTime = new System.Windows.Forms.Label();
            this.Manual_tSetTime = new System.Windows.Forms.TextBox();
            this.tabSetAsHabit = new System.Windows.Forms.TabPage();
            this.Habit_lTextSetTheTime = new System.Windows.Forms.Label();
            this.Habit_lTextMinPerDay = new System.Windows.Forms.Label();
            this.Habit_bSetAsHabit = new System.Windows.Forms.Button();
            this.Habit_tSetTime = new System.Windows.Forms.TextBox();
            this.Habit_bRemoveFromHabbits = new System.Windows.Forms.Button();
            this.Habit_lValueMinPerDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPicker.SuspendLayout();
            this.tabStopwatch.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.tabPomodoro.SuspendLayout();
            this.tabManualAdd.SuspendLayout();
            this.tabSetAsHabit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stop_timerSecond
            // 
            this.Stop_timerSecond.Tick += new System.EventHandler(this.Stop_stopwatchSecond_Tick);
            // 
            // Timer_bStart
            // 
            this.Timer_bStart.Location = new System.Drawing.Point(6, 108);
            this.Timer_bStart.Name = "Timer_bStart";
            this.Timer_bStart.Size = new System.Drawing.Size(75, 23);
            this.Timer_bStart.TabIndex = 0;
            this.Timer_bStart.Text = "Start";
            this.Timer_bStart.UseVisualStyleBackColor = true;
            this.Timer_bStart.Click += new System.EventHandler(this.Timer_bStart_Click);
            // 
            // Timer_bPause
            // 
            this.Timer_bPause.Location = new System.Drawing.Point(118, 108);
            this.Timer_bPause.Name = "Timer_bPause";
            this.Timer_bPause.Size = new System.Drawing.Size(75, 23);
            this.Timer_bPause.TabIndex = 1;
            this.Timer_bPause.Text = "Pause";
            this.Timer_bPause.UseVisualStyleBackColor = true;
            this.Timer_bPause.Click += new System.EventHandler(this.Timer_bPause_Click);
            // 
            // Timer_bStop
            // 
            this.Timer_bStop.Location = new System.Drawing.Point(229, 108);
            this.Timer_bStop.Name = "Timer_bStop";
            this.Timer_bStop.Size = new System.Drawing.Size(75, 23);
            this.Timer_bStop.TabIndex = 2;
            this.Timer_bStop.Text = "Stop";
            this.Timer_bStop.UseVisualStyleBackColor = true;
            this.Timer_bStop.Click += new System.EventHandler(this.Timer_bStop_Click);
            // 
            // Timer_tSetTime
            // 
            this.Timer_tSetTime.Location = new System.Drawing.Point(118, 15);
            this.Timer_tSetTime.Name = "Timer_tSetTime";
            this.Timer_tSetTime.Size = new System.Drawing.Size(109, 20);
            this.Timer_tSetTime.TabIndex = 3;
            this.Timer_tSetTime.Text = "hh:mm:ss";
            // 
            // Timer_lTextRemainingTime
            // 
            this.Timer_lTextRemainingTime.AutoSize = true;
            this.Timer_lTextRemainingTime.Location = new System.Drawing.Point(3, 65);
            this.Timer_lTextRemainingTime.Name = "Timer_lTextRemainingTime";
            this.Timer_lTextRemainingTime.Size = new System.Drawing.Size(86, 13);
            this.Timer_lTextRemainingTime.TabIndex = 4;
            this.Timer_lTextRemainingTime.Text = "Remaining Time:";
            // 
            // Timer_lRemainingTime
            // 
            this.Timer_lRemainingTime.AutoSize = true;
            this.Timer_lRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_lRemainingTime.Location = new System.Drawing.Point(108, 47);
            this.Timer_lRemainingTime.Name = "Timer_lRemainingTime";
            this.Timer_lRemainingTime.Size = new System.Drawing.Size(218, 51);
            this.Timer_lRemainingTime.TabIndex = 5;
            this.Timer_lRemainingTime.Text = "hh:mm:ss";
            // 
            // tabPicker
            // 
            this.tabPicker.Controls.Add(this.tabStopwatch);
            this.tabPicker.Controls.Add(this.tabTimer);
            this.tabPicker.Controls.Add(this.tabPomodoro);
            this.tabPicker.Controls.Add(this.tabManualAdd);
            this.tabPicker.Controls.Add(this.tabSetAsHabit);
            this.tabPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPicker.Location = new System.Drawing.Point(0, 0);
            this.tabPicker.Name = "tabPicker";
            this.tabPicker.SelectedIndex = 0;
            this.tabPicker.Size = new System.Drawing.Size(348, 218);
            this.tabPicker.TabIndex = 6;
            this.tabPicker.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPicker_Selecting);
            // 
            // tabStopwatch
            // 
            this.tabStopwatch.Controls.Add(this.Stop_bStop);
            this.tabStopwatch.Controls.Add(this.Stop_bPause);
            this.tabStopwatch.Controls.Add(this.Stop_bStart);
            this.tabStopwatch.Controls.Add(this.Stop_lTime);
            this.tabStopwatch.Location = new System.Drawing.Point(4, 22);
            this.tabStopwatch.Name = "tabStopwatch";
            this.tabStopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabStopwatch.Size = new System.Drawing.Size(340, 192);
            this.tabStopwatch.TabIndex = 1;
            this.tabStopwatch.Text = "Stopwatch";
            this.tabStopwatch.UseVisualStyleBackColor = true;
            // 
            // Stop_bStop
            // 
            this.Stop_bStop.Location = new System.Drawing.Point(230, 100);
            this.Stop_bStop.Name = "Stop_bStop";
            this.Stop_bStop.Size = new System.Drawing.Size(75, 23);
            this.Stop_bStop.TabIndex = 9;
            this.Stop_bStop.Text = "Stop";
            this.Stop_bStop.UseVisualStyleBackColor = true;
            this.Stop_bStop.Click += new System.EventHandler(this.Stop_bStop_Click);
            // 
            // Stop_bPause
            // 
            this.Stop_bPause.Location = new System.Drawing.Point(122, 100);
            this.Stop_bPause.Name = "Stop_bPause";
            this.Stop_bPause.Size = new System.Drawing.Size(75, 23);
            this.Stop_bPause.TabIndex = 8;
            this.Stop_bPause.Text = "Pause";
            this.Stop_bPause.UseVisualStyleBackColor = true;
            this.Stop_bPause.Click += new System.EventHandler(this.Stop_bPause_Click);
            // 
            // Stop_bStart
            // 
            this.Stop_bStart.Location = new System.Drawing.Point(18, 100);
            this.Stop_bStart.Name = "Stop_bStart";
            this.Stop_bStart.Size = new System.Drawing.Size(75, 23);
            this.Stop_bStart.TabIndex = 7;
            this.Stop_bStart.Text = "Start";
            this.Stop_bStart.UseVisualStyleBackColor = true;
            this.Stop_bStart.Click += new System.EventHandler(this.Stop_bStart_Click);
            // 
            // Stop_lTime
            // 
            this.Stop_lTime.AutoSize = true;
            this.Stop_lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_lTime.Location = new System.Drawing.Point(87, 19);
            this.Stop_lTime.Name = "Stop_lTime";
            this.Stop_lTime.Size = new System.Drawing.Size(198, 51);
            this.Stop_lTime.TabIndex = 6;
            this.Stop_lTime.Text = "00:00:00";
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.label1);
            this.tabTimer.Controls.Add(this.Timer_bSetTime);
            this.tabTimer.Controls.Add(this.Timer_lTextSetTheTime);
            this.tabTimer.Controls.Add(this.Timer_lTextRemainingTime);
            this.tabTimer.Controls.Add(this.Timer_lRemainingTime);
            this.tabTimer.Controls.Add(this.Timer_bStart);
            this.tabTimer.Controls.Add(this.Timer_bPause);
            this.tabTimer.Controls.Add(this.Timer_tSetTime);
            this.tabTimer.Controls.Add(this.Timer_bStop);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(340, 192);
            this.tabTimer.TabIndex = 0;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // Timer_bSetTime
            // 
            this.Timer_bSetTime.Location = new System.Drawing.Point(253, 15);
            this.Timer_bSetTime.Name = "Timer_bSetTime";
            this.Timer_bSetTime.Size = new System.Drawing.Size(51, 20);
            this.Timer_bSetTime.TabIndex = 7;
            this.Timer_bSetTime.Text = "Set";
            this.Timer_bSetTime.UseVisualStyleBackColor = true;
            this.Timer_bSetTime.Click += new System.EventHandler(this.Timer_bSet_Click);
            // 
            // Timer_lTextSetTheTime
            // 
            this.Timer_lTextSetTheTime.AutoSize = true;
            this.Timer_lTextSetTheTime.Location = new System.Drawing.Point(6, 18);
            this.Timer_lTextSetTheTime.Name = "Timer_lTextSetTheTime";
            this.Timer_lTextSetTheTime.Size = new System.Drawing.Size(66, 13);
            this.Timer_lTextSetTheTime.TabIndex = 6;
            this.Timer_lTextSetTheTime.Text = "Set the time:";
            // 
            // tabPomodoro
            // 
            this.tabPomodoro.Controls.Add(this.label2);
            this.tabPomodoro.Controls.Add(this.Pomod_lValueRemainingTime);
            this.tabPomodoro.Controls.Add(this.Pomod_lTextMode);
            this.tabPomodoro.Controls.Add(this.Pomod_bSetRestTime);
            this.tabPomodoro.Controls.Add(this.Pomod_tValueSetRestTimeMin);
            this.tabPomodoro.Controls.Add(this.Pomod_lTextSetRestTIme);
            this.tabPomodoro.Controls.Add(this.Pomod_bSetWorkTime);
            this.tabPomodoro.Controls.Add(this.Pomod_lTextSetWorkTime);
            this.tabPomodoro.Controls.Add(this.Pomod_lTextRemainingTime);
            this.tabPomodoro.Controls.Add(this.Pomod_bStart);
            this.tabPomodoro.Controls.Add(this.Pomod_bPause);
            this.tabPomodoro.Controls.Add(this.Pomod_tValueSetWorkTimeMin);
            this.tabPomodoro.Controls.Add(this.Pomod_bStop);
            this.tabPomodoro.Controls.Add(this.Pomod_lValueMode);
            this.tabPomodoro.Location = new System.Drawing.Point(4, 22);
            this.tabPomodoro.Name = "tabPomodoro";
            this.tabPomodoro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPomodoro.Size = new System.Drawing.Size(340, 192);
            this.tabPomodoro.TabIndex = 4;
            this.tabPomodoro.Text = "Pomodoro";
            this.tabPomodoro.UseVisualStyleBackColor = true;
            // 
            // Pomod_lValueRemainingTime
            // 
            this.Pomod_lValueRemainingTime.AutoSize = true;
            this.Pomod_lValueRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pomod_lValueRemainingTime.Location = new System.Drawing.Point(134, 105);
            this.Pomod_lValueRemainingTime.Name = "Pomod_lValueRemainingTime";
            this.Pomod_lValueRemainingTime.Size = new System.Drawing.Size(108, 33);
            this.Pomod_lValueRemainingTime.TabIndex = 13;
            this.Pomod_lValueRemainingTime.Text = "mm:ss";
            // 
            // Pomod_lTextMode
            // 
            this.Pomod_lTextMode.AutoSize = true;
            this.Pomod_lTextMode.Location = new System.Drawing.Point(64, 90);
            this.Pomod_lTextMode.Name = "Pomod_lTextMode";
            this.Pomod_lTextMode.Size = new System.Drawing.Size(37, 13);
            this.Pomod_lTextMode.TabIndex = 21;
            this.Pomod_lTextMode.Text = "Mode:";
            // 
            // Pomod_bSetRestTime
            // 
            this.Pomod_bSetRestTime.Location = new System.Drawing.Point(187, 54);
            this.Pomod_bSetRestTime.Name = "Pomod_bSetRestTime";
            this.Pomod_bSetRestTime.Size = new System.Drawing.Size(51, 20);
            this.Pomod_bSetRestTime.TabIndex = 18;
            this.Pomod_bSetRestTime.Text = "Set";
            this.Pomod_bSetRestTime.UseVisualStyleBackColor = true;
            this.Pomod_bSetRestTime.Click += new System.EventHandler(this.Pomod_bSetRestTime_Click);
            // 
            // Pomod_tValueSetRestTimeMin
            // 
            this.Pomod_tValueSetRestTimeMin.Location = new System.Drawing.Point(104, 51);
            this.Pomod_tValueSetRestTimeMin.Name = "Pomod_tValueSetRestTimeMin";
            this.Pomod_tValueSetRestTimeMin.Size = new System.Drawing.Size(63, 20);
            this.Pomod_tValueSetRestTimeMin.TabIndex = 17;
            this.Pomod_tValueSetRestTimeMin.Text = "5";
            // 
            // Pomod_lTextSetRestTIme
            // 
            this.Pomod_lTextSetRestTIme.AutoSize = true;
            this.Pomod_lTextSetRestTIme.Location = new System.Drawing.Point(15, 54);
            this.Pomod_lTextSetRestTIme.Name = "Pomod_lTextSetRestTIme";
            this.Pomod_lTextSetRestTIme.Size = new System.Drawing.Size(68, 13);
            this.Pomod_lTextSetRestTIme.TabIndex = 16;
            this.Pomod_lTextSetRestTIme.Text = "Set rest time:";
            // 
            // Pomod_bSetWorkTime
            // 
            this.Pomod_bSetWorkTime.Location = new System.Drawing.Point(187, 19);
            this.Pomod_bSetWorkTime.Name = "Pomod_bSetWorkTime";
            this.Pomod_bSetWorkTime.Size = new System.Drawing.Size(51, 20);
            this.Pomod_bSetWorkTime.TabIndex = 15;
            this.Pomod_bSetWorkTime.Text = "Set";
            this.Pomod_bSetWorkTime.UseVisualStyleBackColor = true;
            this.Pomod_bSetWorkTime.Click += new System.EventHandler(this.Pomod_bSetWorkTime_Click);
            // 
            // Pomod_lTextSetWorkTime
            // 
            this.Pomod_lTextSetWorkTime.AutoSize = true;
            this.Pomod_lTextSetWorkTime.Location = new System.Drawing.Point(15, 22);
            this.Pomod_lTextSetWorkTime.Name = "Pomod_lTextSetWorkTime";
            this.Pomod_lTextSetWorkTime.Size = new System.Drawing.Size(74, 13);
            this.Pomod_lTextSetWorkTime.TabIndex = 14;
            this.Pomod_lTextSetWorkTime.Text = "Set work time:";
            // 
            // Pomod_lTextRemainingTime
            // 
            this.Pomod_lTextRemainingTime.AutoSize = true;
            this.Pomod_lTextRemainingTime.Location = new System.Drawing.Point(15, 119);
            this.Pomod_lTextRemainingTime.Name = "Pomod_lTextRemainingTime";
            this.Pomod_lTextRemainingTime.Size = new System.Drawing.Size(86, 13);
            this.Pomod_lTextRemainingTime.TabIndex = 12;
            this.Pomod_lTextRemainingTime.Text = "Remaining Time:";
            // 
            // Pomod_bStart
            // 
            this.Pomod_bStart.Location = new System.Drawing.Point(14, 148);
            this.Pomod_bStart.Name = "Pomod_bStart";
            this.Pomod_bStart.Size = new System.Drawing.Size(75, 23);
            this.Pomod_bStart.TabIndex = 8;
            this.Pomod_bStart.Text = "Start";
            this.Pomod_bStart.UseVisualStyleBackColor = true;
            this.Pomod_bStart.Click += new System.EventHandler(this.Pomod_bStart_Click);
            // 
            // Pomod_bPause
            // 
            this.Pomod_bPause.Location = new System.Drawing.Point(121, 148);
            this.Pomod_bPause.Name = "Pomod_bPause";
            this.Pomod_bPause.Size = new System.Drawing.Size(75, 23);
            this.Pomod_bPause.TabIndex = 9;
            this.Pomod_bPause.Text = "Pause";
            this.Pomod_bPause.UseVisualStyleBackColor = true;
            this.Pomod_bPause.Click += new System.EventHandler(this.Pomod_bPause_Click);
            // 
            // Pomod_tValueSetWorkTimeMin
            // 
            this.Pomod_tValueSetWorkTimeMin.Location = new System.Drawing.Point(104, 19);
            this.Pomod_tValueSetWorkTimeMin.Name = "Pomod_tValueSetWorkTimeMin";
            this.Pomod_tValueSetWorkTimeMin.Size = new System.Drawing.Size(63, 20);
            this.Pomod_tValueSetWorkTimeMin.TabIndex = 11;
            this.Pomod_tValueSetWorkTimeMin.Text = "20";
            // 
            // Pomod_bStop
            // 
            this.Pomod_bStop.Location = new System.Drawing.Point(238, 148);
            this.Pomod_bStop.Name = "Pomod_bStop";
            this.Pomod_bStop.Size = new System.Drawing.Size(75, 23);
            this.Pomod_bStop.TabIndex = 10;
            this.Pomod_bStop.Text = "Stop";
            this.Pomod_bStop.UseVisualStyleBackColor = true;
            this.Pomod_bStop.Click += new System.EventHandler(this.Pomod_bStop_Click);
            // 
            // Pomod_lValueMode
            // 
            this.Pomod_lValueMode.AutoSize = true;
            this.Pomod_lValueMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pomod_lValueMode.Location = new System.Drawing.Point(135, 80);
            this.Pomod_lValueMode.Margin = new System.Windows.Forms.Padding(0);
            this.Pomod_lValueMode.Name = "Pomod_lValueMode";
            this.Pomod_lValueMode.Size = new System.Drawing.Size(62, 31);
            this.Pomod_lValueMode.TabIndex = 22;
            this.Pomod_lValueMode.Text = "Idle";
            // 
            // tabManualAdd
            // 
            this.tabManualAdd.Controls.Add(this.label3);
            this.tabManualAdd.Controls.Add(this.Manual_bAdd);
            this.tabManualAdd.Controls.Add(this.Manual_lTextSetTime);
            this.tabManualAdd.Controls.Add(this.Manual_tSetTime);
            this.tabManualAdd.Location = new System.Drawing.Point(4, 22);
            this.tabManualAdd.Name = "tabManualAdd";
            this.tabManualAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabManualAdd.Size = new System.Drawing.Size(340, 192);
            this.tabManualAdd.TabIndex = 2;
            this.tabManualAdd.Text = "Manual Add";
            this.tabManualAdd.UseVisualStyleBackColor = true;
            // 
            // Manual_bAdd
            // 
            this.Manual_bAdd.Location = new System.Drawing.Point(260, 18);
            this.Manual_bAdd.Name = "Manual_bAdd";
            this.Manual_bAdd.Size = new System.Drawing.Size(51, 20);
            this.Manual_bAdd.TabIndex = 10;
            this.Manual_bAdd.Text = "Add";
            this.Manual_bAdd.UseVisualStyleBackColor = true;
            this.Manual_bAdd.Click += new System.EventHandler(this.bManualAdd_Click);
            // 
            // Manual_lTextSetTime
            // 
            this.Manual_lTextSetTime.AutoSize = true;
            this.Manual_lTextSetTime.Location = new System.Drawing.Point(11, 21);
            this.Manual_lTextSetTime.Name = "Manual_lTextSetTime";
            this.Manual_lTextSetTime.Size = new System.Drawing.Size(66, 13);
            this.Manual_lTextSetTime.TabIndex = 9;
            this.Manual_lTextSetTime.Text = "Set the time:";
            // 
            // Manual_tSetTime
            // 
            this.Manual_tSetTime.Location = new System.Drawing.Point(110, 18);
            this.Manual_tSetTime.Name = "Manual_tSetTime";
            this.Manual_tSetTime.Size = new System.Drawing.Size(109, 20);
            this.Manual_tSetTime.TabIndex = 8;
            this.Manual_tSetTime.Text = "hh:mm:ss";
            // 
            // tabSetAsHabit
            // 
            this.tabSetAsHabit.Controls.Add(this.label4);
            this.tabSetAsHabit.Controls.Add(this.Habit_lTextSetTheTime);
            this.tabSetAsHabit.Controls.Add(this.Habit_lTextMinPerDay);
            this.tabSetAsHabit.Controls.Add(this.Habit_bSetAsHabit);
            this.tabSetAsHabit.Controls.Add(this.Habit_tSetTime);
            this.tabSetAsHabit.Controls.Add(this.Habit_bRemoveFromHabbits);
            this.tabSetAsHabit.Controls.Add(this.Habit_lValueMinPerDay);
            this.tabSetAsHabit.Location = new System.Drawing.Point(4, 22);
            this.tabSetAsHabit.Name = "tabSetAsHabit";
            this.tabSetAsHabit.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetAsHabit.Size = new System.Drawing.Size(340, 192);
            this.tabSetAsHabit.TabIndex = 3;
            this.tabSetAsHabit.Text = "Set as Habit";
            this.tabSetAsHabit.UseVisualStyleBackColor = true;
            // 
            // Habit_lTextSetTheTime
            // 
            this.Habit_lTextSetTheTime.AutoSize = true;
            this.Habit_lTextSetTheTime.Location = new System.Drawing.Point(14, 26);
            this.Habit_lTextSetTheTime.Name = "Habit_lTextSetTheTime";
            this.Habit_lTextSetTheTime.Size = new System.Drawing.Size(66, 13);
            this.Habit_lTextSetTheTime.TabIndex = 14;
            this.Habit_lTextSetTheTime.Text = "Set the time:";
            // 
            // Habit_lTextMinPerDay
            // 
            this.Habit_lTextMinPerDay.AutoSize = true;
            this.Habit_lTextMinPerDay.Location = new System.Drawing.Point(29, 79);
            this.Habit_lTextMinPerDay.Name = "Habit_lTextMinPerDay";
            this.Habit_lTextMinPerDay.Size = new System.Drawing.Size(51, 13);
            this.Habit_lTextMinPerDay.TabIndex = 12;
            this.Habit_lTextMinPerDay.Text = "min/day :";
            // 
            // Habit_bSetAsHabit
            // 
            this.Habit_bSetAsHabit.Location = new System.Drawing.Point(17, 114);
            this.Habit_bSetAsHabit.Name = "Habit_bSetAsHabit";
            this.Habit_bSetAsHabit.Size = new System.Drawing.Size(75, 23);
            this.Habit_bSetAsHabit.TabIndex = 8;
            this.Habit_bSetAsHabit.Text = "Set As Habit";
            this.Habit_bSetAsHabit.UseVisualStyleBackColor = true;
            this.Habit_bSetAsHabit.Click += new System.EventHandler(this.bSetAsHabit_Click);
            // 
            // Habit_tSetTime
            // 
            this.Habit_tSetTime.Location = new System.Drawing.Point(113, 23);
            this.Habit_tSetTime.Name = "Habit_tSetTime";
            this.Habit_tSetTime.Size = new System.Drawing.Size(109, 20);
            this.Habit_tSetTime.TabIndex = 11;
            this.Habit_tSetTime.Text = "hh:mm:ss";
            // 
            // Habit_bRemoveFromHabbits
            // 
            this.Habit_bRemoveFromHabbits.Location = new System.Drawing.Point(192, 114);
            this.Habit_bRemoveFromHabbits.Name = "Habit_bRemoveFromHabbits";
            this.Habit_bRemoveFromHabbits.Size = new System.Drawing.Size(123, 23);
            this.Habit_bRemoveFromHabbits.TabIndex = 10;
            this.Habit_bRemoveFromHabbits.Text = "Remove From Habbits";
            this.Habit_bRemoveFromHabbits.UseVisualStyleBackColor = true;
            this.Habit_bRemoveFromHabbits.Click += new System.EventHandler(this.Habit_bRemoveFromHabbits_Click);
            // 
            // Habit_lValueMinPerDay
            // 
            this.Habit_lValueMinPerDay.AutoSize = true;
            this.Habit_lValueMinPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Habit_lValueMinPerDay.Location = new System.Drawing.Point(142, 56);
            this.Habit_lValueMinPerDay.Name = "Habit_lValueMinPerDay";
            this.Habit_lValueMinPerDay.Size = new System.Drawing.Size(47, 51);
            this.Habit_lValueMinPerDay.TabIndex = 13;
            this.Habit_lValueMinPerDay.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Format: min, mm:ss, hh:mm:ss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(102, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "Format: min, mm:ss, hh:mm:ss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(108, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Format: min, mm:ss, hh:mm:ss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(111, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "Format: min, mm:ss, hh:mm:ss";
            // 
            // ActivityTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPicker);
            this.Name = "ActivityTimer";
            this.Size = new System.Drawing.Size(348, 218);
            this.tabPicker.ResumeLayout(false);
            this.tabStopwatch.ResumeLayout(false);
            this.tabStopwatch.PerformLayout();
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            this.tabPomodoro.ResumeLayout(false);
            this.tabPomodoro.PerformLayout();
            this.tabManualAdd.ResumeLayout(false);
            this.tabManualAdd.PerformLayout();
            this.tabSetAsHabit.ResumeLayout(false);
            this.tabSetAsHabit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Stop_timerSecond;
        private System.Windows.Forms.Button Timer_bStart;
        private System.Windows.Forms.Button Timer_bPause;
        private System.Windows.Forms.Button Timer_bStop;
        private System.Windows.Forms.TextBox Timer_tSetTime;
        private System.Windows.Forms.Label Timer_lTextRemainingTime;
        private System.Windows.Forms.Label Timer_lRemainingTime;
        private System.Windows.Forms.TabControl tabPicker;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage tabStopwatch;
        private System.Windows.Forms.Button Timer_bSetTime;
        private System.Windows.Forms.Label Timer_lTextSetTheTime;
        private System.Windows.Forms.Button Stop_bStop;
        private System.Windows.Forms.Button Stop_bPause;
        private System.Windows.Forms.Button Stop_bStart;
        private System.Windows.Forms.Label Stop_lTime;
        private System.Windows.Forms.TabPage tabManualAdd;
        private System.Windows.Forms.Button Manual_bAdd;
        private System.Windows.Forms.Label Manual_lTextSetTime;
        private System.Windows.Forms.TextBox Manual_tSetTime;
        private System.Windows.Forms.TabPage tabSetAsHabit;
        private System.Windows.Forms.Label Habit_lTextSetTheTime;
        private System.Windows.Forms.Label Habit_lTextMinPerDay;
        private System.Windows.Forms.Label Habit_lValueMinPerDay;
        private System.Windows.Forms.Button Habit_bSetAsHabit;
        private System.Windows.Forms.TextBox Habit_tSetTime;
        private System.Windows.Forms.Button Habit_bRemoveFromHabbits;
        private System.Windows.Forms.TabPage tabPomodoro;
        private System.Windows.Forms.Label Pomod_lTextSetRestTIme;
        private System.Windows.Forms.Button Pomod_bSetWorkTime;
        private System.Windows.Forms.Label Pomod_lTextSetWorkTime;
        private System.Windows.Forms.Label Pomod_lTextRemainingTime;
        private System.Windows.Forms.Label Pomod_lValueRemainingTime;
        private System.Windows.Forms.Button Pomod_bStart;
        private System.Windows.Forms.Button Pomod_bPause;
        private System.Windows.Forms.TextBox Pomod_tValueSetWorkTimeMin;
        private System.Windows.Forms.Button Pomod_bStop;
        private System.Windows.Forms.Button Pomod_bSetRestTime;
        private System.Windows.Forms.TextBox Pomod_tValueSetRestTimeMin;
        private System.Windows.Forms.Label Pomod_lTextMode;
        private System.Windows.Forms.Label Pomod_lValueMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
