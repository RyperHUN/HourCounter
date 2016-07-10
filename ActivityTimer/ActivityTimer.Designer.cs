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
            this.timerFullTime = new System.Windows.Forms.Timer(this.components);
            this.bStart = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.tSetTime = new System.Windows.Forms.TextBox();
            this.lTextRemainingTime = new System.Windows.Forms.Label();
            this.lRemainingTime = new System.Windows.Forms.Label();
            this.tabPicker = new System.Windows.Forms.TabControl();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.bSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPicker.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSecond
            // 
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(6, 100);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(118, 100);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(75, 23);
            this.bPause.TabIndex = 1;
            this.bPause.Text = "Pause";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(229, 100);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
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
            this.tabPicker.Controls.Add(this.tabPage2);
            this.tabPicker.Location = new System.Drawing.Point(0, 3);
            this.tabPicker.Name = "tabPicker";
            this.tabPicker.SelectedIndex = 0;
            this.tabPicker.Size = new System.Drawing.Size(374, 264);
            this.tabPicker.TabIndex = 6;
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.bSet);
            this.tabTimer.Controls.Add(this.label1);
            this.tabTimer.Controls.Add(this.lTextRemainingTime);
            this.tabTimer.Controls.Add(this.lRemainingTime);
            this.tabTimer.Controls.Add(this.bStart);
            this.tabTimer.Controls.Add(this.bPause);
            this.tabTimer.Controls.Add(this.tSetTime);
            this.tabTimer.Controls.Add(this.bStop);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(366, 238);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Timer timerFullTime;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.TextBox tSetTime;
        private System.Windows.Forms.Label lTextRemainingTime;
        private System.Windows.Forms.Label lRemainingTime;
        private System.Windows.Forms.TabControl tabPicker;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Label label1;
    }
}
