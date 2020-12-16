using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication.ClaudiaRivera.UI
{

  /// <summary>
  /// Form to Authenticate a user
  /// </summary>
  public partial class Login : Form
  {
    static int count = 1; //  number of attempts
    
    public Login()
    {
      InitializeComponent();
    }

    /// <summary>
    /// This event calls the authenticator class to authenticate the username and pasword 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void uxLoginButton_Click(object sender, EventArgs e)
    {
      if (string.Equals(Utility.Authenticator.Authenticate(uxUsername.Text, uxPassword.Text, count), "Successful"))
      {
        count = 1;
        MessageBox.Show("Log in is succcesful!", "Welcome");
        this.Hide();
        Main frmMain = new Main();
        frmMain.Show();

      }
      else if (count < 4)
      {

        if (count == 3)
        {
          MessageBox.Show("Three attempts being made unsuccesfully.\n The application will close", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          this.Close();
        }
        MessageBox.Show("Please enter a valid username or password \n " +
                        "You have " + (3 - count) + " more attempts", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        count++;

      }
    }

    private void uxClose_Click(object sender, EventArgs e)
    {
      this.Close();
      Application.Exit();
    }

  



  }
}
