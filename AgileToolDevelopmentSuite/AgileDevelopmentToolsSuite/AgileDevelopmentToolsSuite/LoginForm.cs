using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("bye login");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection db;
            String version = "MSSQLLocalDB";
            String fileName = "ADTSDLoginInfo.mdf";
            String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

            db = new SqlConnection(connectionString);

            //need to do the query for login

            if (String.Compare(usernameBox.Text, "") == 0)
            {
                MessageBox.Show("Please input a username.");
                return;
            }

            if (String.Compare(passwordBox.Text, "") == 0)
            {
                MessageBox.Show("Please input a password.");
                return;
            }

            MainMenuForm mainmenuform = new MainMenuForm();
            mainmenuform.Width = this.Width;
            mainmenuform.Height = this.Height;

            mainmenuform.StartPosition = FormStartPosition.Manual;
            mainmenuform.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            mainmenuform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PositionForm positionForm = new PositionForm();

            positionForm.Width = this.Width;
            positionForm.Height = this.Height;

            positionForm.StartPosition = FormStartPosition.Manual;
            positionForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            positionForm.Show();
        }
    }
}
