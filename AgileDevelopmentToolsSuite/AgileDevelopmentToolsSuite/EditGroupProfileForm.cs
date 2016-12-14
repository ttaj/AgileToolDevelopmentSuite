using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class EditGroupProfileForm : Form
    {
        String currentUser = "";
        String currentGroup = "";

        public EditGroupProfileForm()
        {
            InitializeComponent();
        }

        public EditGroupProfileForm(String givenUser, String givenGroup)
        {
            InitializeComponent();
            currentUser = givenUser;
            currentGroup = givenGroup;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            updateChanges();
        }

        private void EditGroupProfileForm_Load(object send, EventArgs e)
        {
            setView();
        }

        private void setView()
        {
            groupNameBox.Text = currentGroup;

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
                    SqlCommand getGroupInformation = new SqlCommand("SELECT GroupName, GroupProfilePictureLink, GroupGoal FROM GroupInformation WHERE GroupName = @currentGroup");

                    getGroupInformation.Connection = db;

                    getGroupInformation.Parameters.AddWithValue("@currentGroup", currentGroup);

                    var reader = getGroupInformation.ExecuteReader();

                    while(reader.Read())
                    {
                        groupNameBox.Text = reader.GetString(0);

                        if (!reader.IsDBNull(1))
                        {
                            groupProfilePictureLinkBox.Text = reader.GetString(1);
                        }

                        groupGoalTextBox.Text = reader.GetString(2);
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

        private void updateChanges()
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
                    if (!string.IsNullOrWhiteSpace(groupProfilePictureLinkBox.Text))
                    {
                        SqlCommand getGroupInformation = new SqlCommand("UPDATE GroupInformation SET [GroupName] = @groupName, [GroupProfilePictureLink] = @groupProfilePictureLink, [GroupGoal] = @groupGoal WHERE GroupName = @currentGroup");
                        getGroupInformation.Connection = db;

                        getGroupInformation.Parameters.AddWithValue("@groupName", groupNameBox.Text);
                        getGroupInformation.Parameters.AddWithValue("@groupProfilePictureLink", groupProfilePictureLinkBox.Text);
                        getGroupInformation.Parameters.AddWithValue("@groupGoal", groupGoalTextBox.Text);
                        getGroupInformation.Parameters.AddWithValue("@currentGroup", currentGroup);
                        getGroupInformation.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand getGroupInformationWithoutLink = new SqlCommand("UPDATE GroupInformation SET [GroupName] = @groupName, [GroupGoal] = @groupGoal WHERE GroupName = @currentGroup");
                        getGroupInformationWithoutLink.Connection = db;

                        getGroupInformationWithoutLink.Parameters.AddWithValue("@groupName", groupNameBox.Text);
                        getGroupInformationWithoutLink.Parameters.AddWithValue("@groupGoal", groupGoalTextBox.Text);
                        getGroupInformationWithoutLink.Parameters.AddWithValue("@currentGroup", currentGroup);
                        getGroupInformationWithoutLink.ExecuteNonQuery();
                    }

                    db.Close();

                    this.Hide();

                    GroupProfileForm groupProfileForm = new GroupProfileForm(currentUser, currentGroup);

                    groupProfileForm.Width = this.Width;
                    groupProfileForm.Height = this.Height;

                    groupProfileForm.StartPosition = FormStartPosition.Manual;
                    groupProfileForm.Location = new Point(this.Location.X, this.Location.Y);

                    groupProfileForm.Closed += (s, args) => this.Close();
                    groupProfileForm.Show();
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
