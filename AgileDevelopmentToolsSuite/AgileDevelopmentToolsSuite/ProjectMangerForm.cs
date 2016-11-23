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
      SqlCommand insert;
      SqlCommand userCheck = new SqlCommand("SELECT [Username] FROM Users WHERE [Username] = @Username");
      if (yesProfileButton.Checked == true)
      {
        insert = new SqlCommand("INSERT INTO Users ([Username], [Password], [Nickname], [ProfileLink]) VALUES (@Username, @Password, @Nickname, @ProfileLink)");
      }
      else  //No profile link
      {
        insert = new SqlCommand("INSERT INTO Users ([Username], [Password], [Nickname]) VALUES (@Username, @Password, @Nickname)");
      }
      insert.Connection = db;
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
                MessageBox.Show("Inserting : " + usernameBox.Text + " into the list");
                insert.Parameters.AddWithValue("@Username", usernameBox.Text);
                insert.Parameters.AddWithValue("@Password", passwordBox.Text);
                insert.Parameters.AddWithValue("@Nickname", nickNameTxt.Text);
                if (yesProfileButton.Checked == true)
                  insert.Parameters.AddWithValue("@ProfileLink", profileLinkBox.Text);
                insert.ExecuteNonQuery();

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
                MessageBox.Show("Password is missing some of the criteria: Must be > 8 characters, have a CAPITAL letter, AND a number.");
              }
            }
            else
            {
              if (usernameBox.Text.Length <= 8)
              {
                MessageBox.Show("Error, username is less than 8 characters.");
                return;
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
