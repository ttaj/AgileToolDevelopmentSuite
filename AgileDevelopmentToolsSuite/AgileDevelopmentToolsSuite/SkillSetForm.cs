using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
  public partial class SkillSetForm : Form
  {
    String currentUser = "";

    public SkillSetForm()
    {
      InitializeComponent();
    }

    public SkillSetForm(String userName)
    {
      InitializeComponent();
      currentUser = userName;
    }

    private void radioButton29_CheckedChanged(object sender, EventArgs e)
    {

    }


    private void button1_Click(object sender, EventArgs e)
    {
      SqlConnection db;

      String version = "MSSQLLocalDB";
      String fileName = "ADTSDInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);

      SqlCommand insertSkills = new SqlCommand("Update UserSkills Set [Skill1] = @s1, [Skill2] = @s2, [Skill3] = @s3, [Skill4] = @s4, [Skill5] = @s5, [Skill6] = @s6, [Skill7] = @s7, [Skill8] = @s8, [Skill9] = @s9, [Skill10] = @s10 WHERE [Username] = @Username");
      SqlCommand insertProficiencies = new SqlCommand("Update UserSkills Set [SkillProficiency1] = @sp1, [SkillProficiency2] = @sp2, [SkillProficiency3] = @sp3, [SkillProficiency4] = @sp4, [SkillProficiency5] = @sp5, [SkillProficiency6] = @sp6, [SkillProficiency7] = @sp7, [SkillProficiency8] = @sp8, [SkillProficiency9] = @sp9, [SkillProficiency10] = @sp10 WHERE [Username] = @Username");

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


          insertSkills.Parameters.AddWithValue("@Username", currentUser);
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

          
          insertProficiencies.Parameters.AddWithValue("@Username", currentUser);

          insertProficiencies.ExecuteNonQuery();

          this.Hide();
          MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
          mainMenuForm.Width = this.Width;
          mainMenuForm.Height = this.Height;

          mainMenuForm.StartPosition = FormStartPosition.Manual;
          mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

          mainMenuForm.Closed += (s, args) => this.Close();
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
      }
    }

    private void SkillSetForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void skill1Box_TextChanged(object sender, EventArgs e)
    {

    }

    private void skill1Box_MouseClick(object sender, MouseEventArgs e)
    {
      skill1Box.Text = "";
      skill2Box.Text = "";
      skill3Box.Text = "";
      skill4Box.Text = "";
      skill5Box.Text = "";
      skill6Box.Text = "";
      skill7Box.Text = "";
      skill8Box.Text = "";
      skill9Box.Text = "";
      skill10Box.Text = "";
    }
  }
}
