namespace Dialogs
{
    partial class SettingsDialog
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lValueAuthorizedStatus = new System.Windows.Forms.Label();
            this.checkAutomaticSave = new System.Windows.Forms.CheckBox();
            this.lTextAuthorizedStatus = new System.Windows.Forms.Label();
            this.bAuthorizeGDrive = new System.Windows.Forms.Button();
            this.groupBoxGDrive = new System.Windows.Forms.GroupBox();
            this.bLoadFromDrive = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBoxGDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(537, 398);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lValueAuthorizedStatus);
            this.tabGeneral.Controls.Add(this.checkAutomaticSave);
            this.tabGeneral.Controls.Add(this.lTextAuthorizedStatus);
            this.tabGeneral.Controls.Add(this.bAuthorizeGDrive);
            this.tabGeneral.Controls.Add(this.groupBoxGDrive);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(529, 372);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lValueAuthorizedStatus
            // 
            this.lValueAuthorizedStatus.AutoSize = true;
            this.lValueAuthorizedStatus.Location = new System.Drawing.Point(108, 72);
            this.lValueAuthorizedStatus.Name = "lValueAuthorizedStatus";
            this.lValueAuthorizedStatus.Size = new System.Drawing.Size(21, 13);
            this.lValueAuthorizedStatus.TabIndex = 1;
            this.lValueAuthorizedStatus.Text = "Off";
            // 
            // checkAutomaticSave
            // 
            this.checkAutomaticSave.AutoSize = true;
            this.checkAutomaticSave.Location = new System.Drawing.Point(12, 10);
            this.checkAutomaticSave.Name = "checkAutomaticSave";
            this.checkAutomaticSave.Size = new System.Drawing.Size(137, 17);
            this.checkAutomaticSave.TabIndex = 6;
            this.checkAutomaticSave.Text = "Enable Automatic Save";
            this.checkAutomaticSave.UseVisualStyleBackColor = true;
            this.checkAutomaticSave.CheckedChanged += new System.EventHandler(this.checkAutomaticSave_CheckedChanged);
            // 
            // lTextAuthorizedStatus
            // 
            this.lTextAuthorizedStatus.AutoSize = true;
            this.lTextAuthorizedStatus.Location = new System.Drawing.Point(9, 72);
            this.lTextAuthorizedStatus.Name = "lTextAuthorizedStatus";
            this.lTextAuthorizedStatus.Size = new System.Drawing.Size(93, 13);
            this.lTextAuthorizedStatus.TabIndex = 0;
            this.lTextAuthorizedStatus.Text = "Authorized Status:";
            // 
            // bAuthorizeGDrive
            // 
            this.bAuthorizeGDrive.Location = new System.Drawing.Point(12, 37);
            this.bAuthorizeGDrive.Name = "bAuthorizeGDrive";
            this.bAuthorizeGDrive.Size = new System.Drawing.Size(103, 22);
            this.bAuthorizeGDrive.TabIndex = 3;
            this.bAuthorizeGDrive.Text = "Authorize GDrive";
            this.bAuthorizeGDrive.UseVisualStyleBackColor = true;
            // 
            // groupBoxGDrive
            // 
            this.groupBoxGDrive.Controls.Add(this.bLoadFromDrive);
            this.groupBoxGDrive.Controls.Add(this.checkBox1);
            this.groupBoxGDrive.Location = new System.Drawing.Point(12, 101);
            this.groupBoxGDrive.Name = "groupBoxGDrive";
            this.groupBoxGDrive.Size = new System.Drawing.Size(224, 102);
            this.groupBoxGDrive.TabIndex = 5;
            this.groupBoxGDrive.TabStop = false;
            this.groupBoxGDrive.Text = "Google Drive";
            // 
            // bLoadFromDrive
            // 
            this.bLoadFromDrive.Location = new System.Drawing.Point(6, 42);
            this.bLoadFromDrive.Name = "bLoadFromDrive";
            this.bLoadFromDrive.Size = new System.Drawing.Size(97, 23);
            this.bLoadFromDrive.TabIndex = 7;
            this.bLoadFromDrive.Text = "Load from drive";
            this.bLoadFromDrive.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Enable automatic drive sync";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bCancel);
            this.splitContainer1.Panel2.Controls.Add(this.bOk);
            this.splitContainer1.Size = new System.Drawing.Size(537, 450);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(450, 13);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(13, 13);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.groupBoxGDrive.ResumeLayout(false);
            this.groupBoxGDrive.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label lValueAuthorizedStatus;
        private System.Windows.Forms.CheckBox checkAutomaticSave;
        private System.Windows.Forms.Label lTextAuthorizedStatus;
        private System.Windows.Forms.Button bAuthorizeGDrive;
        private System.Windows.Forms.GroupBox groupBoxGDrive;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bLoadFromDrive;
    }
}