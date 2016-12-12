using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class GroupProfileForm : Form
    {
        string currentUser = "";
        string currentGroup = "";
        public GroupProfileForm()
        {
            InitializeComponent();
        }

        public GroupProfileForm(string curUser, string curGroup)
        {
            InitializeComponent();
            currentUser = curUser;
            currentGroup = curGroup;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenuForm mainMenuForm = new MainMenuForm(currentUser);

            mainMenuForm.Width = this.Width;
            mainMenuForm.Height = this.Height;

            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

            mainMenuForm.Closed += (s, args) => this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            EditGroupProfileForm editGroupProfileForm = new EditGroupProfileForm();

            editGroupProfileForm.Width = this.Width;
            editGroupProfileForm.Height = this.Height;

            editGroupProfileForm.StartPosition = FormStartPosition.Manual;
            editGroupProfileForm.Location = new Point(this.Location.X, this.Location.Y);

            editGroupProfileForm.Closed += (s, args) => this.Close();
            editGroupProfileForm.Show();
        }

        private void GroupProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
