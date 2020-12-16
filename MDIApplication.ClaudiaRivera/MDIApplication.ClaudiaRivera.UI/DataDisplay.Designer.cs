
namespace MDIApplication.ClaudiaRivera.UI
{
  partial class DataDisplay
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
      this.ButtonsPanel = new System.Windows.Forms.Panel();
      this.uxCloseButton = new System.Windows.Forms.Button();
      this.uxEmployees = new System.Windows.Forms.DataGridView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ButtonsPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uxEmployees)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ButtonsPanel
      // 
      this.ButtonsPanel.Controls.Add(this.uxCloseButton);
      this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ButtonsPanel.Location = new System.Drawing.Point(0, 290);
      this.ButtonsPanel.Name = "ButtonsPanel";
      this.ButtonsPanel.Size = new System.Drawing.Size(518, 100);
      this.ButtonsPanel.TabIndex = 0;
      // 
      // uxCloseButton
      // 
      this.uxCloseButton.Location = new System.Drawing.Point(348, 41);
      this.uxCloseButton.Name = "uxCloseButton";
      this.uxCloseButton.Size = new System.Drawing.Size(75, 23);
      this.uxCloseButton.TabIndex = 0;
      this.uxCloseButton.Text = "&Close";
      this.uxCloseButton.UseVisualStyleBackColor = true;
      this.uxCloseButton.Click += new System.EventHandler(this.uxCloseButton_Click);
      // 
      // uxEmployees
      // 
      this.uxEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.uxEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uxEmployees.Location = new System.Drawing.Point(0, 0);
      this.uxEmployees.Name = "uxEmployees";
      this.uxEmployees.Size = new System.Drawing.Size(518, 290);
      this.uxEmployees.TabIndex = 1;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.closeToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
      // 
      // refreshToolStripMenuItem
      // 
      this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
      this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.refreshToolStripMenuItem.Text = "Refresh";
      this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.closeToolStripMenuItem.Text = "Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // DataDisplay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 390);
      this.Controls.Add(this.uxEmployees);
      this.Controls.Add(this.ButtonsPanel);
      this.Name = "DataDisplay";
      this.Text = "Employees";
      this.Load += new System.EventHandler(this.DataDisplay_Load);
      this.ButtonsPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.uxEmployees)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel ButtonsPanel;
    private System.Windows.Forms.Button uxCloseButton;
    private System.Windows.Forms.DataGridView uxEmployees;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
  }
}