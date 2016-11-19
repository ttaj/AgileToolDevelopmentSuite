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
    public partial class ProjectMangerForm : Form
    {
        public ProjectMangerForm()
        {
            InitializeComponent();
        }

        private void ProjectMangerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void yesProfileButton_CheckedChanged(object sender, EventArgs e)
        {
            profileLinkLabel.Visible = true;
            profileLinkBox.Visible = true;
        }

        private void noProfileButton_CheckedChanged(object sender, EventArgs e)
        {
            profileLinkLabel.Visible = false;
            profileLinkBox.Visible = false;
        }

        private void continueButton_Click(object sender, EventArgs e)
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
            SqlCommand insertUsers = new SqlCommand("INSERT INTO Users ([Username], [Password], [ProjectManager]) VALUES (@Username, @Password, @ProjectManager)");
            SqlCommand insertUsersInformation = new SqlCommand("INSERT INTO Users ([Username], [Nickname], [ProfileLink]) VALUES (@Username, @Nickname, @ProfileLink)");
            SqlCommand insertUserSkills = new SqlCommand("INSERT INTO UserSkills ([Username]) VALUES (@Username)");

            userCheck.Connection = db;
            insertUsers.Connection = db;
            insertUsersInformation.Connection = db;
            insertUserSkills.Connection = db;

            if (yesProfileButton.Checked == true)
            {
                try
                {
                    db.Open();

                    try
                    {
                        userCheck.Parameters.AddWithValue("@Username", usernameBox.Text);
                        queryResult = userCheck.ExecuteScalar();
                        String res = "Not Found";

                        res = Convert.ToString(queryResult);
                        if (!res.Equals(""))
                        {
                            MessageBox.Show("Username already exists!");
                        }
                        else
                        {
                            if (usernameBox.Text.Length >= 8 && passwordBox.Text.Length >= 8)
                            {
                                bool capital = false;
                                bool number = false;

                                int passwordCounter = 0;

                                String password = passwordBox.Text;

                                while (passwordCounter < passwordBox.Text.Length)
                                {
                                    if (password[passwordCounter] >= 65 && password[passwordCounter] <= 90)
                                    {
                                        capital = true;
                                    }

                                    if (password[passwordCounter] >= 48 && password[passwordCounter] <= 57)
                                    {
                                        number = true;
                                    }
                                }

                                if (capital == true && number == true)
                                {
                                    insertUsers.Parameters.AddWithValue("@Username", usernameBox.Text);
                                    insertUsers.Parameters.AddWithValue("@Password", passwordBox.Text);
                                    insertUsers.Parameters.AddWithValue("@ProjectManager", 1);

                                    insertUsersInformation.Parameters.AddWithValue("@Username", usernameBox.Text);
                                    insertUsersInformation.Parameters.AddWithValue("@Nickname", nickNameTxt.Text);
                                    insertUsersInformation.Parameters.AddWithValue("@ProfileLink", profileLinkBox.Text);

                                    insertUserSkills.Parameters.AddWithValue("@Username", usernameBox.Text);

                                    insertUsers.ExecuteNonQuery();
                                    insertUsersInformation.ExecuteNonQuery();
                                    insertUserSkills.ExecuteNonQuery();

                                    MainMenuForm mainMenuForm = new MainMenuForm();
                                    mainMenuForm.Width = this.Width;
                                    mainMenuForm.Height = this.Height;

                                    mainMenuForm.StartPosition = FormStartPosition.Manual;
                                    mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

                                    this.Hide();
                                    mainMenuForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Username or password was incorrect!");
                                }
                            }
                            else
                            {
                                if (usernameBox.Text.Length <= 8)
                                {
                                    MessageBox.Show("Error, username is less than 8 characters.");
                                }

                                if (passwordBox.Text.Length <= 8)
                                {
                                    MessageBox.Show("Error, password is less than 8 characters.");
                                }
                            }
                        }

                        db.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection unsuccessful, please try again. ");
                }
            }
            else
            {
                try
                {
                    db.Open();

                    try
                    {
                        userCheck.Parameters.AddWithValue("@Username", usernameBox.Text);
                        queryResult = userCheck.ExecuteScalar();
                        String res = "Not Found";

                        res = Convert.ToString(queryResult);
                        if (!res.Equals(""))
                        {
                            MessageBox.Show("Name already exists!");
                        }
                        else
                        {
                            if (usernameBox.Text.Length >= 8 && passwordBox.Text.Length >= 8)
                            {
                                bool capital = false;
                                bool number = false;

                                int passwordCounter = 0;

                                String password = passwordBox.Text;

                                while (passwordCounter < passwordBox.Text.Length)
                                {
                                    if (password[passwordCounter] >= 65 && password[passwordCounter] <= 90)
                                    {
                                        capital = true;
                                    }

                                    if (password[passwordCounter] >= 48 && password[passwordCounter] <= 57)
                                    {
                                        number = true;
                                    }
                                }

                                if (capital == true && number == true)
                                {
                                    insertUsers.Parameters.AddWithValue("@Username", usernameBox.Text);
                                    insertUsers.Parameters.AddWithValue("@Password", passwordBox.Text);
                                    insertUsers.Parameters.AddWithValue("@ProjectManager", 1);

                                    insertUsersInformation.Parameters.AddWithValue("@Username", usernameBox.Text);
                                    insertUsersInformation.Parameters.AddWithValue("@Nickname", nickNameTxt.Text);
                                    insertUsersInformation.Parameters.AddWithValue("@ProfileLink", profileLinkBox.Text);

                                    insertUserSkills.Parameters.AddWithValue("@Username", usernameBox.Text);

                                    insertUsers.ExecuteNonQuery();
                                    insertUsersInformation.ExecuteNonQuery();
                                    insertUserSkills.ExecuteNonQuery();

                                    SkillSetForm skillSetForm = new SkillSetForm();
                                    skillSetForm.Width = this.Width;
                                    skillSetForm.Height = this.Height;

                                    skillSetForm.StartPosition = FormStartPosition.Manual;
                                    skillSetForm.Location = new Point(this.Location.X, this.Location.Y);

                                    this.Hide();
                                    skillSetForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Username or password was incorrect!");
                                }
                            }
                            else
                            {
                                if (usernameBox.Text.Length <= 8)
                                {
                                    MessageBox.Show("Error, username is less than 8 characters.");
                                }

                                if (passwordBox.Text.Length <= 8)
                                {
                                    MessageBox.Show("Error, password is less than 8 characters.");
                                }
                            }
                        }

                        db.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection unsuccessful, please try again. ");
                }
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
