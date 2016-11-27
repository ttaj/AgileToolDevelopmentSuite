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
  public partial class MainMenuForm : Form
  {
    String listView2SelectedName = "";
    String currentUser = "";
    int listView2SelectedID = 0;
    

    public MainMenuForm()
    {
      InitializeComponent();
    }

    public MainMenuForm(String curUser)
    {
      InitializeComponent();
      currentUser = curUser;
      loggedInTextBox.Text = curUser;
      
    }

    string numUrgentTasks = "";

    private void MainMenuForm_Load(object sender, EventArgs e)
    {
      panel1.Hide();
      resetListView();
      resetListView2();
      listView1.FullRowSelect = true;
      listView2.FullRowSelect = true;
      createSuggestionPanel.Visible = false;
      confirmDeletePanel.Visible = false;
      deleteSuggestionButton.Enabled = false;
      upvoteButton.Enabled = false;
      downvoteButton.Enabled = false;

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

          string saveChanges = @"SELECT COUNT(Importance) FROM [Tasks] Where Importance = 'Urgent'";

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;

          cmd.CommandText = saveChanges;
          var numUrgent = cmd.ExecuteScalar().ToString();

          numUrgentTasks = numUrgent;

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



      if (numUrgentTasks != "0")
      {
        urgentTaskButton.Text = numUrgentTasks + " Urgent tasks to do!";
        urgentTaskButton.BackColor = System.Drawing.Color.Firebrick;
        urgentTaskButton.ForeColor = System.Drawing.Color.White;
      }

      else
      {
        urgentTaskButton.Text = "No urgent tasks available.";
        urgentTaskButton.ForeColor = System.Drawing.Color.Black;
        urgentTaskButton.BackColor = System.Drawing.Color.White;
      }

    }

    private void menuNumUrgentTasks_TextChanged(object sender, EventArgs e)
    {

    }

    private void menuGroupNameTxt_TextChanged(object sender, EventArgs e)
    {
      LoginForm loginForm = new LoginForm();

      loginForm.Width = this.Width;
      loginForm.Height = this.Height;

      loginForm.StartPosition = FormStartPosition.Manual;
      loginForm.Location = new Point(this.Location.X, this.Location.Y);

      this.Hide();
      loginForm.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      ProfileForm profileForm = new ProfileForm(currentUser);

      profileForm.Width = this.Width;
      profileForm.Height = this.Height;

      profileForm.StartPosition = FormStartPosition.Manual;
      profileForm.Location = new Point(this.Location.X, this.Location.Y);

      profileForm.Closed += (s, args) => this.Close();
      profileForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (!panel1.Visible)
        panel1.Show();
      else
        panel1.Hide();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      HostForm h = new HostForm();
      h.Show();
    }

    private void urgentTaskButton_Click(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Hide();
      TaskForm t = new TaskForm(currentUser);
      t.Width = this.Width;
      t.Height = this.Height;

      t.StartPosition = FormStartPosition.Manual;
      t.Location = new Point(this.Location.X, this.Location.Y);
      t.Closed += (s, args) => this.Close();
      t.Show();
    }

    int sortBy = 0;
    public void resetListView()   //Reset ListView, sortstyle is for the type of sorting, 0 = date issued, 1 = importance, 2 = taskname, 3 = ID, 4 = Date modified, 5 = User Assigned
    {
      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        //MessageBox.Show("Connection Successful! ");
        try
        {

          DataSet ds = new DataSet();
          string listTasksCmd = "";


          listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified, ProjectGroup FROM [Tasks] ORDER BY Importance Desc";



          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;


          cmd.CommandText = listTasksCmd;
          var reader = cmd.ExecuteReader();

          // Use list to generate a display for the listbox (to carry info)
          List<string[]> listTasks = new List<string[]>();

          //Iterate through all the values of listed values from query
          int index = 0;
          while (reader.Read())
          {
            //Concatenate years with the number of crimes occurence that year by Group By
            //Math round(number, # of decimals)
            String dateModifyTemp;
            if (reader.IsDBNull(6))
            {
              dateModifyTemp = "";
            }
            else
            {
              dateModifyTemp = reader.GetDateTime(6).ToString();
            }

            String[] colFields = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3).ToString(), reader.GetString(4), reader.GetString(5), dateModifyTemp, reader.GetInt32(7).ToString() };


            listTasks.Add(colFields);

            index++;
          }

          // Clear the ListView control
          listView1.Items.Clear();
          listView1.Columns.Clear();

          // Set the view to show details.
          listView1.View = View.Details;
          listView1.Columns.Add("ID", 25, HorizontalAlignment.Left);    //Add columns to listview1
          listView1.Columns.Add("Task Name", 75, HorizontalAlignment.Left);
          listView1.Columns.Add("", 0, HorizontalAlignment.Left);
          listView1.Columns.Add("Date Submitted", 75, HorizontalAlignment.Left);
          listView1.Columns.Add("Importance", 65, HorizontalAlignment.Left);
          listView1.Columns.Add("", 0, HorizontalAlignment.Left);
          listView1.Columns.Add("", 0, HorizontalAlignment.Left);
          listView1.Columns.Add("Sprint #", 50, HorizontalAlignment.Left);

          for (int i = 0; i < listTasks.Count; i++)      //Add items into listView box
          {
            var listViewItem = new ListViewItem(listTasks[i]);

            listView1.Items.Add(listViewItem);
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

    private void button3_Click(object sender, EventArgs e)
    {
      ChatForm c = new ChatForm();
      c.Show();
    }

    private void toTaskFormButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      TaskForm t = new TaskForm(currentUser);
      t.Width = this.Width;
      t.Height = this.Height;

      t.StartPosition = FormStartPosition.Manual;
      t.Location = new Point(this.Location.X, this.Location.Y);
      t.Closed += (s, args) => this.Close();
      t.Show();
    }

    private void resetListView2()
    {
      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        //MessageBox.Show("Connection Successful! ");
        try
        {

          DataSet ds = new DataSet();
          string listTasksCmd = "";


          listTasksCmd = "SELECT SuggestionName, Suggestion, Votes, ID FROM [Sandbox]";



          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;


          cmd.CommandText = listTasksCmd;
          var reader = cmd.ExecuteReader();

          // Use list to generate a display for the listbox (to carry info)
          List<string[]> listTasks = new List<string[]>();

          //Iterate through all the values of listed values from query
          int index = 0;
          while (reader.Read())
          {
            String[] colFields = { reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetInt32(3).ToString() };

            listTasks.Add(colFields);
          }

          // Clear the ListView control
          listView2.Items.Clear();
          listView2.Columns.Clear();

          // Set the view to show details.
          listView2.View = View.Details;
          listView2.Columns.Add("Suggestion", 300, HorizontalAlignment.Left);    //Add columns to listview1
          listView2.Columns.Add("", 0, HorizontalAlignment.Left);
          listView2.Columns.Add("Votes", 50, HorizontalAlignment.Left);
          listView2.Columns.Add("", 0, HorizontalAlignment.Left);


          for (int i = 0; i < listTasks.Count; i++)      //Add items into listView box
          {
            var listViewItem = new ListViewItem(listTasks[i]);

            listView2.Items.Add(listViewItem);
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


    private void groupProfileButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      GroupProfileForm groupProfileForm = new GroupProfileForm(currentUser);

      groupProfileForm.Width = this.Width;
      groupProfileForm.Height = this.Height;

      groupProfileForm.StartPosition = FormStartPosition.Manual;
      groupProfileForm.Location = new Point(this.Location.X, this.Location.Y);

      groupProfileForm.Closed += (s, args) => this.Close();
      groupProfileForm.Show();
    }

    private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void urgentTaskButton_MouseClick(object sender, MouseEventArgs e)
    {
      this.Hide();
      TaskForm t = new TaskForm(currentUser);
      t.Width = this.Width;
      t.Height = this.Height;

      t.StartPosition = FormStartPosition.Manual;
      t.Location = new Point(this.Location.X, this.Location.Y);
      t.Closed += (s, args) => this.Close();
      t.Show();
    }

    private void suggestionTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      //Get the value of the listview
      if (listView2.SelectedItems.Count > 0)  //Make sure we do not crash as the count cannot be <= 0 aka null
      {
        ListViewItem item = listView2.SelectedItems[0];
        listView2SelectedID = Int32.Parse(item.SubItems[3].Text); //Get suggestion id (not seeable to user)
        listView2SelectedName = item.SubItems[0].Text;

        suggestionTxtBox.Text = item.SubItems[1].Text;
        deleteSuggestionButton.Enabled = true;
        upvoteButton.Enabled = true;
        downvoteButton.Enabled = true;
      }
      else
      {
        deleteSuggestionButton.Enabled = false;
        upvoteButton.Enabled = false;
        downvoteButton.Enabled = false;
      }

      }

    private void cancelCreationButton_Click(object sender, EventArgs e)
    {
      createSuggestionPanel.Hide();
      suggestionNameTextBox.Text = "";
      createSuggestionDescTextBox.Text = "";
    }

    private void createSuggestionPanel_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tabPage1SandBox_Click(object sender, EventArgs e)
    {

    }

    private void createSuggestionButton_Click_1(object sender, EventArgs e)
    {
      createSuggestionPanel.Visible = true;
    }

    private void deleteSuggestionButton_Click(object sender, EventArgs e)
    {
      confirmDeletePanel.Visible = true;
      createSuggestionButton.Enabled = false;
      upvoteButton.Enabled = false;
      downvoteButton.Enabled = false;
      listView2.Enabled = false;
      deleteSuggestionButton.Enabled = false;
    }

    private void acceptSuggestionButton_Click(object sender, EventArgs e)
    {
      createSuggestionPanel.Hide();

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

          SqlCommand cmd = new SqlCommand("INSERT INTO [Sandbox] ([SuggestionName] ,[Suggestion], [Votes]) VALUES (@name, @desc, @votes)");
          cmd.Connection = db;

          cmd.Parameters.AddWithValue("@name", suggestionNameTextBox.Text);
          cmd.Parameters.AddWithValue("@desc", createSuggestionDescTextBox.Text);
          cmd.Parameters.AddWithValue("@votes", 0);
          cmd.ExecuteNonQuery();

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

      resetListView2();
    }

    private void yesButton_Click(object sender, EventArgs e)
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

          SqlCommand cmd = new SqlCommand("DELETE FROM Sandbox WHERE ID = @id");
          cmd.Connection = db;

          cmd.Parameters.AddWithValue("@id", listView2SelectedID);

          cmd.ExecuteNonQuery();

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



      confirmDeletePanel.Visible = false;
      createSuggestionButton.Enabled = true;
      upvoteButton.Enabled = true;
      downvoteButton.Enabled = true;
      listView2.Enabled = true;
      deleteSuggestionButton.Enabled = true;

      resetListView2();
    }

    private void noButton_Click(object sender, EventArgs e)
    {
      confirmDeletePanel.Visible = false;
      createSuggestionButton.Enabled = true;
      upvoteButton.Enabled = true;
      downvoteButton.Enabled = true;
      listView2.Enabled = true;
      deleteSuggestionButton.Enabled = true;
    }

    private void upvoteButton_Click(object sender, EventArgs e)
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
          SqlCommand checkIfVoted = new SqlCommand("Select Username FROM SandboxVote Where [Voted] = 1 AND SuggestionName = @suggestionname");
          checkIfVoted.Connection = db;
          checkIfVoted.Parameters.AddWithValue("@username", currentUser);
          checkIfVoted.Parameters.AddWithValue("@suggestionname", listView2SelectedName);
          object didVote = checkIfVoted.ExecuteScalar();

          string result = Convert.ToString(didVote);

          if (!result.Equals(""))
          {
            MessageBox.Show("You upvoted already!");
          }
          else
          {
            SqlCommand checkIfVotedNo = new SqlCommand("Select Voted FROM SandboxVote Where Username = @username");
            checkIfVotedNo.Connection = db;
            checkIfVotedNo.Parameters.AddWithValue("@username", currentUser);
            object didVoteNo = checkIfVotedNo.ExecuteScalar();
            string result2 = Convert.ToString(didVoteNo);
            if (result2.Equals("-1")) //You voted no, but changed your mind
            {
              SqlCommand cmd = new SqlCommand("UPDATE [Sandbox] SET [Votes] = (Votes + 2) WHERE ID = @id");
              cmd.Connection = db;
              cmd.Parameters.AddWithValue("@id", listView2SelectedID);
              cmd.ExecuteNonQuery();

              SqlCommand insertSandboxVote = new SqlCommand("UPDATE [SandboxVote] SET [Voted] = (Voted * -1) WHERE Username = @Username");
              insertSandboxVote.Connection = db;
              insertSandboxVote.Parameters.AddWithValue("@username", currentUser);
              insertSandboxVote.ExecuteNonQuery();
            }
            else
            {
              SqlCommand cmd = new SqlCommand("UPDATE [Sandbox] SET [Votes] = (Votes + 1) WHERE ID = @id");
              cmd.Connection = db;
              cmd.Parameters.AddWithValue("@id", listView2SelectedID);
              cmd.ExecuteNonQuery();

              SqlCommand insertSandboxVote = new SqlCommand("INSERT INTO [SandboxVote] ([Username] ,[SuggestionName], [Voted]) VALUES (@username,@suggestionname,@voted)");
              insertSandboxVote.Connection = db;
              insertSandboxVote.Parameters.AddWithValue("@suggestionname", listView2SelectedName);
              insertSandboxVote.Parameters.AddWithValue("@username", currentUser);
              insertSandboxVote.Parameters.AddWithValue("@voted", 1);
              insertSandboxVote.ExecuteNonQuery();
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
        MessageBox.Show(ex.Message);
      }

      resetListView2();
    }

    private void downvoteButton_Click(object sender, EventArgs e)
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
          SqlCommand checkIfVoted = new SqlCommand("Select Username FROM SandboxVote Where [Voted] = -1 AND SuggestionName = @suggestionname");
          checkIfVoted.Connection = db;
          checkIfVoted.Parameters.AddWithValue("@username", currentUser);
          checkIfVoted.Parameters.AddWithValue("@suggestionname", listView2SelectedName);
          object didVote = checkIfVoted.ExecuteScalar();

          string result = Convert.ToString(didVote);

          if (!result.Equals(""))
          {
            MessageBox.Show("You downvoted already!");
          }
          else
          {
            SqlCommand checkIfVotedNo = new SqlCommand("Select Voted FROM SandboxVote Where Username = @username");
            checkIfVotedNo.Connection = db;
            checkIfVotedNo.Parameters.AddWithValue("@username", currentUser);
            object didVoteNo = checkIfVotedNo.ExecuteScalar();
            string result2 = Convert.ToString(didVoteNo);
            if (result2.Equals("1")) //You voted yes, but changed your mind
            {
              SqlCommand cmd = new SqlCommand("UPDATE [Sandbox] SET [Votes] = (Votes - 2) WHERE ID = @id");
              cmd.Connection = db;
              cmd.Parameters.AddWithValue("@id", listView2SelectedID);
              cmd.ExecuteNonQuery();

              SqlCommand insertSandboxVote = new SqlCommand("UPDATE [SandboxVote] SET [Voted] = (Voted * -1) WHERE Username = @Username");
              insertSandboxVote.Connection = db;
              insertSandboxVote.Parameters.AddWithValue("@username", currentUser);
              insertSandboxVote.ExecuteNonQuery();
            }
            else
            {
              SqlCommand cmd = new SqlCommand("UPDATE [Sandbox] SET [Votes] = (Votes - 1) WHERE ID = @id");
              cmd.Connection = db;
              cmd.Parameters.AddWithValue("@id", listView2SelectedID);
              cmd.ExecuteNonQuery();

              SqlCommand insertSandboxVote = new SqlCommand("INSERT INTO [SandboxVote] ([Username] ,[SuggestionName], [Voted]) VALUES (@username,@suggestionname,@voted)");
              insertSandboxVote.Connection = db;
              insertSandboxVote.Parameters.AddWithValue("@suggestionname", listView2SelectedName);
              insertSandboxVote.Parameters.AddWithValue("@username", currentUser);
              insertSandboxVote.Parameters.AddWithValue("@voted", -1);
              insertSandboxVote.ExecuteNonQuery();
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
        MessageBox.Show(ex.Message);
      }

      resetListView2();
    }


  } //End of class
}
