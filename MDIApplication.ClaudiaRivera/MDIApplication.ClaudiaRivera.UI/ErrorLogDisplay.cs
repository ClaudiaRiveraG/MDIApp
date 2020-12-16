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
  /// Form to display Error log
  /// </summary>
  public partial class ErrorLogDisplay : Form
  {
    public ErrorLogDisplay()
    {
      InitializeComponent();
    }


    /// <summary>
    /// Display the error log in the listBox elements
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ErrorLogDisplay_Load(object sender, EventArgs e)
    {
      uxErrors.DataSource = Utility.ErrorLogger.DisplayErrors();
    }

    private void uxCloseButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }





  }
}
