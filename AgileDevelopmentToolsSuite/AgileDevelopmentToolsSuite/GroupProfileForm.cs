using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class GroupProfileForm : Form
    {
    string currentUser = "";
        public GroupProfileForm()
        {
      int z = 0;
            InitializeComponent();
        }

    public GroupProfileForm(string curUser)
    {
      InitializeComponent();
      currentUser = curUser;
    }

    private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
            mainMenuForm.Width = this.Width;
            mainMenuForm.Height = this.Height;

            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            mainMenuForm.Show();
        }

        private void GroupProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    private void GroupProfileForm_FormClosed(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}
