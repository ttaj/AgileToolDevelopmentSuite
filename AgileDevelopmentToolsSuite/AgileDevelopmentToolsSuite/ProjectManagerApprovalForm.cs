using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class ProjectManagerApprovalForm : Form
    {
        int approved = 0;

        public ProjectManagerApprovalForm()
        {
            InitializeComponent();
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

            SqlCommand userCheck = new SqlCommand("SELECT Username FROM [Users] WHERE (Username = @Username AND ProjectManger = @ProjectManager) OR (Username = @Username AND Administrator = @Administrator) ");
            SqlCommand passwordCheck = new SqlCommand("SELECT Password FROM [Users] WHERE (Password = @Password AND ProjectManger = @ProjectManager) OR (Password = @Password AND Administrator = @Administrator)");

            userCheck.Connection = db;
            passwordCheck.Connection = db;

            try
            {
                db.Open();

                try
                {
                    //check for user being correct
                    userCheck.Parameters.AddWithValue("@Username", usernameBox.Text);
                    userCheck.Parameters.AddWithValue("@ProjectManager", 1);
                    userCheck.Parameters.AddWithValue("@Administrator", 1);
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
                    passwordCheck.Parameters.AddWithValue("@ProjectManager", 1);
                    passwordCheck.Parameters.AddWithValue("@Administrator", 1);
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
                            MessageBox.Show("New Project Manager has been approved!");
                            approved = 1;
                            this.Hide();
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

        public int returnApproval()
        {
            return approved;
        }
    }
}
