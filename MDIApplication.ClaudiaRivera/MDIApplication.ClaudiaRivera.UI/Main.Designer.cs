
namespace MDIApplication.ClaudiaRivera.UI
{
  partial class Main
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.errorLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.uxAddEmployeeButton = new System.Windows.Forms.ToolStripButton();
      this.uxDisplayAllEmployees = new System.Windows.Forms.ToolStripButton();
      this.uxErrorLog = new System.Windows.Forms.ToolStripButton();
      this.uxLogout = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.uxMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(619, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.logoutToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem.Text = "&Add Employee";
      this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
      // 
      // logoutToolStripMenuItem
      // 
      this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
      this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.logoutToolStripMenuItem.Text = "&Log out";
      this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
      // 
      // displayToolStripMenuItem
      // 
      this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.errorLogToolStripMenuItem1});
      this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
      this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
      this.displayToolStripMenuItem.Text = "&Display";
      // 
      // employeesToolStripMenuItem
      // 
      this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
      this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.employeesToolStripMenuItem.Text = "&Employees";
      this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
      // 
      // errorLogToolStripMenuItem1
      // 
      this.errorLogToolStripMenuItem1.Name = "errorLogToolStripMenuItem1";
      this.errorLogToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
      this.errorLogToolStripMenuItem1.Text = "Error &Log";
      this.errorLogToolStripMenuItem1.Click += new System.EventHandler(this.errorLogToolStripMenuItem1_Click);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.aboutToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem1
      // 
      this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
      this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem1.Text = "&About";
      this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxAddEmployeeButton,
            this.uxDisplayAllEmployees,
            this.uxErrorLog,
            this.uxLogout});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(619, 25);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // uxAddEmployeeButton
      // 
      this.uxAddEmployeeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.uxAddEmployeeButton.Image = ((System.Drawing.Image)(resources.GetObject("uxAddEmployeeButton.Image")));
      this.uxAddEmployeeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxAddEmployeeButton.Name = "uxAddEmployeeButton";
      this.uxAddEmployeeButton.Size = new System.Drawing.Size(23, 22);
      this.uxAddEmployeeButton.Text = "toolStripButton1";
      this.uxAddEmployeeButton.ToolTipText = "AddEmployee";
      this.uxAddEmployeeButton.Click += new System.EventHandler(this.uxAddEmployeeButton_Click);
      // 
      // uxDisplayAllEmployees
      // 
      this.uxDisplayAllEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.uxDisplayAllEmployees.Image = ((System.Drawing.Image)(resources.GetObject("uxDisplayAllEmployees.Image")));
      this.uxDisplayAllEmployees.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxDisplayAllEmployees.Name = "uxDisplayAllEmployees";
      this.uxDisplayAllEmployees.Size = new System.Drawing.Size(23, 22);
      this.uxDisplayAllEmployees.Text = "toolStripButton2";
      this.uxDisplayAllEmployees.ToolTipText = "AllEmployees";
      this.uxDisplayAllEmployees.Click += new System.EventHandler(this.uxDisplayAllEmployees_Click);
      // 
      // uxErrorLog
      // 
      this.uxErrorLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.uxErrorLog.Image = ((System.Drawing.Image)(resources.GetObject("uxErrorLog.Image")));
      this.uxErrorLog.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxErrorLog.Name = "uxErrorLog";
      this.uxErrorLog.Size = new System.Drawing.Size(23, 22);
      this.uxErrorLog.Text = "toolStripButton3";
      this.uxErrorLog.ToolTipText = "Error Log";
      this.uxErrorLog.Click += new System.EventHandler(this.uxErrorLog_Click);
      // 
      // uxLogout
      // 
      this.uxLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.uxLogout.Image = ((System.Drawing.Image)(resources.GetObject("uxLogout.Image")));
      this.uxLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.uxLogout.Name = "uxLogout";
      this.uxLogout.Size = new System.Drawing.Size(23, 22);
      this.uxLogout.Text = "toolStripButton4";
      this.uxLogout.ToolTipText = "Log Out";
      this.uxLogout.Click += new System.EventHandler(this.uxLogout_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMessageLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 385);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(619, 22);
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // uxMessageLabel
      // 
      this.uxMessageLabel.Name = "uxMessageLabel";
      this.uxMessageLabel.Size = new System.Drawing.Size(39, 17);
      this.uxMessageLabel.Text = "Ready";
      // 
      // timer1
      // 
      this.timer1.Interval = 6000;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(619, 407);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Main";
      this.Text = "MDI Application Demo";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem errorLogToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton uxAddEmployeeButton;
    private System.Windows.Forms.ToolStripButton uxDisplayAllEmployees;
    private System.Windows.Forms.ToolStripButton uxErrorLog;
    private System.Windows.Forms.ToolStripButton uxLogout;
    private System.Windows.Forms.StatusStrip statusStrip1;
    public System.Windows.Forms.ToolStripStatusLabel uxMessageLabel;
    private System.Windows.Forms.Timer timer1;
  }
}