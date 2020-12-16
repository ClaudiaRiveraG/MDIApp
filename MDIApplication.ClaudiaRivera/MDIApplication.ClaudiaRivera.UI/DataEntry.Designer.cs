
namespace MDIApplication.ClaudiaRivera.UI
{
  partial class DataEntry
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uxPhone = new System.Windows.Forms.TextBox();
      this.uxDepartment = new System.Windows.Forms.TextBox();
      this.uxLastname = new System.Windows.Forms.TextBox();
      this.uxFirstname = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.uxCloseButton = new System.Windows.Forms.Button();
      this.uxAddButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uxPhone);
      this.groupBox1.Controls.Add(this.uxDepartment);
      this.groupBox1.Controls.Add(this.uxLastname);
      this.groupBox1.Controls.Add(this.uxFirstname);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.uxCloseButton);
      this.groupBox1.Controls.Add(this.uxAddButton);
      this.groupBox1.Location = new System.Drawing.Point(12, 27);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(458, 322);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Enter Employee Information ";
      // 
      // uxPhone
      // 
      this.uxPhone.Location = new System.Drawing.Point(137, 176);
      this.uxPhone.Name = "uxPhone";
      this.uxPhone.Size = new System.Drawing.Size(287, 20);
      this.uxPhone.TabIndex = 4;
      // 
      // uxDepartment
      // 
      this.uxDepartment.Location = new System.Drawing.Point(137, 139);
      this.uxDepartment.Name = "uxDepartment";
      this.uxDepartment.Size = new System.Drawing.Size(287, 20);
      this.uxDepartment.TabIndex = 3;
      // 
      // uxLastname
      // 
      this.uxLastname.Location = new System.Drawing.Point(137, 102);
      this.uxLastname.Name = "uxLastname";
      this.uxLastname.Size = new System.Drawing.Size(287, 20);
      this.uxLastname.TabIndex = 2;
      // 
      // uxFirstname
      // 
      this.uxFirstname.Location = new System.Drawing.Point(137, 67);
      this.uxFirstname.Name = "uxFirstname";
      this.uxFirstname.Size = new System.Drawing.Size(287, 20);
      this.uxFirstname.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 179);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Phone:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 142);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Department:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 109);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Last Name:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 67);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "First Name:";
      // 
      // uxCloseButton
      // 
      this.uxCloseButton.Location = new System.Drawing.Point(349, 267);
      this.uxCloseButton.Name = "uxCloseButton";
      this.uxCloseButton.Size = new System.Drawing.Size(75, 23);
      this.uxCloseButton.TabIndex = 6;
      this.uxCloseButton.Text = "&Close";
      this.uxCloseButton.UseVisualStyleBackColor = true;
      this.uxCloseButton.Click += new System.EventHandler(this.uxCloseButton_Click);
      // 
      // uxAddButton
      // 
      this.uxAddButton.Location = new System.Drawing.Point(232, 267);
      this.uxAddButton.Name = "uxAddButton";
      this.uxAddButton.Size = new System.Drawing.Size(75, 23);
      this.uxAddButton.TabIndex = 5;
      this.uxAddButton.Text = "&Add";
      this.uxAddButton.UseVisualStyleBackColor = true;
      this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
      // 
      // DataEntry
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(506, 388);
      this.Controls.Add(this.groupBox1);
      this.Name = "DataEntry";
      this.Text = "Add new Employee";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox uxPhone;
    private System.Windows.Forms.TextBox uxDepartment;
    private System.Windows.Forms.TextBox uxLastname;
    private System.Windows.Forms.TextBox uxFirstname;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button uxCloseButton;
    private System.Windows.Forms.Button uxAddButton;
  }
}