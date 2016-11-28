using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
  public partial class EditProfileForm : Form
  {
    String currentUser = "";

    public EditProfileForm()
    {
      InitializeComponent();
    }

    public EditProfileForm(String givenUser)
    {
      InitializeComponent();
      currentUser = givenUser;
    }

    private void menuButton_Click(object sender, EventArgs e)
    {
        this.Hide();

        MainMenuForm mainMenuForm = new MainMenuForm(currentUser);

        mainMenuForm.Width = this.Width;
        mainMenuForm.Height = this.Height;

        mainMenuForm.StartPosition = FormStartPosition.Manual;
        mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);
        mainMenuForm.Show();

        mainMenuForm.Closed += (s, args) => this.Close();
        mainMenuForm.Show();
    }

    private void EditProfileForm_FormClosed(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {

    }

    private void EditProfileForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void nameBox_TextChanged(object sender, EventArgs e)
    {

    }
  }

}