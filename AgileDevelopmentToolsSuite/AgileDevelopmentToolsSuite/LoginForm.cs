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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PositionForm registrationForm = new PositionForm();


            registrationForm.Width = this.Width;
            registrationForm.Height = this.Height;

            registrationForm.StartPosition = FormStartPosition.Manual;
            registrationForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            registrationForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("bye login");
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\natha\Documents\Visual Studio 2015\Projects\AgileDevelopmentToolsSuite\AgileDevelopmentToolsSuite\ADTSDatabase.mdf';Integrated Security=True";

            string username = usernameBox.Text;
            string password = passwordBox.Text;
            if ((username == "" || password == ""))
            {
                MessageBox.Show("please enter the username and password");
            }
            else  
            {

                MainMenuForm mainmenuform = new MainMenuForm();
                mainmenuform.Width = this.Width;
                mainmenuform.Height = this.Height;

                mainmenuform.StartPosition = FormStartPosition.Manual;
                mainmenuform.Location = new Point(this.Location.X, this.Location.Y);

                this.Hide();
                mainmenuform.Show();
            }
        }
    }
}
