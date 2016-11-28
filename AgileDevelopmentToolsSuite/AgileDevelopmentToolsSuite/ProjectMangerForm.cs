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

        String username = "";
        String pass = "";
        String nickname = "";
        String profileLink = "";

        object queryResult;

        SqlCommand userCheck = new SqlCommand("SELECT [Username] FROM Users WHERE [Username] = @Username");

        userCheck.Connection = db;

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
                            username =  usernameBox.Text;
                            pass = passwordBox.Text;
                            nickname = nickNameTxt.Text;

                            if (yesProfileButton.Checked == true)
                            {
                                    profileLink = profileLinkBox.Text;
                            }

                            //direct to project manager approval form to get approval
                            this.Hide();
                            ProjectManagerApprovalForm projectManagerApprovalForm = new ProjectManagerApprovalForm(username, pass, nickname, profileLink);
                            projectManagerApprovalForm.Width = this.Width;
                            projectManagerApprovalForm.Height = this.Height;

                            projectManagerApprovalForm.StartPosition = FormStartPosition.Manual;
                            projectManagerApprovalForm.Location = new Point(this.Location.X, this.Location.Y);

                            projectManagerApprovalForm.Closed += (s, args) => this.Close();
                            projectManagerApprovalForm.Show();       
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
