using System;
using System.Collections;
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
    /// Main form After the user is authenticate
    /// </summary>
    public partial class Main : Form
    {

      //declare form objects 
      DataEntry frmAddEmployee;
      DataDisplay frmDisplayEmployees;
      ErrorLogDisplay frmDisplayLog;

      //Create an Arraylist to store employees
      public static ArrayList EmployeeList = new ArrayList();


      public Main()
      {
        InitializeComponent();
      }

      /// <summary>
      /// Create only one instance of Add employee form
      /// </summary>
      private void CreateAddEmployee()
      {
        if (frmAddEmployee == null || frmAddEmployee.IsDisposed)
        {
          frmAddEmployee = new DataEntry();
          frmAddEmployee.MdiParent = this;
        }

        frmAddEmployee.Show();
        frmAddEmployee.BringToFront();
      }

      /// <summary>
      /// Create only one instance of Display employees form
      /// </summary>
      private void CreateDisplayEmployees()
      {
        if (frmDisplayEmployees == null || frmDisplayEmployees.IsDisposed)
        {
          frmDisplayEmployees = new DataDisplay();
          frmDisplayEmployees.MdiParent = this;
        }

        frmDisplayEmployees.Show();
        frmDisplayEmployees.BringToFront();
      }

      /// <summary>
      /// Create only on instance of Display error log form
      /// </summary>
      private void CreateDisplayLog()
      {
        if (frmDisplayLog == null || frmDisplayLog.IsDisposed)
        {
          frmDisplayLog = new ErrorLogDisplay();
          frmDisplayLog.MdiParent = this;
        }

        frmDisplayLog.Show();
        frmDisplayLog.BringToFront();
      }

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CreateAddEmployee();
    }
    private void uxAddEmployeeButton_Click(object sender, EventArgs e)
    {
      CreateAddEmployee();
    }
   
    private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CreateDisplayEmployees();
    }

    private void uxDisplayAllEmployees_Click(object sender, EventArgs e)
    {
      CreateDisplayEmployees();
    }

    private void errorLogToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      CreateDisplayLog();
    }

    private void uxErrorLog_Click(object sender, EventArgs e)
    {
      CreateDisplayLog();
    }

    // <summary>
    ///  Information About the application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      AboutBox1 frmAbout = new AboutBox1();
      frmAbout.ShowDialog();
    }

    /// <summary>
    /// Close this window and  the log in form shows
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// 
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      Login frmlogin = new Login();
      frmlogin.Show();

    }

    private void uxLogout_Click(object sender, EventArgs e)
    {
      this.Close();
      Login frmlogin = new Login();
      frmlogin.Show();
    }


    /// <summary>
    /// Timer
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Tick(object sender, EventArgs e)
      {
        timer1.Stop();
        uxMessageLabel.Text = "Ready";
      }
      public void StartTimer()
      {
        timer1.Start();
      }

   
  }

}
