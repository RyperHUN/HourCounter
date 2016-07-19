namespace HourCounter
{
    partial class ActivityAdd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tActivityName = new System.Windows.Forms.TextBox();
            this.radioSubActivity = new System.Windows.Forms.RadioButton();
            this.radioMainActivity = new System.Windows.Forms.RadioButton();
            this.comboActivityDropDown = new System.Windows.Forms.ComboBox();
            this.lActivityName = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tTimeSpent = new System.Windows.Forms.TextBox();
            this.lTimeFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tActivityName
            // 
            this.tActivityName.Location = new System.Drawing.Point(102, 19);
            this.tActivityName.Name = "tActivityName";
            this.tActivityName.Size = new System.Drawing.Size(140, 20);
            this.tActivityName.TabIndex = 0;
            // 
            // radioSubActivity
            // 
            this.radioSubActivity.AutoSize = true;
            this.radioSubActivity.Location = new System.Drawing.Point(12, 104);
            this.radioSubActivity.Name = "radioSubActivity";
            this.radioSubActivity.Size = new System.Drawing.Size(90, 17);
            this.radioSubActivity.TabIndex = 1;
            this.radioSubActivity.Text = "Below activity";
            this.radioSubActivity.UseVisualStyleBackColor = true;
            this.radioSubActivity.CheckedChanged += new System.EventHandler(this.radioSubActivity_CheckedChanged);
            // 
            // radioMainActivity
            // 
            this.radioMainActivity.AutoSize = true;
            this.radioMainActivity.Checked = true;
            this.radioMainActivity.Location = new System.Drawing.Point(12, 77);
            this.radioMainActivity.Name = "radioMainActivity";
            this.radioMainActivity.Size = new System.Drawing.Size(84, 17);
            this.radioMainActivity.TabIndex = 2;
            this.radioMainActivity.TabStop = true;
            this.radioMainActivity.Text = "Main activity";
            this.radioMainActivity.UseVisualStyleBackColor = true;
            // 
            // comboActivityDropDown
            // 
            this.comboActivityDropDown.Enabled = false;
            this.comboActivityDropDown.FormattingEnabled = true;
            this.comboActivityDropDown.Location = new System.Drawing.Point(102, 104);
            this.comboActivityDropDown.Name = "comboActivityDropDown";
            this.comboActivityDropDown.Size = new System.Drawing.Size(140, 21);
            this.comboActivityDropDown.TabIndex = 3;
            // 
            // lActivityName
            // 
            this.lActivityName.AutoSize = true;
            this.lActivityName.Location = new System.Drawing.Point(13, 22);
            this.lActivityName.Name = "lActivityName";
            this.lActivityName.Size = new System.Drawing.Size(78, 13);
            this.lActivityName.TabIndex = 4;
            this.lActivityName.Text = "Activity Name :";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(58, 141);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(185, 141);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time spent with it";
            // 
            // tTimeSpent
            // 
            this.tTimeSpent.Location = new System.Drawing.Point(102, 50);
            this.tTimeSpent.Name = "tTimeSpent";
            this.tTimeSpent.Size = new System.Drawing.Size(77, 20);
            this.tTimeSpent.TabIndex = 8;
            this.tTimeSpent.Text = "0";
            // 
            // lTimeFormat
            // 
            this.lTimeFormat.AutoSize = true;
            this.lTimeFormat.Location = new System.Drawing.Point(185, 53);
            this.lTimeFormat.Name = "lTimeFormat";
            this.lTimeFormat.Size = new System.Drawing.Size(23, 13);
            this.lTimeFormat.TabIndex = 9;
            this.lTimeFormat.Text = "min";
            this.lTimeFormat.Click += new System.EventHandler(this.label2_Click);
            // 
            // ActivityAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 185);
            this.Controls.Add(this.lTimeFormat);
            this.Controls.Add(this.tTimeSpent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lActivityName);
            this.Controls.Add(this.comboActivityDropDown);
            this.Controls.Add(this.radioMainActivity);
            this.Controls.Add(this.radioSubActivity);
            this.Controls.Add(this.tActivityName);
            this.Name = "ActivityAdd";
            this.Text = "ActivityAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tActivityName;
        private System.Windows.Forms.RadioButton radioSubActivity;
        private System.Windows.Forms.RadioButton radioMainActivity;
        private System.Windows.Forms.ComboBox comboActivityDropDown;
        private System.Windows.Forms.Label lActivityName;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tTimeSpent;
        private System.Windows.Forms.Label lTimeFormat;
    }
}