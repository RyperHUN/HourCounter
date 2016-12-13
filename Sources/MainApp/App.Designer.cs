namespace HourCounter
{
    partial class App
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.groupDetailedView = new System.Windows.Forms.GroupBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddNewActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.showHabitAdderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dayChooser = new DayChooser.DayChooser();
            this.treeView = new TreeListView.TreeListView();
            this.detailedView = new DetailedView.DetailedView();
            this.activityTimer = new ActivityTimer.ActivityTimer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.groupDetailedView.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeView);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerMain.Size = new System.Drawing.Size(552, 461);
            this.splitContainerMain.SplitterDistance = 207;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.IsSplitterFixed = true;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.groupDetailedView);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.activityTimer);
            this.splitContainerRight.Size = new System.Drawing.Size(341, 461);
            this.splitContainerRight.SplitterDistance = 249;
            this.splitContainerRight.TabIndex = 0;
            // 
            // groupDetailedView
            // 
            this.groupDetailedView.BackColor = System.Drawing.Color.White;
            this.groupDetailedView.Controls.Add(this.detailedView);
            this.groupDetailedView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupDetailedView.Location = new System.Drawing.Point(0, 9);
            this.groupDetailedView.Name = "groupDetailedView";
            this.groupDetailedView.Size = new System.Drawing.Size(341, 240);
            this.groupDetailedView.TabIndex = 0;
            this.groupDetailedView.TabStop = false;
            this.groupDetailedView.Text = "Detailed View";
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(552, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuBar";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddNewActivity,
            this.menuSettings,
            this.showHabitAdderToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // menuAddNewActivity
            // 
            this.menuAddNewActivity.Name = "menuAddNewActivity";
            this.menuAddNewActivity.Size = new System.Drawing.Size(170, 22);
            this.menuAddNewActivity.Text = "Add new Activity";
            this.menuAddNewActivity.Click += new System.EventHandler(this.menuAddNewActivity_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(170, 22);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // showHabitAdderToolStripMenuItem
            // 
            this.showHabitAdderToolStripMenuItem.Name = "showHabitAdderToolStripMenuItem";
            this.showHabitAdderToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showHabitAdderToolStripMenuItem.Text = "Show Habit Adder";
            this.showHabitAdderToolStripMenuItem.Click += new System.EventHandler(this.showHabitAdderToolStripMenuItem_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(133, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerMain);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 461);
            this.panel1.TabIndex = 2;
            // 
            // dayChooser
            // 
            this.dayChooser.Location = new System.Drawing.Point(1, 494);
            this.dayChooser.Name = "dayChooser";
            this.dayChooser.Size = new System.Drawing.Size(548, 46);
            this.dayChooser.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(5, 5);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(197, 451);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // detailedView
            // 
            this.detailedView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailedView.Location = new System.Drawing.Point(3, 16);
            this.detailedView.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.detailedView.Name = "detailedView";
            this.detailedView.Size = new System.Drawing.Size(335, 221);
            this.detailedView.TabIndex = 0;
            this.detailedView.Visible = false;
            // 
            // activityTimer
            // 
            this.activityTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityTimer.Location = new System.Drawing.Point(0, 0);
            this.activityTimer.Name = "activityTimer";
            this.activityTimer.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.activityTimer.Size = new System.Drawing.Size(341, 208);
            this.activityTimer.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 542);
            this.Controls.Add(this.dayChooser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "Ryper self improvement manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.groupDetailedView.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAddNewActivity;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private ActivityTimer.ActivityTimer activityTimer;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.GroupBox groupDetailedView;
        private DetailedView.DetailedView detailedView;
        private TreeListView.TreeListView treeView;
        private System.Windows.Forms.ToolStripMenuItem showHabitAdderToolStripMenuItem;
        private DayChooser.DayChooser dayChooser;
        private System.Windows.Forms.Panel panel1;
    }
}

