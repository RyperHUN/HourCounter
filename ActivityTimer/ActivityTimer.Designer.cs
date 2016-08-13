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
            this.Timer_timerSecond = new System.Windows.Forms.Timer(this.components);
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
            this.tabPomodoro = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPicker.SuspendLayout();
            this.tabStopwatch.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.tabManualAdd.SuspendLayout();
            this.tabSetAsHabit.SuspendLayout();
            this.tabPomodoro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer_timerSecond
            // 
            this.Timer_timerSecond.Tick += new System.EventHandler(this.Timer_timerSecond_Tick);
            // 
            // Stop_timerSecond
            // 
            this.Stop_timerSecond.Tick += new System.EventHandler(this.Stop_stopwatchSecond_Tick);
            // 
            // Timer_bStart
            // 
            this.Timer_bStart.Location = new System.Drawing.Point(6, 100);
            this.Timer_bStart.Name = "Timer_bStart";
            this.Timer_bStart.Size = new System.Drawing.Size(75, 23);
            this.Timer_bStart.TabIndex = 0;
            this.Timer_bStart.Text = "Start";
            this.Timer_bStart.UseVisualStyleBackColor = true;
            this.Timer_bStart.Click += new System.EventHandler(this.Timer_bStart_Click);
            // 
            // Timer_bPause
            // 
            this.Timer_bPause.Location = new System.Drawing.Point(118, 100);
            this.Timer_bPause.Name = "Timer_bPause";
            this.Timer_bPause.Size = new System.Drawing.Size(75, 23);
            this.Timer_bPause.TabIndex = 1;
            this.Timer_bPause.Text = "Pause";
            this.Timer_bPause.UseVisualStyleBackColor = true;
            this.Timer_bPause.Click += new System.EventHandler(this.Timer_bPause_Click);
            // 
            // Timer_bStop
            // 
            this.Timer_bStop.Location = new System.Drawing.Point(229, 100);
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
            this.Timer_lTextRemainingTime.Location = new System.Drawing.Point(3, 57);
            this.Timer_lTextRemainingTime.Name = "Timer_lTextRemainingTime";
            this.Timer_lTextRemainingTime.Size = new System.Drawing.Size(86, 13);
            this.Timer_lTextRemainingTime.TabIndex = 4;
            this.Timer_lTextRemainingTime.Text = "Remaining Time:";
            // 
            // Timer_lRemainingTime
            // 
            this.Timer_lRemainingTime.AutoSize = true;
            this.Timer_lRemainingTime.Font = new System.Drawing.Font("Adobe Devanagari", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_lRemainingTime.Location = new System.Drawing.Point(108, 39);
            this.Timer_lRemainingTime.Name = "Timer_lRemainingTime";
            this.Timer_lRemainingTime.Size = new System.Drawing.Size(185, 58);
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
            this.tabPicker.Location = new System.Drawing.Point(0, 3);
            this.tabPicker.Name = "tabPicker";
            this.tabPicker.SelectedIndex = 0;
            this.tabPicker.Size = new System.Drawing.Size(346, 213);
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
            this.tabStopwatch.Size = new System.Drawing.Size(337, 212);
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
            this.Stop_lTime.Font = new System.Drawing.Font("Adobe Devanagari", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_lTime.Location = new System.Drawing.Point(87, 19);
            this.Stop_lTime.Name = "Stop_lTime";
            this.Stop_lTime.Size = new System.Drawing.Size(159, 58);
            this.Stop_lTime.TabIndex = 6;
            this.Stop_lTime.Text = "00:00:00";
            // 
            // tabTimer
            // 
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
            this.tabTimer.Size = new System.Drawing.Size(337, 201);
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
            // tabManualAdd
            // 
            this.tabManualAdd.Controls.Add(this.Manual_bAdd);
            this.tabManualAdd.Controls.Add(this.Manual_lTextSetTime);
            this.tabManualAdd.Controls.Add(this.Manual_tSetTime);
            this.tabManualAdd.Location = new System.Drawing.Point(4, 22);
            this.tabManualAdd.Name = "tabManualAdd";
            this.tabManualAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabManualAdd.Size = new System.Drawing.Size(337, 212);
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
            this.tabSetAsHabit.Controls.Add(this.Habit_lTextSetTheTime);
            this.tabSetAsHabit.Controls.Add(this.Habit_lTextMinPerDay);
            this.tabSetAsHabit.Controls.Add(this.Habit_bSetAsHabit);
            this.tabSetAsHabit.Controls.Add(this.Habit_tSetTime);
            this.tabSetAsHabit.Controls.Add(this.Habit_bRemoveFromHabbits);
            this.tabSetAsHabit.Controls.Add(this.Habit_lValueMinPerDay);
            this.tabSetAsHabit.Location = new System.Drawing.Point(4, 22);
            this.tabSetAsHabit.Name = "tabSetAsHabit";
            this.tabSetAsHabit.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetAsHabit.Size = new System.Drawing.Size(337, 212);
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
            this.Habit_lTextMinPerDay.Location = new System.Drawing.Point(29, 69);
            this.Habit_lTextMinPerDay.Name = "Habit_lTextMinPerDay";
            this.Habit_lTextMinPerDay.Size = new System.Drawing.Size(51, 13);
            this.Habit_lTextMinPerDay.TabIndex = 12;
            this.Habit_lTextMinPerDay.Text = "min/day :";
            // 
            // Habit_bSetAsHabit
            // 
            this.Habit_bSetAsHabit.Location = new System.Drawing.Point(17, 104);
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
            this.Habit_bRemoveFromHabbits.Location = new System.Drawing.Point(192, 104);
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
            this.Habit_lValueMinPerDay.Font = new System.Drawing.Font("Adobe Devanagari", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Habit_lValueMinPerDay.Location = new System.Drawing.Point(142, 46);
            this.Habit_lValueMinPerDay.Name = "Habit_lValueMinPerDay";
            this.Habit_lValueMinPerDay.Size = new System.Drawing.Size(44, 58);
            this.Habit_lValueMinPerDay.TabIndex = 13;
            this.Habit_lValueMinPerDay.Text = "0";
            // 
            // tabPomodoro
            // 
            this.tabPomodoro.Controls.Add(this.label4);
            this.tabPomodoro.Controls.Add(this.button1);
            this.tabPomodoro.Controls.Add(this.label1);
            this.tabPomodoro.Controls.Add(this.label2);
            this.tabPomodoro.Controls.Add(this.label3);
            this.tabPomodoro.Controls.Add(this.button2);
            this.tabPomodoro.Controls.Add(this.button3);
            this.tabPomodoro.Controls.Add(this.textBox1);
            this.tabPomodoro.Controls.Add(this.button4);
            this.tabPomodoro.Location = new System.Drawing.Point(4, 22);
            this.tabPomodoro.Name = "tabPomodoro";
            this.tabPomodoro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPomodoro.Size = new System.Drawing.Size(338, 187);
            this.tabPomodoro.TabIndex = 4;
            this.tabPomodoro.Text = "Pomodoro";
            this.tabPomodoro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set work time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Remaining Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Devanagari", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 58);
            this.label3.TabIndex = 13;
            this.label3.Text = "hh:mm:ss";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "hh:mm:ss";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Set work time:";
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
            this.tabManualAdd.ResumeLayout(false);
            this.tabManualAdd.PerformLayout();
            this.tabSetAsHabit.ResumeLayout(false);
            this.tabSetAsHabit.PerformLayout();
            this.tabPomodoro.ResumeLayout(false);
            this.tabPomodoro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_timerSecond;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}
