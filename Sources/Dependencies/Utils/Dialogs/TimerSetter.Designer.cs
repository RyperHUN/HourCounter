namespace Utils
{
    partial class TimerSetter
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
            this.tTime = new System.Windows.Forms.TextBox ();
            this.lFormatLabel = new System.Windows.Forms.Label ();
            this.bOk = new System.Windows.Forms.Button ();
            this.bCancel = new System.Windows.Forms.Button ();
            this.SuspendLayout ();
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point (29, 23);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size (100, 20);
            this.tTime.TabIndex = 0;
            // 
            // lFormatLabel
            // 
            this.lFormatLabel.AutoSize = true;
            this.lFormatLabel.Location = new System.Drawing.Point (135, 26);
            this.lFormatLabel.Name = "lFormatLabel";
            this.lFormatLabel.Size = new System.Drawing.Size (35, 13);
            this.lFormatLabel.TabIndex = 1;
            this.lFormatLabel.Text = "label1";
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point (13, 62);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size (58, 23);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler (this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point (138, 62);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size (58, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler (this.bCancel_Click);
            // 
            // TimerSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (215, 97);
            this.Controls.Add (this.bCancel);
            this.Controls.Add (this.bOk);
            this.Controls.Add (this.lFormatLabel);
            this.Controls.Add (this.tTime);
            this.Name = "TimerSetter";
            this.Text = "TimerSetter";
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.TextBox tTime;
        private System.Windows.Forms.Label lFormatLabel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
    }
}