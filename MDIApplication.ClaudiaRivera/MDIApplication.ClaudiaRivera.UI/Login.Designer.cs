
namespace MDIApplication.ClaudiaRivera.UI
{
  partial class Login
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
      this.uxLoginButton = new System.Windows.Forms.Button();
      this.uxClose = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.uxUsername = new System.Windows.Forms.TextBox();
      this.uxPassword = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // uxLoginButton
      // 
      this.uxLoginButton.Location = new System.Drawing.Point(72, 200);
      this.uxLoginButton.Name = "uxLoginButton";
      this.uxLoginButton.Size = new System.Drawing.Size(75, 23);
      this.uxLoginButton.TabIndex = 3;
      this.uxLoginButton.Text = "&Login";
      this.uxLoginButton.UseVisualStyleBackColor = true;
      this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
      // 
      // uxClose
      // 
      this.uxClose.Location = new System.Drawing.Point(231, 200);
      this.uxClose.Name = "uxClose";
      this.uxClose.Size = new System.Drawing.Size(75, 23);
      this.uxClose.TabIndex = 4;
      this.uxClose.Text = "&Cancel";
      this.uxClose.UseVisualStyleBackColor = true;
      this.uxClose.Click += new System.EventHandler(this.uxClose_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(69, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Username:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(69, 121);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Password:";
      // 
      // uxUsername
      // 
      this.uxUsername.Location = new System.Drawing.Point(127, 68);
      this.uxUsername.Name = "uxUsername";
      this.uxUsername.Size = new System.Drawing.Size(179, 20);
      this.uxUsername.TabIndex = 1;
      // 
      // uxPassword
      // 
      this.uxPassword.Location = new System.Drawing.Point(127, 118);
      this.uxPassword.Name = "uxPassword";
      this.uxPassword.Size = new System.Drawing.Size(179, 20);
      this.uxPassword.TabIndex = 2;
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(377, 296);
      this.Controls.Add(this.uxPassword);
      this.Controls.Add(this.uxUsername);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.uxClose);
      this.Controls.Add(this.uxLoginButton);
      this.Name = "Login";
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button uxLoginButton;
    private System.Windows.Forms.Button uxClose;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox uxUsername;
    private System.Windows.Forms.TextBox uxPassword;
  }
}