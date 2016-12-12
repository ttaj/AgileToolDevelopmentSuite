using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class EditProfileForm : Form
    {
        String currentUser = "";

        public EditProfileForm()
        {
            InitializeComponent();
        }

        public EditProfileForm(String givenUser)
        {
            InitializeComponent();
            currentUser = givenUser;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenuForm mainMenuForm = new MainMenuForm(currentUser);

            mainMenuForm.Width = this.Width;
            mainMenuForm.Height = this.Height;

            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);
            mainMenuForm.Show();

            mainMenuForm.Closed += (s, args) => this.Close();
            mainMenuForm.Show();
        }

        private void EditProfileForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            upChanges();
        }

        private void EditProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void profileLinkBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            setView();
        }

        private void setView()
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
                    SqlCommand getUserInfo = new SqlCommand("SELECT Name, Nickname, ProfileLink, ProfilePictureLink, Workplace, PhoneNumber, Email FROM [UserInformation] WHERE [Username] = @Username");
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
                        if (reader.GetString(0) != "")
                        {
                            nameBox.Text = reader.GetString(0);
                        }
                        else
                        {
                            nameBox.Text = "N/A";
                        }

                        if (reader.GetString(1) != "")
                        {
                            nicknameBox.Text = reader.GetString(1);
                        }
                        else
                        {
                            nicknameBox.Text = "N/A";
                        }

                        if (reader.GetString(2) != "")
                        {
                            profileLinkBox.Text = reader.GetString(2);
                        }
                        else
                        {
                            profileLinkBox.Text = "N/A";
                        }

                        if (!reader.IsDBNull(3))
                        {
                            var request = WebRequest.Create(reader.GetString(3));

                            if (request != null)
                            {
                                using (var response = request.GetResponse())
                                using (var stream = response.GetResponseStream())
                                {
                                    Bitmap original = (Bitmap)Bitmap.FromStream(stream);
                                    Bitmap resized;

                                    double ratio = (double)original.Width / (double)original.Height;

                                    if ((int)((double)100 * ratio) <= 100)
                                    {
                                        resized = new Bitmap(original, (int)((double)100 * ratio), 100);
                                    }
                                    else
                                    {
                                        resized = new Bitmap(original, 100, (int)((double)100 / ratio));
                                    }

                                    profilePictureBox.Image = resized;
                                    profilePictureLinkBox.Text = reader.GetString(3);
                                }
                            }
                        }

                        if (reader.GetString(4) != "")
                        {
                            workplaceBox.Text = reader.GetString(4);
                        }
                        else
                        {
                            workplaceBox.Text = "N/A";
                        }

                        if (reader.GetString(5) != "")
                        {
                            phoneBox.Text = reader.GetString(5);
                        }
                        else
                        {
                            phoneBox.Text = "N/A";
                        }

                        if (reader.GetString(6) != "")
                        {
                            emailBox.Text = reader.GetString(6);
                        }
                        else
                        {
                            emailBox.Text = "N/A";
                        }

                        break;
                    }

                    reader = getSkillInfo.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(0) != "")
                        {
                            skill1Box.Text = reader.GetString(0);
                        }
                        else
                        {
                            skill1Box.Text = "N/A";
                        }

                        if (reader.GetString(1) != "")
                        {
                            skill2Box.Text = reader.GetString(1);
                        }
                        else
                        {
                            skill2Box.Text = "N/A";
                        }

                        if (reader.GetString(2) != "")
                        {
                            skill3Box.Text = reader.GetString(2);
                        }
                        else
                        {
                            skill3Box.Text = "N/A";
                        }

                        if (reader.GetString(3) != "")
                        {
                            skill4Box.Text = reader.GetString(3);
                        }
                        else
                        {
                            skill4Box.Text = "N/A";
                        }

                        if (reader.GetString(4) != "")
                        {
                            skill5Box.Text = reader.GetString(4);
                        }
                        else
                        {
                            skill5Box.Text = "N/A";
                        }

                        if (reader.GetString(5) != "")
                        {
                            skill6Box.Text = reader.GetString(5);
                        }
                        else
                        {
                            skill6Box.Text = "N/A";
                        }

                        if (reader.GetString(6) != "")
                        {
                            skill7Box.Text = reader.GetString(6);
                        }
                        else
                        {
                            skill7Box.Text = "N/A";
                        }

                        if (reader.GetString(7) != "")
                        {
                            skill8Box.Text = reader.GetString(7);
                        }
                        else
                        {
                            skill8Box.Text = "N/A";
                        }

                        if (reader.GetString(8) != "")
                        {
                            skill9Box.Text = reader.GetString(8);
                        }
                        else
                        {
                            skill9Box.Text = "N/A";
                        }

                        if (reader.GetString(9) != "")
                        {
                            skill10Box.Text = reader.GetString(9);
                        }
                        else
                        {
                            skill10Box.Text = "N/A";
                        }

                        break;
                    }

                    reader = getSkillProficiency.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(0).Equals("Master"))
                        {
                            master1Button.Checked = true;
                        }
                        else if (reader.GetString(0).Equals("Proficient"))
                        {
                            proficient1Button.Checked = true;
                        }

                        if (reader.GetString(1).Equals("Master"))
                        {
                            master2Button.Checked = true;
                        }
                        else if (reader.GetString(1).Equals("Proficient"))
                        {
                            proficient2Button.Checked = true;
                        }

                        if (reader.GetString(2).Equals("Master"))
                        {
                            master3Button.Checked = true;
                        }
                        else if (reader.GetString(2).Equals("Proficient"))
                        {
                            proficient3Button.Checked = true;
                        }

                        if (reader.GetString(3).Equals("Master"))
                        {
                            master4Button.Checked = true;
                        }
                        else if (reader.GetString(3).Equals("Proficient"))
                        {
                            proficient4Button.Checked = true;
                        }

                        if (reader.GetString(4).Equals("Master"))
                        {
                            master5Button.Checked = true;
                        }
                        else if (reader.GetString(4).Equals("Proficient"))
                        {
                            proficient5Button.Checked = true;
                        }

                        if (reader.GetString(5).Equals("Master"))
                        {
                            master6Button.Checked = true;
                        }
                        else if (reader.GetString(5).Equals("Proficient"))
                        {
                            proficient6Button.Checked = true;
                        }

                        if (reader.GetString(6).Equals("Master"))
                        {
                            master7Button.Checked = true;
                        }
                        else if (reader.GetString(6).Equals("Proficient"))
                        {
                            proficient7Button.Checked = true;
                        }

                        if (reader.GetString(7).Equals("Master"))
                        {
                            master8Button.Checked = true;
                        }
                        else if (reader.GetString(7).Equals("Proficient"))
                        {
                            proficient8Button.Checked = true;
                        }

                        if (reader.GetString(8).Equals("Master"))
                        {
                            master9Button.Checked = true;
                        }
                        else if (reader.GetString(8).Equals("Proficient"))
                        {
                            proficient9Button.Checked = true;
                        }

                        if (reader.GetString(9).Equals("Master"))
                        {
                            master10Button.Checked = true;
                        }
                        else if (reader.GetString(9).Equals("Proficient"))
                        {
                            proficient10Button.Checked = true;
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

        private void upChanges()
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
                    SqlCommand updateUserInfo = new SqlCommand("UPDATE UserInformation SET [Name] = @Name, [Nickname] = @Nickname, [ProfileLink] = @ProfileLink, [ProfilePictureLink] = @ProfilePictureLink, [Workplace] = @Workplace, [PhoneNumber] = @PhoneNumber, [Email] = @Email FROM [UserInformation] WHERE [Username] = @Username");
                    SqlCommand updateSkillInfo = new SqlCommand("Update UserSkills Set [Skill1] = @s1, [Skill2] = @s2, [Skill3] = @s3, [Skill4] = @s4, [Skill5] = @s5, [Skill6] = @s6, [Skill7] = @s7, [Skill8] = @s8, [Skill9] = @s9, [Skill10] = @s10 WHERE [Username] = @Username");
                    SqlCommand updateSkillProficiency = new SqlCommand("Update UserSkills Set [SkillProficiency1] = @sp1, [SkillProficiency2] = @sp2, [SkillProficiency3] = @sp3, [SkillProficiency4] = @sp4, [SkillProficiency5] = @sp5, [SkillProficiency6] = @sp6, [SkillProficiency7] = @sp7, [SkillProficiency8] = @sp8, [SkillProficiency9] = @sp9, [SkillProficiency10] = @sp10 WHERE [Username] = @Username");

                    updateUserInfo.Connection = db;
                    updateSkillInfo.Connection = db;
                    updateSkillProficiency.Connection = db;

                    updateUserInfo.Parameters.AddWithValue("@Username", currentUser);
                    updateUserInfo.Parameters.AddWithValue("@Name", nameBox.Text);
                    updateUserInfo.Parameters.AddWithValue("@Nickname", nicknameBox.Text);
                    updateUserInfo.Parameters.AddWithValue("@ProfileLink", profileLinkBox.Text);
                    updateUserInfo.Parameters.AddWithValue("@ProfilePictureLink", profilePictureLinkBox.Text);
                    updateUserInfo.Parameters.AddWithValue("@Workplace", workplaceBox.Text);
                    updateUserInfo.Parameters.AddWithValue("@PhoneNumber", phoneBox.Text);
                    updateUserInfo.Parameters.AddWithValue("@Email", emailBox.Text);

                    updateUserInfo.ExecuteNonQuery();

                    updateSkillInfo.Parameters.AddWithValue("@Username", currentUser);
                    updateSkillInfo.Parameters.AddWithValue("@s1", skill1Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s2", skill2Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s3", skill3Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s4", skill4Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s5", skill5Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s6", skill6Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s7", skill7Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s8", skill8Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s9", skill9Box.Text);
                    updateSkillInfo.Parameters.AddWithValue("@s10", skill10Box.Text);

                    updateSkillInfo.ExecuteNonQuery();

                    updateSkillProficiency.Parameters.AddWithValue("@Username", currentUser);

                    //check skill 1 proficiency
                    if (skill1Box.Text != "")
                    {
                        if (master1Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp1", "Master");
                        else if (proficient1Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp1", "Proficient");
                        else if (beginner1Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp1", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp1", "N/A");
                    }

                    //check skill 2 proficiency
                    if (skill2Box.Text != "")
                    {
                        if (master2Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp2", "Master");
                        else if (proficient2Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp2", "Proficient");
                        else if (beginner2Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp2", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp2", "N/A");
                    }

                    //check skill 3 proficiency
                    if (skill3Box.Text != "")
                    {
                        if (master3Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp3", "Master");
                        else if (proficient3Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp3", "Proficient");
                        else if (beginner3Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp3", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp3", "N/A");
                    }

                    //check skill 4 proficiency
                    if (skill4Box.Text != "")
                    {
                        if (master4Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp4", "Master");
                        else if (proficient4Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp4", "Proficient");
                        else if (beginner4Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp4", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp4", "N/A");
                    }

                    //check skill 5 proficiency
                    if (skill5Box.Text != "")
                    {
                        if (master5Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp5", "Master");
                        else if (proficient5Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp5", "Proficient");
                        else if (beginner5Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp5", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp5", "N/A");
                    }

                    //check skill 6 proficiency
                    if (skill6Box.Text != "")
                    {
                        if (master6Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp6", "Master");
                        else if (proficient6Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp6", "Proficient");
                        else if (beginner6Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp6", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp6", "N/A");
                    }

                    //check skill 7 proficiency
                    if (skill7Box.Text != "")
                    {
                        if (master7Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp7", "Master");
                        else if (proficient7Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp7", "Proficient");
                        else if (beginner7Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp7", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp7", "N/A");
                    }

                    //check skill 8 proficiency
                    if (skill8Box.Text != "")
                    {
                        if (master8Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp8", "Master");
                        else if (proficient8Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp8", "Proficient");
                        else if (beginner8Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp8", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp8", "N/A");
                    }

                    //check skill 9 proficiency
                    if (skill9Box.Text != "")
                    {
                        if (master9Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp9", "Master");
                        else if (proficient9Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp9", "Proficient");
                        else if (beginner9Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp9", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp9", "N/A");
                    }

                    //check skill 10 proficiency
                    if (skill10Box.Text != "")
                    {
                        if (master10Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp10", "Master");
                        else if (proficient10Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp10", "Proficient");
                        else if (beginner10Button.Checked == true)
                            updateSkillProficiency.Parameters.AddWithValue("@sp10", "Beginner");
                    }
                    else
                    {
                        updateSkillProficiency.Parameters.AddWithValue("@sp10", "N/A");
                    }

                    updateSkillProficiency.ExecuteNonQuery();
                    db.Close();

                    this.Hide();
                    ProfileForm profileForm = new ProfileForm(currentUser);

                    profileForm.Width = this.Width;
                    profileForm.Height = this.Height;

                    profileForm.StartPosition = FormStartPosition.Manual;
                    profileForm.Location = new Point(this.Location.X, this.Location.Y);

                    profileForm.Closed += (s, args) => this.Close();
                    profileForm.Show();
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
    }
}