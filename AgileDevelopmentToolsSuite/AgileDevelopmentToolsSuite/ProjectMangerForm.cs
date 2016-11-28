using System;
using System.Data.SqlClient;
using System.Drawing;
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
    private void ProjectMangerForm_FormClosed(object sender, FormClosingEventArgs e)
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
      createUser();
    }

    private void createUser()
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

        SqlCommand insert = new SqlCommand("INSERT INTO Users ([Username], [Password], [Developer]) VALUES (@Username, @Password, @Developer)");
        SqlCommand userCheck = new SqlCommand("SELECT [Username] FROM Users WHERE [Username] = @Username");
        SqlCommand insertUserSkills = new SqlCommand("INSERT INTO UserSkills ([Username]) VALUES (@Username)");
        SqlCommand insertUsersInformation;

        if (yesProfileButton.Checked == true)
        {
            insertUsersInformation = new SqlCommand("INSERT INTO UserInformation ([Username], [Nickname], [ProfileLink]) VALUES (@Username, @Nickname, @ProfileLink)");
        }
        else
        {
            insertUsersInformation = new SqlCommand("INSERT INTO UserInformation ([Username], [Nickname]) VALUES (@Username, @Nickname)");
        }

        insert.Connection = db;
        userCheck.Connection = db;
        insertUsersInformation.Connection = db;
        insertUserSkills.Connection = db;

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

                            passwordCounter++;
                        }

                        if (capital == true && number == true)
                        {
                            insert.Parameters.AddWithValue("@Username", usernameBox.Text);
                            insert.Parameters.AddWithValue("@Password", passwordBox.Text);
                            insert.Parameters.AddWithValue("@Developer", 1);

                            insertUsersInformation.Parameters.AddWithValue("@Username", usernameBox.Text);
                            insertUsersInformation.Parameters.AddWithValue("@Nickname", nickNameTxt.Text);

                            insertUserSkills.Parameters.AddWithValue("@Username", usernameBox.Text);

                            if (yesProfileButton.Checked == true)
                            {
                                insert.Parameters.AddWithValue("@ProfileLink", profileLinkBox.Text);
                                insertUsersInformation.Parameters.AddWithValue("@ProfileLink", profileLinkBox.Text);
                            }

                            ProjectManagerApprovalForm projectManagerApprovalForm = new ProjectManagerApprovalForm();
                            
                            while(projectManagerApprovalForm.returnApproval() != 1)
                            {
                                    //continue waiting for approval
                            }   
                            
                            insert.ExecuteNonQuery();
                            insertUsersInformation.ExecuteNonQuery();
                            insertUserSkills.ExecuteNonQuery();

                            //direct to skillset form to fill out skills
                            this.Hide();
                            SkillSetForm skillSetForm = new SkillSetForm(usernameBox.Text);
                            skillSetForm.Width = this.Width;
                            skillSetForm.Height = this.Height;

                            skillSetForm.StartPosition = FormStartPosition.Manual;
                            skillSetForm.Location = new Point(this.Location.X, this.Location.Y);

                            skillSetForm.Closed += (s, args) => this.Close();
                            skillSetForm.Show();       
                        }
                        else
                        {
                            MessageBox.Show("Password is missing some of the criteria: Must be greater than 8 characters, have a capital letter, and a number.");
                        }
                    }
                    else
                    {
                        if (usernameBox.Text.Length <= 8 || passwordBox.Text.Length <= 8)
                        {
                            MessageBox.Show("Error, username or password is less than 8 characters.");
                            return;
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

    private void usernameBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void ProjectManagerForm_Load(object sender, EventArgs e)
    {
      profileLinkBox.Show();
      profileLinkLabel.Show();
    }

  }
}
