using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class ProfileForm : Form
    {
    String currentUser = "";
    public ProfileForm()
    {
      InitializeComponent();
    }

    public ProfileForm(String curUser)
    {
      InitializeComponent();
      currentUser = curUser;
      nameLabel.Text = curUser;
    }

    private void resetView()
    {
      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();

        try
        {

          DataSet ds = new DataSet();

          
          SqlCommand getUserInfo = new SqlCommand("SELECT Nickname, ProfileLink, ProfilePictureLink, Workplace, PhoneNumber, Email FROM [UserInformation] WHERE [Username] = @Username");
          SqlCommand getSkillInfo = new SqlCommand("Select Skill1, Skill2, Skill3, Skill4, Skill5, Skill6, Skill7, Skill8, Skill9, Skill10 FROM [UserSkills] WHERE [Username] = @Username");
          SqlCommand getSkillProficiency = new SqlCommand("Select SkillProficiency1, SkillProficiency2, SkillProficiency3, SkillProficiency4, SkillProficiency5, SkillProficiency6, SkillProficiency7, SkillProficiency8, SkillProficiency9, SkillProficiency10 FROM [UserSkills] WHERE [Username] = @Username");

          getUserInfo.Connection = db;
          getSkillInfo.Connection = db;
          getSkillProficiency.Connection = db;

          getUserInfo.Parameters.AddWithValue("@Username", currentUser);
          getSkillInfo.Parameters.AddWithValue("@Username", currentUser);
          getSkillProficiency.Parameters.AddWithValue("@Username", currentUser);

          var reader = getUserInfo.ExecuteReader();
          
          while (reader.Read()) //Iterate through all the values of listed values from query
          {
            if(reader.GetString(0) != "")
            {
                nicknameLabel.Text = reader.GetString(0);
            }
            else
            {
                nicknameLabel.Text = "N/A";
            }

            if (reader.GetString(1) != "")
            {
                profileLinkLabel.Text = reader.GetString(1);
            }
            else
            {
                profileLinkLabel.Text = "N/A";
            }

            if (!reader.IsDBNull(2))
            {
                  var request = WebRequest.Create(reader.GetString(2));

                  using (var response = request.GetResponse())
                  using (var stream = response.GetResponseStream())
                  {
                    Bitmap original = (Bitmap) Bitmap.FromStream(stream);
                    Bitmap resized = new Bitmap(original, new Size(100, 100));
                    profilePictureBox.Image = resized;
                  }
            }

            if (reader.GetString(3) != "")
            {
                workplaceLabel.Text = reader.GetString(3);
            }
            else
            {
                workplaceLabel.Text = "N/A";
            }

            if (reader.GetString(4) != "")
            {
                phoneLabel.Text = reader.GetString(4);
            }
            else
            {
                phoneLabel.Text = "N/A";
            }

            if (reader.GetString(5) != "")
            {
                emailLabel.Text = reader.GetString(5);
            }
            else
            {
                emailLabel.Text = "N/A";
            }

            break;
          }

          reader = getSkillInfo.ExecuteReader();

          while(reader.Read())
          {
            if (reader.GetString(0) != "")
            {
                skillLabel1.Text = reader.GetString(0);
            }
            else
            {
                skillLabel1.Text = "N/A";
            }

            if (reader.GetString(1) != "")
            {
                skillLabel2.Text = reader.GetString(1);
            }
            else
            {
                skillLabel2.Text = "N/A";
            }

            if (reader.GetString(2) != "")
            {
                skillLabel3.Text = reader.GetString(2);
            }
            else
            {
                skillLabel3.Text = "N/A";
            }

            if (reader.GetString(3) != "")
            {
                skillLabel4.Text = reader.GetString(3);
            }
            else
            {
                skillLabel4.Text = "N/A";
            }

            if (reader.GetString(4) != "")
            {
                skillLabel5.Text = reader.GetString(4);
            }
            else
            {
                skillLabel5.Text = "N/A";
            }

            if (reader.GetString(5) != "")
            {
                skillLabel6.Text = reader.GetString(5);
            }
            else
            {
                skillLabel6.Text = "N/A";
            }

            if (reader.GetString(6) != "")
            {
                skillLabel7.Text = reader.GetString(6);
            }
            else
            {
                skillLabel7.Text = "N/A";
            }

            if (reader.GetString(7) != "")
            {
                skillLabel8.Text = reader.GetString(7);
            }
            else
            {
                skillLabel8.Text = "N/A";
            }

            if (reader.GetString(8) != "")
            {
                skillLabel9.Text = reader.GetString(8);
            }
            else
            {
                skillLabel9.Text = "N/A";
            }

            if (reader.GetString(9) != "")
            {
                skillLabel10.Text = reader.GetString(9);
            }
            else
            {
                skillLabel10.Text = "N/A";
            }

            break;
          }

          reader = getSkillProficiency.ExecuteReader();

          while(reader.Read())
          {
            if (reader.GetString(0) != "")
            {
                proficiencyLabel1.Text = reader.GetString(0);
            }
            else
            {
                proficiencyLabel1.Text = "N/A";
            }

            if (reader.GetString(1) != "")
            {
                proficiencyLabel2.Text = reader.GetString(1);
            }
            else
            {
                proficiencyLabel2.Text = "N/A";
            }

            if (reader.GetString(2) != "")
            {
                proficiencyLabel3.Text = reader.GetString(2);
            }
            else
            {
                proficiencyLabel3.Text = "N/A";
            }

            if (reader.GetString(3) != "")
            {
                proficiencyLabel4.Text = reader.GetString(3);
            }
            else
            {
                proficiencyLabel4.Text = "N/A";
            }

            if (reader.GetString(4) != "")
            {
                proficiencyLabel5.Text = reader.GetString(4);
            }
            else
            {
                proficiencyLabel5.Text = "N/A";
            }

            if (reader.GetString(5) != "")
            {
                proficiencyLabel6.Text = reader.GetString(5);
            }
            else
            {
                proficiencyLabel6.Text = "N/A";
            }

            if (reader.GetString(6) != "")
            {
                proficiencyLabel7.Text = reader.GetString(6);
            }
            else
            {
                proficiencyLabel7.Text = "N/A";
            }

            if (reader.GetString(7) != "")
            {
                proficiencyLabel8.Text = reader.GetString(7);
            }
            else
            {
                proficiencyLabel8.Text = "N/A";
            }

            if (reader.GetString(8) != "")
            {
                proficiencyLabel9.Text = reader.GetString(8);
            }
            else
            {
                proficiencyLabel9.Text = "N/A";
            }

            if (reader.GetString(9) != "")
            {
                proficiencyLabel10.Text = reader.GetString(9);
            }
            else
            {
                proficiencyLabel10.Text = "N/A";
            }

            break;
          }

          reader.Close();
          db.Close();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }



    private void menuButton_Click(object sender, EventArgs e)
    {
      this.Hide();

      MainMenuForm mainMenuForm = new MainMenuForm(currentUser);

      mainMenuForm.Width = this.Width;
      mainMenuForm.Height = this.Height;

      mainMenuForm.StartPosition = FormStartPosition.Manual;
      mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

      mainMenuForm.Closed += (s, args) => this.Close();
      mainMenuForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Hide();

        EditProfileForm editProfileForm = new EditProfileForm(currentUser);

        editProfileForm.Width = this.Width;
        editProfileForm.Height = this.Height;

        editProfileForm.StartPosition = FormStartPosition.Manual;
        editProfileForm.Location = new Point(this.Location.X, this.Location.Y);
        editProfileForm.Show();

        editProfileForm.Closed += (s, args) => this.Close();
        editProfileForm.Show();
    }

    private void skillLabel1_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
    private void ProfileForm_FormClosed(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void nameLabel_Click(object sender, EventArgs e)
    {

    }

    private void ProfileForm_Load(object sender, EventArgs e)
    {
      resetView();
      populateGroupList();
    }

        private void populateGroupList()
        {
            SqlConnection db;
            String version = "MSSQLLocalDB";
            String fileName = "ADTSDInfo.mdf";
            String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

            db = new SqlConnection(connectionString);

            try
            {
                db.Open();
                try
                {
                    DataSet ds = new DataSet();
                    string listGroupsCmd = "";


                    listGroupsCmd = "SELECT [GroupName] FROM GroupMembers WHERE [Username] = @Username";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;


                    cmd.CommandText = listGroupsCmd;
                    cmd.Parameters.AddWithValue("@Username", currentUser);
                    var reader = cmd.ExecuteReader();

                    groupProfileListView.View = View.Details;
                    groupProfileListView.Columns.Add("Group Name", 338);

                    //Iterate through all the values of listed values from query
                    int index = 0;
                    while (reader.Read())
                    {
                        groupProfileListView.Items.Add(reader.GetString(0));
                    }

                    reader.Close();
                    db.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupProfileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
