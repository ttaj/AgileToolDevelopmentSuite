using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class GroupProfileForm : Form
    {
        public GroupProfileForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
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

        private void button2_Click(object sender, EventArgs e)
        {
            EditGroupProfileForm editGroupProfileForm = new EditGroupProfileForm();
            editGroupProfileForm.Width = this.Width;
            editGroupProfileForm.Height = this.Height;

            editGroupProfileForm.StartPosition = FormStartPosition.Manual;
            editGroupProfileForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            editGroupProfileForm.Show();
        }
    }
}
