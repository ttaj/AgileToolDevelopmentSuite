using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class ProjectManagerApprovalForm : Form
    {
        String user = "";
        String pass = "";
        String nickname = "";
        String profileLink = "";

        public ProjectManagerApprovalForm()
        {
            InitializeComponent();
        }

        public ProjectManagerApprovalForm(String givenUser, String givenPass, String givenNick, String givenProfile)
        {
            InitializeComponent();

            user = givenUser;
            pass = givenPass;
            nickname = givenNick;
            profileLink = givenProfile;
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            approve();
        }

        private void approve()
        {
            SqlConnection db;

            String version = "MSSQLLocalDB";
            String fileName = "ADTSDInfo.mdf";
            String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

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

            SqlCommand userCheck = new SqlCommand("SELECT [Username] FROM Users WHERE [Username] = @Username AND ([ProjectManager] = @ProjectManager OR [Administrator] = @Administrator)");
            SqlCommand passwordCheck = new SqlCommand("SELECT [Password] FROM Users WHERE [Password] = @Password AND ([ProjectManager] = @ProjectManager OR [Administrator] = @Administrator)");
            SqlCommand insertUser = new SqlCommand("INSERT INTO Users ([Username], [Password], [ProjectManager]) VALUES (@Username, @Password, @ProjectManager)");
            SqlCommand insertUserSkills = new SqlCommand("INSERT INTO UserSkills ([Username]) VALUES (@Username)");
            SqlCommand insertUsersInformation = new SqlCommand("INSERT INTO UserInformation ([Username], [Nickname], [ProfileLink]) VALUES (@Username, @Nickname, @ProfileLink)");

            userCheck.Connection = db;
            passwordCheck.Connection = db;
            insertUser.Connection = db;
            insertUserSkills.Connection = db;
            insertUsersInformation.Connection = db;

            try
            {
                db.Open();

                try
                {
                    //check for user being correct
                    userCheck.Parameters.AddWithValue("@Username", usernameBox.Text);
                    userCheck.Parameters.AddWithValue("@ProjectManager", true);
                    userCheck.Parameters.AddWithValue("@Administrator", true);
                    queryResult = userCheck.ExecuteScalar();
                    String res = "Not Found";

                    res = Convert.ToString(queryResult);

                    if (res.Equals(""))
                    {
                        MessageBox.Show("User is not a Project Manager or Administrator!");
                        return;
                    }
                    else
                    {
                        if (!res.Equals(usernameBox.Text))
                        {
                            MessageBox.Show("Username or Password is incorrect!");
                        }
                    }

                    //check for password being correct
                    passwordCheck.Parameters.AddWithValue("@Password", passwordBox.Text);
                    passwordCheck.Parameters.AddWithValue("@ProjectManager", true);
                    passwordCheck.Parameters.AddWithValue("@Administrator", true);
                    queryResult = passwordCheck.ExecuteScalar();
                    res = "Not Found";

                    res = Convert.ToString(queryResult);
                    if (res.Equals(""))
                    {
                        MessageBox.Show("User is not a Project Manager or Administrator!");
                        return;
                    }
                    else
                    {
                        if (!res.Equals(passwordBox.Text))
                        {
                            MessageBox.Show("Username or Password is incorrect!");
                        }
                        else
                        {
                            insertUser.Parameters.AddWithValue("@Username", user);
                            insertUser.Parameters.AddWithValue("@Password", pass);
                            insertUser.Parameters.AddWithValue("@ProjectManager", 1);

                            insertUserSkills.Parameters.AddWithValue("@Username", user);

                            insertUsersInformation.Parameters.AddWithValue("@Username", user);
                            insertUsersInformation.Parameters.AddWithValue("@Nickname", nickname);
                            insertUsersInformation.Parameters.AddWithValue("@ProfileLink", profileLink);

                            insertUser.ExecuteNonQuery();
                            insertUserSkills.ExecuteNonQuery();
                            insertUsersInformation.ExecuteNonQuery();

                            MessageBox.Show("New Project Manager has been approved!");

                            this.Hide();
                            SkillSetForm skillSetForm = new SkillSetForm(user);
                            skillSetForm.Width = this.Width;
                            skillSetForm.Height = this.Height;

                            skillSetForm.StartPosition = FormStartPosition.Manual;
                            skillSetForm.Location = new Point(this.Location.X, this.Location.Y);

                            skillSetForm.Closed += (s, args) => this.Close();
                            skillSetForm.Show();
                        }
                    }
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
}
