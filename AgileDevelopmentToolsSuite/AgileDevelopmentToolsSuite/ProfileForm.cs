using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
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

        private void button2_Click(object sender, EventArgs e)
        {
            EditProfileForm editProfileForm = new EditProfileForm();
            editProfileForm.Width = this.Width;
            editProfileForm.Height = this.Height;

            editProfileForm.StartPosition = FormStartPosition.Manual;
            editProfileForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            editProfileForm.Show();
        }

        private void skillLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://lh3.googleusercontent.com/-VnHUvY7m-CE/AAAAAAAAAAI/AAAAAAAAAAA/jrf-MIpUPAM/s96-k-no/photo.jpg");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                profilePictureBox.Image = Bitmap.FromStream(stream);
            }
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
