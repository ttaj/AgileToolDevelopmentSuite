using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.Width = this.Width;
            loginForm.Height = this.Height;

            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            loginForm.Show();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
  }
}
