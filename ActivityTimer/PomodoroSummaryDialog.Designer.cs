namespace ActivityTimer
{
    partial class PomodoroSummaryDialog
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
            this.lWorkTime = new System.Windows.Forms.Label();
            this.lRestTime = new System.Windows.Forms.Label();
            this.tWorkTime = new System.Windows.Forms.TextBox();
            this.tRestTime = new System.Windows.Forms.TextBox();
            this.cIncludeRestTime = new System.Windows.Forms.CheckBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lWorkTime
            // 
            this.lWorkTime.AutoSize = true;
            this.lWorkTime.Location = new System.Drawing.Point(13, 13);
            this.lWorkTime.Name = "lWorkTime";
            this.lWorkTime.Size = new System.Drawing.Size(62, 13);
            this.lWorkTime.TabIndex = 0;
            this.lWorkTime.Text = "Work Time:";
            // 
            // lRestTime
            // 
            this.lRestTime.AutoSize = true;
            this.lRestTime.Location = new System.Drawing.Point(13, 42);
            this.lRestTime.Name = "lRestTime";
            this.lRestTime.Size = new System.Drawing.Size(58, 13);
            this.lRestTime.TabIndex = 1;
            this.lRestTime.Text = "Rest Time:";
            // 
            // tWorkTime
            // 
            this.tWorkTime.Location = new System.Drawing.Point(81, 10);
            this.tWorkTime.Name = "tWorkTime";
            this.tWorkTime.Size = new System.Drawing.Size(68, 20);
            this.tWorkTime.TabIndex = 3;
            // 
            // tRestTime
            // 
            this.tRestTime.Location = new System.Drawing.Point(81, 39);
            this.tRestTime.Name = "tRestTime";
            this.tRestTime.Size = new System.Drawing.Size(68, 20);
            this.tRestTime.TabIndex = 4;
            // 
            // cIncludeRestTime
            // 
            this.cIncludeRestTime.AutoSize = true;
            this.cIncludeRestTime.Location = new System.Drawing.Point(81, 65);
            this.cIncludeRestTime.Name = "cIncludeRestTime";
            this.cIncludeRestTime.Size = new System.Drawing.Size(108, 17);
            this.cIncludeRestTime.TabIndex = 5;
            this.cIncludeRestTime.Text = "Include Rest time";
            this.cIncludeRestTime.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(13, 94);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(144, 94);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // PomodoroSummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 129);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.cIncludeRestTime);
            this.Controls.Add(this.tRestTime);
            this.Controls.Add(this.tWorkTime);
            this.Controls.Add(this.lRestTime);
            this.Controls.Add(this.lWorkTime);
            this.Name = "PomodoroSummaryDialog";
            this.Text = "PomodoroSummaryDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWorkTime;
        private System.Windows.Forms.Label lRestTime;
        private System.Windows.Forms.TextBox tWorkTime;
        private System.Windows.Forms.TextBox tRestTime;
        private System.Windows.Forms.CheckBox cIncludeRestTime;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
    }
}