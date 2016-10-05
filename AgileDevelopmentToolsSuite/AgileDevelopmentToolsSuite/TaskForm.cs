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
  public partial class TaskForm : Form
  {
    public TaskForm()
    {
      InitializeComponent();

      this.curTasksComboBox.SelectedIndex = 1;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void curTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void rightArrow_Click(object sender, EventArgs e)
    {

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void curTasksSortLabel_Click(object sender, EventArgs e)
    {

    }

    private void curTasksLabel_Click(object sender, EventArgs e)
    {

    }

    private void curTasksRadio1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void curTasksRadio2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void curTasksRadio3_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void backButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      MainMenuForm menuForm = new MainMenuForm();
      menuForm.Show();
    }

    private void curTasksComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

    private void curTasksSaveButton_Click(object sender, EventArgs e)
    {

    }
  }
}
