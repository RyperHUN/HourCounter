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
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.timerStopwatchSecond = new System.Windows.Forms.Timer(this.components);
            this.bTimerStart = new System.Windows.Forms.Button();
            this.bTimerPause = new System.Windows.Forms.Button();
            this.bTimerStop = new System.Windows.Forms.Button();
            this.tSetTime = new System.Windows.Forms.TextBox();
            this.lTextRemainingTime = new System.Windows.Forms.Label();
            this.lRemainingTime = new System.Windows.Forms.Label();
            this.tabPicker = new System.Windows.Forms.TabControl();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.bSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Stopwatch = new System.Windows.Forms.TabPage();
            this.bStopStop = new System.Windows.Forms.Button();
            this.bStopPause = new System.Windows.Forms.Button();
            this.bStopStart = new System.Windows.Forms.Button();
            this.lStopTime = new System.Windows.Forms.Label();
            this.tabPicker.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.Stopwatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSecond
            // 
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // stopwatchSecond
            // 
            this.timerStopwatchSecond.Tick += new System.EventHandler(this.stopwatchSecond_Tick);
            // 
            // bTimerStart
            // 
            this.bTimerStart.Location = new System.Drawing.Point(6, 100);
            this.bTimerStart.Name = "bTimerStart";
            this.bTimerStart.Size = new System.Drawing.Size(75, 23);
            this.bTimerStart.TabIndex = 0;
            this.bTimerStart.Text = "Start";
            this.bTimerStart.UseVisualStyleBackColor = true;
            this.bTimerStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bTimerPause
            // 
            this.bTimerPause.Location = new System.Drawing.Point(118, 100);
            this.bTimerPause.Name = "bTimerPause";
            this.bTimerPause.Size = new System.Drawing.Size(75, 23);
            this.bTimerPause.TabIndex = 1;
            this.bTimerPause.Text = "Pause";
            this.bTimerPause.UseVisualStyleBackColor = true;
            this.bTimerPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bTimerStop
            // 
            this.bTimerStop.Location = new System.Drawing.Point(229, 100);
            this.bTimerStop.Name = "bTimerStop";
            this.bTimerStop.Size = new System.Drawing.Size(75, 23);
            this.bTimerStop.TabIndex = 2;
            this.bTimerStop.Text = "Stop";
            this.bTimerStop.UseVisualStyleBackColor = true;
            this.bTimerStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // tSetTime
            // 
            this.tSetTime.Location = new System.Drawing.Point(118, 15);
            this.tSetTime.Name = "tSetTime";
            this.tSetTime.Size = new System.Drawing.Size(109, 20);
            this.tSetTime.TabIndex = 3;
            this.tSetTime.Text = "hh:mm:ss";
            // 
            // lTextRemainingTime
            // 
            this.lTextRemainingTime.AutoSize = true;
            this.lTextRemainingTime.Location = new System.Drawing.Point(3, 57);
            this.lTextRemainingTime.Name = "lTextRemainingTime";
            this.lTextRemainingTime.Size = new System.Drawing.Size(86, 13);
            this.lTextRemainingTime.TabIndex = 4;
            this.lTextRemainingTime.Text = "Remaining Time:";
            // 
            // lRemainingTime
            // 
            this.lRemainingTime.AutoSize = true;
            this.lRemainingTime.Font = new System.Drawing.Font("Adobe Devanagari", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRemainingTime.Location = new System.Drawing.Point(108, 39);
            this.lRemainingTime.Name = "lRemainingTime";
            this.lRemainingTime.Size = new System.Drawing.Size(185, 58);
            this.lRemainingTime.TabIndex = 5;
            this.lRemainingTime.Text = "hh:mm:ss";
            // 
            // tabPicker
            // 
            this.tabPicker.Controls.Add(this.tabTimer);
            this.tabPicker.Controls.Add(this.Stopwatch);
            this.tabPicker.Location = new System.Drawing.Point(0, 3);
            this.tabPicker.Name = "tabPicker";
            this.tabPicker.SelectedIndex = 0;
            this.tabPicker.Size = new System.Drawing.Size(345, 238);
            this.tabPicker.TabIndex = 6;
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.bSet);
            this.tabTimer.Controls.Add(this.label1);
            this.tabTimer.Controls.Add(this.lTextRemainingTime);
            this.tabTimer.Controls.Add(this.lRemainingTime);
            this.tabTimer.Controls.Add(this.bTimerStart);
            this.tabTimer.Controls.Add(this.bTimerPause);
            this.tabTimer.Controls.Add(this.tSetTime);
            this.tabTimer.Controls.Add(this.bTimerStop);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(337, 212);
            this.tabTimer.TabIndex = 0;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(253, 15);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(51, 20);
            this.bSet.TabIndex = 7;
            this.bSet.Text = "Set";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set the time:";
            // 
            // Stopwatch
            // 
            this.Stopwatch.Controls.Add(this.bStopStop);
            this.Stopwatch.Controls.Add(this.bStopPause);
            this.Stopwatch.Controls.Add(this.bStopStart);
            this.Stopwatch.Controls.Add(this.lStopTime);
            this.Stopwatch.Location = new System.Drawing.Point(4, 22);
            this.Stopwatch.Name = "Stopwatch";
            this.Stopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.Stopwatch.Size = new System.Drawing.Size(337, 212);
            this.Stopwatch.TabIndex = 1;
            this.Stopwatch.Text = "tabStopwatch";
            this.Stopwatch.UseVisualStyleBackColor = true;
            // 
            // bStopStop
            // 
            this.bStopStop.Location = new System.Drawing.Point(230, 100);
            this.bStopStop.Name = "bStopStop";
            this.bStopStop.Size = new System.Drawing.Size(75, 23);
            this.bStopStop.TabIndex = 9;
            this.bStopStop.Text = "Stop";
            this.bStopStop.UseVisualStyleBackColor = true;
            this.bStopStop.Click += new System.EventHandler(this.bStopStop_Click);
            // 
            // bStopPause
            // 
            this.bStopPause.Location = new System.Drawing.Point(122, 100);
            this.bStopPause.Name = "bStopPause";
            this.bStopPause.Size = new System.Drawing.Size(75, 23);
            this.bStopPause.TabIndex = 8;
            this.bStopPause.Text = "Pause";
            this.bStopPause.UseVisualStyleBackColor = true;
            this.bStopPause.Click += new System.EventHandler(this.bStopPause_Click);
            // 
            // bStopStart
            // 
            this.bStopStart.Location = new System.Drawing.Point(18, 100);
            this.bStopStart.Name = "bStopStart";
            this.bStopStart.Size = new System.Drawing.Size(75, 23);
            this.bStopStart.TabIndex = 7;
            this.bStopStart.Text = "Start";
            this.bStopStart.UseVisualStyleBackColor = true;
            this.bStopStart.Click += new System.EventHandler(this.bStopStart_Click);
            // 
            // lStopTime
            // 
            this.lStopTime.AutoSize = true;
            this.lStopTime.Font = new System.Drawing.Font("Adobe Devanagari", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStopTime.Location = new System.Drawing.Point(87, 19);
            this.lStopTime.Name = "lStopTime";
            this.lStopTime.Size = new System.Drawing.Size(159, 58);
            this.lStopTime.TabIndex = 6;
            this.lStopTime.Text = "00:00:00";
            // 
            // ActivityTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPicker);
            this.Name = "ActivityTimer";
            this.Size = new System.Drawing.Size(345, 169);
            this.tabPicker.ResumeLayout(false);
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            this.Stopwatch.ResumeLayout(false);
            this.Stopwatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Timer timerStopwatchSecond;
        private System.Windows.Forms.Button bTimerStart;
        private System.Windows.Forms.Button bTimerPause;
        private System.Windows.Forms.Button bTimerStop;
        private System.Windows.Forms.TextBox tSetTime;
        private System.Windows.Forms.Label lTextRemainingTime;
        private System.Windows.Forms.Label lRemainingTime;
        private System.Windows.Forms.TabControl tabPicker;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage Stopwatch;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStopStop;
        private System.Windows.Forms.Button bStopPause;
        private System.Windows.Forms.Button bStopStart;
        private System.Windows.Forms.Label lStopTime;
    }
}
