using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class GroupProfileForm : Form
    {
        string currentUser = "";
        string currentGroup = "";
        public GroupProfileForm()
        {
            InitializeComponent();
        }

        public GroupProfileForm(string curUser, string curGroup)
        {
            InitializeComponent();
            currentUser = curUser;
            currentGroup = curGroup;
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

        private void GroupProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void GroupProfileForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            EditGroupProfileForm editGroupProfileForm = new EditGroupProfileForm(currentUser, currentGroup);

            editGroupProfileForm.Width = this.Width;
            editGroupProfileForm.Height = this.Height;

            editGroupProfileForm.StartPosition = FormStartPosition.Manual;
            editGroupProfileForm.Location = new Point(this.Location.X, this.Location.Y);

            editGroupProfileForm.Closed += (s, args) => this.Close();
            editGroupProfileForm.Show();
        }

        private void GroupProfileForm_Load(object sender, EventArgs e)
        {
            setGroupInformation();
            setContactInformation();
        }

        private void setGroupInformation()
        {
            groupNameHeaderLabel.Text = currentGroup;

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
                    SqlCommand getGroupNames = new SqlCommand("SELECT UserInformation.Name FROM UserInformation INNER JOIN GroupMembers ON UserInformation.Username = GroupMembers.Username AND GroupMembers.GroupName = @currentGroup");
                    SqlCommand getGroupNicknames = new SqlCommand("SELECT UserInformation.Nickname FROM UserInformation INNER JOIN GroupMembers ON UserInformation.Username = GroupMembers.Username AND GroupMembers.GroupName = @currentGroup");
                    SqlCommand getGroupPictureAndGoal = new SqlCommand("SELECT GroupProfilePictureLink, GroupGoal FROM GroupInformation WHERE GroupName = @currentGroup");

                    getGroupNames.Connection = db;
                    getGroupNicknames.Connection = db;
                    getGroupPictureAndGoal.Connection = db;

                    getGroupNames.Parameters.AddWithValue("@currentGroup", currentGroup);
                    getGroupNicknames.Parameters.AddWithValue("@currentGroup", currentGroup);
                    getGroupPictureAndGoal.Parameters.AddWithValue("@currentGroup", currentGroup);

                    String nameList = "";
                    String nicknameList = "";

                    var reader = getGroupNames.ExecuteReader();
                    while (reader.Read())
                    {
                        nameList = nameList + reader.GetString(0) + " ";
                    }
                    nameLabel.Text = nameList;

                    reader = getGroupNicknames.ExecuteReader();
                    while (reader.Read())
                    {
                        nicknameList = nicknameList + reader.GetString(0) + " ";
                    }
                    nicknameLabel.Text = nicknameList;

                    reader = getGroupPictureAndGoal.ExecuteReader();
                    while(reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            var request = WebRequest.Create(reader.GetString(0));

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
                                }
                            }
                        }

                        groupGoalTextBox.Text = reader.GetString(1);

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

        private void setContactInformation()
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
                    string listContactInfoCmd = "";

                    listContactInfoCmd = "SELECT UserInformation.Name, UserInformation.Nickname, UserInformation.ProfileLink, UserInformation.Workplace, UserInformation.PhoneNumber, UserInformation.Email FROM UserInformation INNER JOIN GroupMembers ON UserInformation.Username = GroupMembers.Username AND GroupMembers.GroupName = @currentGroup";

                    SqlCommand getContactInformation = new SqlCommand();
                    getContactInformation.Connection = db;

                    getContactInformation.CommandText = listContactInfoCmd;
                    getContactInformation.Parameters.AddWithValue("@currentGroup", currentGroup);

                    var reader = getContactInformation.ExecuteReader();

                    List<string[]> contactList = new List<string[]>();

                    int index = 0;
                    while (reader.Read())
                    {
                        String[] columns = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        contactList.Add(columns);
                        index++;
                    }

                    groupContactListView.Items.Clear();
                    groupContactListView.Columns.Clear();

                    groupContactListView.View = View.Details;
                    groupContactListView.Columns.Add("Name", 125);
                    groupContactListView.Columns.Add("Nickname", 125);
                    groupContactListView.Columns.Add("Profile Link", 125);
                    groupContactListView.Columns.Add("Workplace", 125);
                    groupContactListView.Columns.Add("Phone Number", 120);
                    groupContactListView.Columns.Add("Email", 125);

                    for (int i = 0; i < contactList.Count; i++)      //Add items into listView box
                    {
                        var listViewItem = new ListViewItem(contactList[i]);

                        groupContactListView.Items.Add(listViewItem);
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
    }
}
