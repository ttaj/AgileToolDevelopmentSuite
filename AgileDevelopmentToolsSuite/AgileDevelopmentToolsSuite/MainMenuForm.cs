using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgileDevelopmentToolsSuite
{
  public partial class MainMenuForm : Form
  {
    public MainMenuForm()
    {
      InitializeComponent();
    }

    private void MainMenuForm_Load(object sender, EventArgs e)
    {
      
    }

    private void menuNumUrgentTasks_TextChanged(object sender, EventArgs e)
    {

    }

    private void menuGroupNameTxt_TextChanged(object sender, EventArgs e)
    {
      this.Hide();
      LoginForm loginForm = new LoginForm();
      loginForm.Show();
    }


  }
}
