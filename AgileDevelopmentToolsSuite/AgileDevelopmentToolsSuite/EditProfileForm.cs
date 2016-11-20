using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Width = this.Width;
            mainMenuForm.Height = this.Height;

            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            mainMenuForm.Show();
        }

        private void EditProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection db;

            String version = "MSSQLLocalDB";
            String fileName = "ADTSDLoginInfo.mdf";
            String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

            db = new SqlConnection(connectionString);

            //Figure out a way to make sure that the correct user is having their skills inserted (current user table?)
            SqlCommand insertSkills = new SqlCommand("INSERT INTO UserSkills ([Skill1], [Skill2], [Skill3], [Skill4], [Skill5], [Skill6], [Skill7], [Skill8], [Skill9], [Skill10]) VALUES (@s1, @s2, @s3, @s4, @s5, @s6, @s7, @s8, @s9, @s10) WHERE [Username] = @Username");
            SqlCommand insertProficiencies = new SqlCommand("INSERT INTO UserSkills ([SkillProficiency1], [SkillProficiency2], [SkillProficiency3], [SkillProficiency4], [SkillProficiency5], [SkillProficiency6], [SkillProficiency7], [SkillProficiency8], [SkillProficiency9], [SkillProficiency10]) VALUES (@sp1, @sp2, @sp3, @sp4, @sp5, @sp6, @sp7, @sp8, @sp9, @sp10) WHERE [Username] = @Username");

            insertSkills.Connection = db;
            insertProficiencies.Connection = db;

            try
            {

                db.Open();

                try
                {
                    //insert skills from each text box
                    insertSkills.Parameters.AddWithValue("@s1", skill1Box.Text);
                    insertSkills.Parameters.AddWithValue("@s2", skill2Box.Text);
                    insertSkills.Parameters.AddWithValue("@s3", skill3Box.Text);
                    insertSkills.Parameters.AddWithValue("@s4", skill4Box.Text);
                    insertSkills.Parameters.AddWithValue("@s5", skill5Box.Text);
                    insertSkills.Parameters.AddWithValue("@s6", skill6Box.Text);
                    insertSkills.Parameters.AddWithValue("@s7", skill7Box.Text);
                    insertSkills.Parameters.AddWithValue("@s8", skill8Box.Text);
                    insertSkills.Parameters.AddWithValue("@s9", skill9Box.Text);
                    insertSkills.Parameters.AddWithValue("@s10", skill10Box.Text);

                    insertSkills.ExecuteNonQuery();

                    //check skill 1 proficiency
                    if (master1Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp1", "Master");
                    else if (proficient1Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp1", "Proficient");
                    else if (beginner1Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp1", "Beginner");

                    //check skill 2 proficiency
                    if (master2Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp2", "Master");
                    else if (proficient2Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp2", "Proficient");
                    else if (beginner2Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp2", "Beginner");

                    //check skill 3 proficiency
                    if (master3Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp3", "Master");
                    else if (proficient3Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp3", "Proficient");
                    else if (beginner3Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp3", "Beginner");

                    //check skill 4 proficiency
                    if (master4Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp4", "Master");
                    else if (proficient4Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp4", "Proficient");
                    else if (beginner4Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp4", "Beginner");

                    //check skill 5 proficiency
                    if (master5Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp5", "Master");
                    else if (proficient5Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp5", "Proficient");
                    else if (beginner5Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp5", "Beginner");

                    //check skill 6 proficiency
                    if (master6Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp6", "Master");
                    else if (proficient6Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp6", "Proficient");
                    else if (beginner6Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp6", "Beginner");

                    //check skill 7 proficiency
                    if (master7Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp7", "Master");
                    else if (proficient7Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp7", "Proficient");
                    else if (beginner7Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp7", "Beginner");

                    //check skill 8 proficiency
                    if (master8Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp8", "Master");
                    else if (proficient8Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp8", "Proficient");
                    else if (beginner8Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp8", "Beginner");

                    //check skill 9 proficiency
                    if (master9Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp9", "Master");
                    else if (proficient9Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp9", "Proficient");
                    else if (beginner9Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp9", "Beginner");

                    //check skill 10 proficiency
                    if (master10Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp10", "Master");
                    else if (proficient10Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp10", "Proficient");
                    else if (beginner10Button.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp10", "Beginner");

                    insertProficiencies.ExecuteNonQuery();

                    //after saving changes, change back to normal profile form
                    ProfileForm profileForm = new ProfileForm();
                    profileForm.Width = this.Width;
                    profileForm.Height = this.Height;

                    profileForm.StartPosition = FormStartPosition.Manual;
                    profileForm.Location = new Point(this.Location.X, this.Location.Y);

                    this.Hide();
                    profileForm.Show();
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {

            }
        }
    }

}
