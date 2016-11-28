using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class EditGroupProfileForm : Form
    {
        String currentUser = "";

        public EditGroupProfileForm()
        {
            InitializeComponent();
        }

        public EditGroupProfileForm(String givenUser)
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

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
