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
    public MainMenuForm()
    {
      InitializeComponent();
    }

    string numUrgentTasks = "";

    private void MainMenuForm_Load(object sender, EventArgs e)
    {
      panel1.Hide();
      resetListView();

      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDLoginInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        try
        {

          DataSet ds = new DataSet();

          string saveChanges = @"SELECT COUNT(Importance) FROM [Tasks] Where Importance = 'U'";

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

      

      if(numUrgentTasks != "0")
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
        ProfileForm profileForm = new ProfileForm();

        profileForm.Width = this.Width;
        profileForm.Height = this.Height;

        profileForm.StartPosition = FormStartPosition.Manual;
        profileForm.Location = new Point(this.Location.X, this.Location.Y);

        this.Hide();
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

    }

    int sortBy = 0;
    public void resetListView()   //Reset ListView, sortstyle is for the type of sorting, 0 = date issued, 1 = importance, 2 = taskname, 3 = ID, 4 = Date modified, 5 = User Assigned
    {
      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDLoginInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        //MessageBox.Show("Connection Successful! ");
        try
        {

          DataSet ds = new DataSet();
          string listTasksCmd = "";

      
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY Importance Desc";
          
          

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

            String[] colFields = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3).ToString(), reader.GetString(4), reader.GetString(5), dateModifyTemp };


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
      TaskForm t = new TaskForm();
      this.Visible = false;
      t.ShowDialog();
      this.Visible = true;
    }

    private void groupProfileButton_Click(object sender, EventArgs e)
    {
        GroupProfileForm groupProfileForm = new GroupProfileForm();

        groupProfileForm.Width = this.Width;
        groupProfileForm.Height = this.Height;

        groupProfileForm.StartPosition = FormStartPosition.Manual;
        groupProfileForm.Location = new Point(this.Location.X, this.Location.Y);

        this.Hide();
        groupProfileForm.Show();
    }

    private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    }
}
