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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection db;

            String version = "MSSQLLocalDB";
            String fileName = "ADTSDLoginInfo.mdf";
            String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

            db = new SqlConnection(connectionString);

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

            object queryResult;

            SqlCommand userCheck = new SqlCommand("SELECT [Username] FROM Users WHERE [Username] = @Username");
            SqlCommand passwordCheck = new SqlCommand("SELECT [Password] FROM Users WHERE [Password] = @Password");

            userCheck.Connection = db;
            passwordCheck.Connection = db;

            try
            {
                db.Open();

                try
                {
                    //check for user being correct
                    userCheck.Parameters.AddWithValue("@Username", usernameBox.Text);
                    queryResult = userCheck.ExecuteScalar();
                    String res = "Not Found";

                    res = Convert.ToString(queryResult);
                    if (!res.Equals(""))
                    {
                        MessageBox.Show("Username or Password does not exist!");
                    }
                    else
                    {
                        if(!res.Equals(usernameBox.Text))
                        {
                            MessageBox.Show("Username or Password is incorrect!");
                        }
                    }

                    //check for password being correct
                    passwordCheck.Parameters.AddWithValue("@Username", usernameBox.Text);
                    queryResult = passwordCheck.ExecuteScalar();
                    res = "Not Found";

                    res = Convert.ToString(queryResult);
                    if (!res.Equals(""))
                    {
                        MessageBox.Show("Username or Password does not exist!");
                    }
                    else
                    {
                        if (!res.Equals(passwordBox.Text))
                        {
                            MessageBox.Show("Username or Password is incorrect!");
                        }
                        else
                        {
                            EditProfileForm mainmenuform = new EditProfileForm();
                            mainmenuform.Width = this.Width;
                            mainmenuform.Height = this.Height;

                            mainmenuform.StartPosition = FormStartPosition.Manual;
                            mainmenuform.Location = new Point(this.Location.X, this.Location.Y);

                            this.Hide();
                            mainmenuform.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection unsuccessful, please try again. ");
            }
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
