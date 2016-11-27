using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
  public partial class DeveloperForm : Form
  {
    public DeveloperForm()
    {
      InitializeComponent();
    }


    private void DeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
    private void DeveloperForm_FormClosed(object sender, FormClosingEventArgs e)
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
      //String fileName = "ADTSDLoginInfo.mdf";
      String fileName = "ADTSDInfo.mdf";
      //String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);
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

      SqlCommand insertUsersInformation;
      SqlCommand insertUserSkills = new SqlCommand("INSERT INTO UserSkills ([Username]) VALUES (@Username)");
      if (yesProfileButton.Checked == true)
      {
        insertUsersInformation = new SqlCommand("INSERT INTO UserInformation ([Username], [Nickname], [ProfileLink]) VALUES (@Username, @Nickname, @ProfileLink)");
      }
      else  //No profile link
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
                MessageBox.Show("User successfully created!");
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
                  
                insert.ExecuteNonQuery();
                insertUsersInformation.ExecuteNonQuery();
                insertUserSkills.ExecuteNonQuery();


                if (yesProfileButton.Checked == false)
                {
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
                  this.Hide();
                  MainMenuForm mainMenu = new MainMenuForm();
                  mainMenu.Width = this.Width;
                  mainMenu.Height = this.Height;

                  mainMenu.StartPosition = FormStartPosition.Manual;
                  mainMenu.Location = new Point(this.Location.X, this.Location.Y);

                  mainMenu.Closed += (s, args) => this.Close();
                  mainMenu.Show();
                }
                  
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

    private void usernameLabel_Click(object sender, EventArgs e)
    {

    }

    private void usernameBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void profileLinkBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void DeveloperForm_Load(object sender, EventArgs e)
    {
      profileLinkBox.Show();
      profileLinkLabel.Show();
    }
  }
}
