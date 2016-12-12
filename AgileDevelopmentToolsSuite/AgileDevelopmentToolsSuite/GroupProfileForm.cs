using System;
using System.Data.SqlClient;
using System.Drawing;
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

            EditGroupProfileForm editGroupProfileForm = new EditGroupProfileForm();

            editGroupProfileForm.Width = this.Width;
            editGroupProfileForm.Height = this.Height;

            editGroupProfileForm.StartPosition = FormStartPosition.Manual;
            editGroupProfileForm.Location = new Point(this.Location.X, this.Location.Y);

            editGroupProfileForm.Closed += (s, args) => this.Close();
            editGroupProfileForm.Show();
        }

        private void GroupProfileForm_Load(object sender, EventArgs e)
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
                    string listContactInfoCmd = "";

                    listContactInfoCmd = "SELECT UserInformation.Name, UserInformation.Nickname, UserInformation.ProfileLink, UserInformation.Workplace, UserInformation.PhoneNumber, UserInformation.Email FROM UserInformation FULL OUTER JOIN GroupMembers ON UserInformation.Username = GroupMembers.Username WHERE GroupMembers.GroupName = @currentGroup";

                    SqlCommand getContactInformation = new SqlCommand();
                    getContactInformation.Connection = db;

                    getContactInformation.CommandText = listContactInfoCmd;
                    getContactInformation.Parameters.AddWithValue("@currentGroup", currentGroup);
                    var reader = getContactInformation.ExecuteReader();

                    groupContactListView.View = View.Details;
                    groupContactListView.Columns.Add("Name", 120);
                    groupContactListView.Columns.Add("Nickname", 120);
                    groupContactListView.Columns.Add("Profile Link", 120);
                    groupContactListView.Columns.Add("Workplace", 120);
                    groupContactListView.Columns.Add("Phone Number", 120);
                    groupContactListView.Columns.Add("Email", 120);

                    while (reader.Read())
                    {
                        groupContactListView.Items.Add(reader.GetString(0));
                        groupContactListView.Items.Add(reader.GetString(1));
                        groupContactListView.Items.Add(reader.GetString(2));
                        groupContactListView.Items.Add(reader.GetString(3));
                        groupContactListView.Items.Add(reader.GetString(4));
                        groupContactListView.Items.Add(reader.GetString(5));
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
