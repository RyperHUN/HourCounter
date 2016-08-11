namespace HabitUtils
{
    partial class EditableHabitLine
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
            this.lStatus = new System.Windows.Forms.Label ();
            this.tAddingTime = new System.Windows.Forms.TextBox ();
            this.bAdd = new System.Windows.Forms.Button ();
            this.bDoNothing = new System.Windows.Forms.Button ();
            this.lActivityName = new System.Windows.Forms.Label ();
            this.SuspendLayout ();
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lStatus.Location = new System.Drawing.Point (366, 17);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size (125, 15);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Status: Do nothing";
            // 
            // tAddingTime
            // 
            this.tAddingTime.Location = new System.Drawing.Point (162, 14);
            this.tAddingTime.Name = "tAddingTime";
            this.tAddingTime.Size = new System.Drawing.Size (67, 20);
            this.tAddingTime.TabIndex = 1;
            this.tAddingTime.Text = "hh:mm:ss";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point (235, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size (43, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler (this.bAdd_Click);
            // 
            // bDoNothing
            // 
            this.bDoNothing.Location = new System.Drawing.Point (284, 12);
            this.bDoNothing.Name = "bDoNothing";
            this.bDoNothing.Size = new System.Drawing.Size (76, 23);
            this.bDoNothing.TabIndex = 3;
            this.bDoNothing.Text = "Do nothing";
            this.bDoNothing.UseVisualStyleBackColor = true;
            this.bDoNothing.Click += new System.EventHandler (this.bDoNothing_Click);
            // 
            // lActivityName
            // 
            this.lActivityName.AutoSize = true;
            this.lActivityName.Font = new System.Drawing.Font ("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lActivityName.Location = new System.Drawing.Point (5, 14);
            this.lActivityName.Name = "lActivityName";
            this.lActivityName.Size = new System.Drawing.Size (109, 18);
            this.lActivityName.TabIndex = 4;
            this.lActivityName.Text = "lActivityName";
            // 
            // EditableHabitLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add (this.lActivityName);
            this.Controls.Add (this.bDoNothing);
            this.Controls.Add (this.bAdd);
            this.Controls.Add (this.tAddingTime);
            this.Controls.Add (this.lStatus);
            this.Name = "EditableHabitLine";
            this.Size = new System.Drawing.Size (503, 46);
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TextBox tAddingTime;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDoNothing;
        private System.Windows.Forms.Label lActivityName;
    }
}
