﻿using System;
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

        if (yesProfileButton.Checked == true)
        {
            try
            {
                db.Open();
                MessageBox.Show("Connection Successful! ");

                try
                {
                    //need to add profile link, cant see table values currently
                    //need to add query to check for duplicate username
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Users] ([Username], [Password], [Nickname]) VALUES (@Username, @Password, @Nickname)");
                    cmd.Connection = db;
                    cmd.Parameters.AddWithValue("@Username", usernameBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordBox.Text);
                    cmd.Parameters.AddWithValue("@Nickname", nickNameTxt.Text);
                    cmd.ExecuteNonQuery();
                    db.Close();

                    MainMenuForm mainMenuForm = new MainMenuForm();
                    mainMenuForm.Width = this.Width;
                    mainMenuForm.Height = this.Height;

                    mainMenuForm.StartPosition = FormStartPosition.Manual;
                    mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

                    this.Hide();
                    mainMenuForm.Show();

                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection unsuccessful, please try again. ");
                return;
            }
        }
        else
        {
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

                    SkillSetForm skillSetForm = new SkillSetForm();
                    skillSetForm.Width = this.Width;
                    skillSetForm.Height = this.Height;

                    skillSetForm.StartPosition = FormStartPosition.Manual;
                    skillSetForm.Location = new Point(this.Location.X, this.Location.Y);

                    this.Hide();
                    skillSetForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection unsuccessful, please try again. ");
                return;
            }
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