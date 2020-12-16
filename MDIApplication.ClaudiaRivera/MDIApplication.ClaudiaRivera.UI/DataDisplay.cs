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
  public partial class DataDisplay : Form
  {
    public DataDisplay()
    {
      InitializeComponent();
    }

     /// <summary>
    /// Load the information in the gridview element
    /// </summary>
    private void LoadGrid()
    {
      uxEmployees.DataSource = null;
      uxEmployees.DataSource = Employee.GetAll();
    }


    private void DataDisplay_Load(object sender, EventArgs e)
    {
      LoadGrid();
    }

    private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LoadGrid();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void uxCloseButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }   

  }
}
