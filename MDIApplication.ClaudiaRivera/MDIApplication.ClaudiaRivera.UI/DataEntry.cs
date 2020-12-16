using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIApplication.ClaudiaRivera.Domain;

namespace MDIApplication.ClaudiaRivera.UI
{
  /// <summary>
  /// This form is used to add an employee to the system
  /// </summary>
  public partial class DataEntry : Form
  {
    Employee employee; //Employee object
    public DataEntry()
    {
      InitializeComponent();
      employee = new Employee();
    }

    private void uxAddButton_Click(object sender, EventArgs e)
    {
      Main parent = (Main)this.MdiParent;

      // Validate user input all fields of employee object are required

      string msg = employee.Add(uxFirstname.Text, uxLastname.Text, uxDepartment.Text, uxPhone.Text);

      if (string.Equals("Successful", msg))
      {
        //Send a message to the Main form when an employee was added
        message("New employee was Added");

        MessageBox.Show("New employee was added");
        //Clean Texboxes

        uxFirstname.Text = String.Empty;
        uxLastname.Text = String.Empty;
        uxPhone.Text = String.Empty;
        uxDepartment.Text = String.Empty;
        uxFirstname.Focus();
      }
      else
      {
        MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        message("Input Error");
      }

    }

    //
    /// <summary>
    /// Private Method to display message on the main MDI
    /// </summary>
    /// <param name="mesg">String containing the message to dispay</param>
    private void message(string mesg)
    {
      Main parent = (Main)this.MdiParent;
      parent.uxMessageLabel.Text = mesg;
      parent.StartTimer();
    }
  

    private void uxCloseButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
