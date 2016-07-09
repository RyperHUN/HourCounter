using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HourCounter
{
    public class DetailedView : System.Windows.Forms.UserControl, Observer
    {
        private System.Windows.Forms.Label lActivityName;
        private System.Windows.Forms.Label label1;

        public void update()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            this.lActivityName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lActivityName
            // 
            this.lActivityName.AutoSize = true;
            this.lActivityName.Font = new System.Drawing.Font("Adobe Devanagari", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActivityName.Location = new System.Drawing.Point(140, 42);
            this.lActivityName.Name = "lActivityName";
            this.lActivityName.Size = new System.Drawing.Size(193, 43);
            this.lActivityName.TabIndex = 0;
            this.lActivityName.Text = "Activity Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // DetailedView
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lActivityName);
            this.Name = "DetailedView";
            this.Size = new System.Drawing.Size(535, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}