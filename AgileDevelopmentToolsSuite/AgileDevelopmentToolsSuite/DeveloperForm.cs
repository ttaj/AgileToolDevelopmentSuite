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
  public partial class DeveloperForm : Form
  {
    public DeveloperForm()
    {
      InitializeComponent();
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

      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDLoginInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        MessageBox.Show("Connection Successful! ");
        try
        {
          SqlCommand cmd = new SqlCommand("INSERT INTO [Users] ([Username], [Password], [Nickname]) VALUES (@Username, @Password, @Nickname)");
          cmd.Connection = db;
          cmd.Parameters.AddWithValue("@Username", usernameBox.Text);
          cmd.Parameters.AddWithValue("@Password", passwordBox.Text);
          cmd.Parameters.AddWithValue("@Nickname", nickNameTxt.Text);
          cmd.ExecuteNonQuery();
          db.Close();
        } catch(Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Connection unsuccessful, please try again. ");
        return;
      }

      //string insert = string.Format("INSERT INTO [Users] (Username, Password, Nickname) VALUES (@Username, @Password, @Nickname);");

   
      /*
      String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='Databases\ADTSDLoginInfo.mdf';Integrated Security=True";
      SqlConnection conn = new SqlConnection(connectionString);

      String insertLoginQuery = "INSERT INTO @database (@UsernameField, @PasswordField, @NicknameField) VALUES (@Username, @Password, @Nickname)";
      SqlCommand command = new SqlCommand(insertLoginQuery, conn);

      command.Parameters.AddWithValue("@database", "dbo.Login");
      command.Parameters.AddWithValue("@UsernameField", "Username");
      command.Parameters.AddWithValue("@PasswordField", "Password");
      command.Parameters.AddWithValue("@NicknameField", "Nickname");

      command.Parameters.AddWithValue("@Username", usernameBox.Text);
      command.Parameters.AddWithValue("@Password", passwordBox.Text);
      command.Parameters.AddWithValue("@Nickname", nickNameTxt.Text);

      */

      if (yesProfileButton.Checked == true)
      {
        try
        {
          //conn.Open();
          //command.ExecuteNonQuery();

          this.Hide();
          SkillSetForm skillSetForm = new SkillSetForm();
          skillSetForm.Show();
        }
        catch
        {

        }
      }
      else
      {

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
  }
}
