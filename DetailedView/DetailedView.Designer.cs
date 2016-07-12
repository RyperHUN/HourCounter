namespace DetailedView
{
    partial class DetailedView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.lActivityName = new System.Windows.Forms.Label();
            this.lTextTimeSpentOnActivity = new System.Windows.Forms.Label();
            this.lTimeSpentOnActivity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lActivityName
            // 
            this.lActivityName.AutoSize = true;
            this.lActivityName.Font = new System.Drawing.Font("Adobe Devanagari", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActivityName.Location = new System.Drawing.Point(57, 25);
            this.lActivityName.Name = "lActivityName";
            this.lActivityName.Size = new System.Drawing.Size(163, 37);
            this.lActivityName.TabIndex = 0;
            this.lActivityName.Text = "Activity Name";
            // 
            // lTextTimeSpentOnActivity
            // 
            this.lTextTimeSpentOnActivity.AutoSize = true;
            this.lTextTimeSpentOnActivity.Location = new System.Drawing.Point(19, 80);
            this.lTextTimeSpentOnActivity.Name = "lTextTimeSpentOnActivity";
            this.lTextTimeSpentOnActivity.Size = new System.Drawing.Size(118, 13);
            this.lTextTimeSpentOnActivity.TabIndex = 1;
            this.lTextTimeSpentOnActivity.Text = "Time Spent On Activity:";
            // 
            // lTimeSpentOnActivity
            // 
            this.lTimeSpentOnActivity.AutoSize = true;
            this.lTimeSpentOnActivity.Location = new System.Drawing.Point(172, 80);
            this.lTimeSpentOnActivity.Name = "lTimeSpentOnActivity";
            this.lTimeSpentOnActivity.Size = new System.Drawing.Size(48, 13);
            this.lTimeSpentOnActivity.TabIndex = 2;
            this.lTimeSpentOnActivity.Text = "28h 30m";
            // 
            // DetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lTimeSpentOnActivity);
            this.Controls.Add(this.lActivityName);
            this.Controls.Add(this.lTextTimeSpentOnActivity);
            this.Name = "DetailedView";
            this.Size = new System.Drawing.Size(305, 201);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lActivityName;
        private System.Windows.Forms.Label lTextTimeSpentOnActivity;
        private System.Windows.Forms.Label lTimeSpentOnActivity;
    }
}
