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
            this.lRemainingTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPicker = new System.Windows.Forms.TabControl();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPicker.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(6, 100);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(118, 100);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(75, 23);
            this.bPause.TabIndex = 1;
            this.bPause.Text = "Pause";
            this.bPause.UseVisualStyleBackColor = true;
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(229, 100);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            // 
            // tSetTime
            // 
            this.tSetTime.Location = new System.Drawing.Point(118, 15);
            this.tSetTime.Name = "tSetTime";
            this.tSetTime.Size = new System.Drawing.Size(109, 20);
            this.tSetTime.TabIndex = 3;
            // 
            // lRemainingTime
            // 
            this.lRemainingTime.AutoSize = true;
            this.lRemainingTime.Location = new System.Drawing.Point(3, 57);
            this.lRemainingTime.Name = "lRemainingTime";
            this.lRemainingTime.Size = new System.Drawing.Size(86, 13);
            this.lRemainingTime.TabIndex = 4;
            this.lRemainingTime.Text = "Remaining Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // tabPicker
            // 
            this.tabPicker.Controls.Add(this.tabTimer);
            this.tabPicker.Controls.Add(this.tabPage2);
            this.tabPicker.Location = new System.Drawing.Point(0, 3);
            this.tabPicker.Name = "tabPicker";
            this.tabPicker.SelectedIndex = 0;
            this.tabPicker.Size = new System.Drawing.Size(373, 388);
            this.tabPicker.TabIndex = 6;
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.button1);
            this.tabTimer.Controls.Add(this.label1);
            this.tabTimer.Controls.Add(this.lRemainingTime);
            this.tabTimer.Controls.Add(this.label2);
            this.tabTimer.Controls.Add(this.bStart);
            this.tabTimer.Controls.Add(this.bPause);
            this.tabTimer.Controls.Add(this.tSetTime);
            this.tabTimer.Controls.Add(this.bStop);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(365, 362);
            this.tabTimer.TabIndex = 0;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ActivityTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPicker);
            this.Name = "ActivityTimer";
            this.Size = new System.Drawing.Size(377, 270);
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
        private System.Windows.Forms.Label lRemainingTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabPicker;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
