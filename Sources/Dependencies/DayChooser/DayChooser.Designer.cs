namespace DayChooser
{
    partial class DayChooser
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
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioToday = new System.Windows.Forms.RadioButton();
            this.radioYesterday = new System.Windows.Forms.RadioButton();
            this.radioAllWeek = new System.Windows.Forms.RadioButton();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(14, 12);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(36, 17);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioToday
            // 
            this.radioToday.AutoSize = true;
            this.radioToday.Location = new System.Drawing.Point(56, 12);
            this.radioToday.Name = "radioToday";
            this.radioToday.Size = new System.Drawing.Size(55, 17);
            this.radioToday.TabIndex = 1;
            this.radioToday.Text = "Today";
            this.radioToday.UseVisualStyleBackColor = true;
            // 
            // radioYesterday
            // 
            this.radioYesterday.AutoSize = true;
            this.radioYesterday.Location = new System.Drawing.Point(117, 12);
            this.radioYesterday.Name = "radioYesterday";
            this.radioYesterday.Size = new System.Drawing.Size(72, 17);
            this.radioYesterday.TabIndex = 2;
            this.radioYesterday.Text = "Yesterday";
            this.radioYesterday.UseVisualStyleBackColor = true;
            // 
            // radioAllWeek
            // 
            this.radioAllWeek.AutoSize = true;
            this.radioAllWeek.Location = new System.Drawing.Point(195, 12);
            this.radioAllWeek.Name = "radioAllWeek";
            this.radioAllWeek.Size = new System.Drawing.Size(65, 17);
            this.radioAllWeek.TabIndex = 3;
            this.radioAllWeek.Text = "AllWeek";
            this.radioAllWeek.UseVisualStyleBackColor = true;
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(266, 12);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(60, 17);
            this.radioCustom.TabIndex = 4;
            this.radioCustom.Text = "Custom";
            this.radioCustom.UseVisualStyleBackColor = true;
            // 
            // DayChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioCustom);
            this.Controls.Add(this.radioAllWeek);
            this.Controls.Add(this.radioYesterday);
            this.Controls.Add(this.radioToday);
            this.Controls.Add(this.radioAll);
            this.Name = "DayChooser";
            this.Size = new System.Drawing.Size(356, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioToday;
        private System.Windows.Forms.RadioButton radioYesterday;
        private System.Windows.Forms.RadioButton radioAllWeek;
        private System.Windows.Forms.RadioButton radioCustom;
    }
}
