
namespace MDIApplication.ClaudiaRivera.UI
{
  partial class ErrorLogDisplay
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
      this.ButtonsPanel = new System.Windows.Forms.Panel();
      this.uxCloseButton = new System.Windows.Forms.Button();
      this.uxErrors = new System.Windows.Forms.ListBox();
      this.ButtonsPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // ButtonsPanel
      // 
      this.ButtonsPanel.Controls.Add(this.uxCloseButton);
      this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ButtonsPanel.Location = new System.Drawing.Point(0, 286);
      this.ButtonsPanel.Name = "ButtonsPanel";
      this.ButtonsPanel.Size = new System.Drawing.Size(534, 100);
      this.ButtonsPanel.TabIndex = 0;
      // 
      // uxCloseButton
      // 
      this.uxCloseButton.Location = new System.Drawing.Point(397, 45);
      this.uxCloseButton.Name = "uxCloseButton";
      this.uxCloseButton.Size = new System.Drawing.Size(75, 23);
      this.uxCloseButton.TabIndex = 0;
      this.uxCloseButton.Text = "&Close";
      this.uxCloseButton.UseVisualStyleBackColor = true;
      this.uxCloseButton.Click += new System.EventHandler(this.uxCloseButton_Click);
      // 
      // uxErrors
      // 
      this.uxErrors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uxErrors.FormattingEnabled = true;
      this.uxErrors.Location = new System.Drawing.Point(0, 0);
      this.uxErrors.Name = "uxErrors";
      this.uxErrors.Size = new System.Drawing.Size(534, 286);
      this.uxErrors.TabIndex = 1;
      // 
      // ErrorLogDisplay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 386);
      this.Controls.Add(this.uxErrors);
      this.Controls.Add(this.ButtonsPanel);
      this.Name = "ErrorLogDisplay";
      this.Text = "Error Log";
      this.Load += new System.EventHandler(this.ErrorLogDisplay_Load);
      this.ButtonsPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel ButtonsPanel;
    private System.Windows.Forms.Button uxCloseButton;
    private System.Windows.Forms.ListBox uxErrors;
  }
}