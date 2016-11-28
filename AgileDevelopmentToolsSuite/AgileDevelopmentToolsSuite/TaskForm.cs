using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace AgileDevelopmentToolsSuite
{
    public partial class TaskForm : Form
  {
    static int selectedItem = 0; //Global variable
    static string importance = "To-Do"; //Global variable
    static int sortBy = 0; //Global variable, 0 = date issued, 1 = importance, 2 = taskname, 3 = ID, 4 = Date modified, 5 = User Assigned

    int selectedSprint = 0;
    int tempSelectedIndex = 0;
    int numberOfSprints = 0;
    string currentUser = "";

    public TaskForm()
    {
      InitializeComponent();


      listView1.FullRowSelect = true;
      curTasksSaveButton.BackColor = System.Drawing.Color.Gray;
      curTasksSaveButton.Enabled = false;
      sortByUpOrDown.Text = "↓";
      this.curTasksComboBox.SelectedIndex = 0;
    }

    public TaskForm(string curUser)
    {
      InitializeComponent();


      listView1.FullRowSelect = true;
      curTasksSaveButton.BackColor = System.Drawing.Color.Gray;
      curTasksSaveButton.Enabled = false;
      sortByUpOrDown.Text = "↓";
      this.curTasksComboBox.SelectedIndex = 0;
      currentUser = curUser;
    }


    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void curTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void rightArrow_Click(object sender, EventArgs e)
    {

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      curTasksSaveButton.BackColor = System.Drawing.Color.Yellow;
    }

    private void curTasksSortLabel_Click(object sender, EventArgs e)
    {

    }

    private void curTasksLabel_Click(object sender, EventArgs e)
    {

    }

    private void curTasksRadio1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void curTasksRadio2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void curTasksRadio3_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void backButton_Click(object sender, EventArgs e)
    {
      MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
      mainMenuForm.Width = this.Width;
      mainMenuForm.Height = this.Height;

      mainMenuForm.StartPosition = FormStartPosition.Manual;
      mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

      this.Hide();
      mainMenuForm.Show();
    }

    private void curTasksComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      selectedSprint = curTasksComboBox.SelectedIndex;
      testLabel.Text = curTasksComboBox.Text;
      resetListView();
    }

    private void curTasksSaveButton_Click(object sender, EventArgs e)
    {
        curTasksSaveButton.BackColor = System.Drawing.Color.LimeGreen;

        if (curTasksRadio1.Checked)  //URGENT CHECKED
        {
            importance = "Urgent";
        }
        else if (curTasksRadio2.Checked) //TODO
        {
            importance = "To-Do";
        }
        else   //COMPLETED
        {
            importance = "Completed";
        }

        SqlConnection db;
        String version = "MSSQLLocalDB";
        String fileName = "ADTSDInfo.mdf";
        String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

        db = new SqlConnection(connectionString);
        try
        {
            db.Open();
            MessageBox.Show("Changes successfully saved!");
            try
            {

                DataSet ds = new DataSet();
                string saveChanges = @"UPDATE [Tasks] SET 
                        [Importance] =  @importance, 
                        [DateModified] = @datemodified,
                        [TaskDescription] = @taskdescription,
                        [ProjectGroup] = @projectgroup
                        WHERE ID = @selectedItem";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = saveChanges;


                cmd.Parameters.AddWithValue("@importance", importance);
                cmd.Parameters.AddWithValue("@datemodified", DateTime.Now);
                cmd.Parameters.AddWithValue("@taskdescription", curTaskDescriptions.Text);
                cmd.Parameters.AddWithValue("@selectedItem", selectedItem);
                cmd.Parameters.AddWithValue("@projectgroup", setSprintNumBox.Value);
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

        resetListView();
    }

    private void TaskForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'aDTSDLoginInfoDataSet.Tasks' table. You can move, or remove it, as needed.
      //this.tasksTableAdapter.Fill(this.aDTSDLoginInfoDataSet.Tasks);

      /*  //PictureLoader from URL
      var request = WebRequest.Create("");

      using (var response = request.GetResponse())
      using (var stream = response.GetResponseStream())
      {
        pictureBox1.Image = Bitmap.FromStream(stream);
      }
      */


    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        curTaskDescriptions.Enabled = true;
        //Get the value of the listview
        if (listView1.SelectedItems.Count > 0)  //Make sure we do not crash as the count cannot be <= 0 aka null
        {
            curTasksSaveButton.Enabled = true;
            ListViewItem item = listView1.SelectedItems[0];
            //MessageBox.Show(item.SubItems[4].ToString());
            curTaskDescriptions.Text = item.SubItems[5].Text; //Get task descriptions

            selectedIDLbl.Text = "Selected FORM ID: " + item.SubItems[0].Text;
            curTasksSaveButton.Text = "Save Changes to: " + item.SubItems[0].Text;
            selectedItem = Int32.Parse(item.SubItems[0].Text);
            importance = item.SubItems[4].Text;



            if (item.SubItems[4].Text == "Urgent")  //Listview to modify the radio buttons.
            {
                curTasksRadio1.PerformClick();
            }
            else if (item.SubItems[4].Text == "To-Do") //TODO
            {
                curTasksRadio2.PerformClick();
            }
            else
            {
                curTasksRadio3.PerformClick();  //COMPLETED
            }

        }
        else
        {
            curTasksSaveButton.Enabled = false;
            return;
        }

    }

    private void createTaskButton_Click(object sender, EventArgs e)
    {
      CreateTaskForm c = new CreateTaskForm();
      c.StartPosition = FormStartPosition.Manual;
      c.ShowDialog();
      resetListView();
    }

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
          string getMaxSprintsCmd = "SELECT MAX(ProjectGroup) FROM [Tasks]";

          string additionalWhere = "";

          if (curTasksComboBox.SelectedIndex == 0) //Show all tasks
          {
            //do nothing
          }
          else if (curTasksComboBox.SelectedIndex == 1) //Show all non-sprint related tasks (in db, where value of project group is <= 0
          {
            additionalWhere = " Where ProjectGroup <= @projectGroup";
          }
          else if (curTasksComboBox.SelectedIndex >= 2) //Show sprint #
          {
            additionalWhere = " Where ProjectGroup = @projectGroup";
          }



          if (sortBy == 0) //DateSubmitted
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY DateSubmitted Asc";
          }
          else if (sortBy == 100) //DateSubmitted rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY DateSubmitted Desc";
          }
          else if (sortBy == 1) //Importance
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY Importance Desc";
          }
          else if (sortBy == -1) //Importance rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY Importance Asc";
          }
          else if (sortBy == 2) //TaskName
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY TaskName Asc";
          }
          else if (sortBy == -2) //TaskName rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY TaskName Desc";
          }
          else if (sortBy == 3) //ID
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY ID Asc";
          }
          else if (sortBy == -3) //ID rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY ID Desc";
          }
          else if (sortBy == 4) //Date Modified
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY DateModified Asc";
          }
          else if (sortBy == -4) //Date Modified rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY DateModified Desc";
          }
          else if (sortBy == 5) //User Assigned
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + " ORDER BY UserAssigned Asc";
          }
          else if (sortBy == -5) //User Assigned rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks]" + additionalWhere + "ORDER BY UserAssigned Desc";
          }
          
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;
          cmd.CommandText = listTasksCmd;

          SqlCommand cmd2 = new SqlCommand();
          cmd2.Connection = db;
          cmd2.CommandText = getMaxSprintsCmd;
          int numSprints = (Int32)cmd2.ExecuteScalar();

          numberOfSprints = numSprints;




          curTasksComboBox.Items.Clear();
          curTasksComboBox.Items.Add("(Show All Tasks)");
          curTasksComboBox.Items.Add("(Show Non-Sprints)");

          for (int i = 1; i < numberOfSprints + 1; i++)
          {
            curTasksComboBox.Items.Add(i);
          }

          if (curTasksComboBox.SelectedIndex == 0) //Show all tasks
          {
            //do nothing
          }
          else if (curTasksComboBox.SelectedIndex == 1) //Show all non-sprint related tasks (in db, where value of project group is <= 0
          {
            cmd.Parameters.AddWithValue("@projectGroup", 0);
          }
          else //Show sprint #
          {
            cmd.Parameters.AddWithValue("@projectGroup", selectedSprint-1);
          }
          




          var reader = cmd.ExecuteReader();

          List<string[]> listTasks = new List<string[]>(); // Use list to generate a display for the listbox (to carry info)

          int index = 0;
          while (reader.Read()) //Iterate through all the values of listed values from query
          {
            // Concatenate years with the number of crimes occurence that year by Group By
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
          //listView1.Text = index + " results";
          //listView1.DataSource = listItems;
          //this.curTasksListBox.DataSource = ds.Tables[0];
          //this.curTasksListBox.DisplayMember = "Username";



          // Clear the ListView control
          listView1.Items.Clear();
          listView1.Columns.Clear();

          // Set the view to show details.
          listView1.View = View.Details;
          listView1.Columns.Add("ID", 50, HorizontalAlignment.Left);    //Add columns to listview1
          listView1.Columns.Add("Task Name", 150, HorizontalAlignment.Left);
          listView1.Columns.Add("User Assigned", 150, HorizontalAlignment.Left);
          listView1.Columns.Add("Date Submitted", 150, HorizontalAlignment.Left);
          listView1.Columns.Add("Importance", 80, HorizontalAlignment.Left);
          listView1.Columns.Add("", 0, HorizontalAlignment.Left);
          listView1.Columns.Add("Date Modified", 150, HorizontalAlignment.Left);


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

    private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
    {
      //sortBy: 0 = date issued, 1 = importance, 2 = taskname, 3 = ID, 4 = Date modified, 5 = User Assigned
      if (e.Column == 0)
      {
        //curTasksComboBox.SelectedIndex = 3;
        if (sortBy == -3)
          sortBy = 3;
        else if (sortBy == 3)
          sortBy = -3;
        else
          sortBy = 3;
      }
      else if (e.Column == 1)
      {
        //curTasksComboBox.SelectedIndex = 2;
        if (sortBy == -2)
          sortBy = 2;
        else if (sortBy == 2)
          sortBy = -2;
        else
          sortBy = 2;
      }
      else if (e.Column == 2)
      {
        //curTasksComboBox.SelectedIndex = 5;
        if (sortBy == -5)
          sortBy = 5;
        else if (sortBy == 5)
          sortBy = -5;
        else
          sortBy = 5;
      }
      else if (e.Column == 3)
      {
        //curTasksComboBox.SelectedIndex = 0;
        if (sortBy == 0)
        {
          sortBy = 100;
        }
        else if (sortBy == 100)
        {
          sortBy = 0;
        }
        else
        {
          sortBy = 0;
        }

      }
      else if (e.Column == 4)
      {
        //curTasksComboBox.SelectedIndex = 1;
        if (sortBy == -1)
          sortBy = 1;
        else if (sortBy == 1)
          sortBy = -1;
        else
          sortBy = 1;
      }
      else
      {
        //curTasksComboBox.SelectedIndex = 4;
        if (sortBy == -4)
          sortBy = 4;
        else if (sortBy == 4)
          sortBy = -4;
        else
          sortBy = 4;
      }
      if(sortBy > 0)
      {
        sortByUpOrDown.Text = "↓";
      }
      else
      {
        sortByUpOrDown.Text = "↑";
      }
      resetListView();
    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void curTasksRadio2_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void curTasksRadio3_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void instructionsButton_Click(object sender, EventArgs e)
    {
      curTaskDescriptions.Enabled = false;
      curTasksSaveButton.Text = "Save Changes to: ";
      curTaskDescriptions.Text = "1) Select your desired [Sprint #] category using the dropdown box above.\n" +
                                 "2) Click on the [column tabs] to sort the listing order, click on the same tab again to reverse the order.\n" +
                                 "3) Click any of [the rows of the List] below to select and view and modify its Task Description.\n" +
                                 "4) You may modify the [Current Progress] of the task with the [Urgent, TO-DO, or Completed] radio buttons.\n" +
                                 "5) Click on [Save Changes to: ##] button to save the changes made to that ID. A timestamp will additionally be made to that task on when it was modified." +
                                 "\nNote: No Task shall ever be deleted, thus deleting tasks are not possible. Just mark it as complete when it is done.";
      curTasksSaveButton.Enabled = false;
      curTasksSaveButton.BackColor = System.Drawing.Color.Gray;
    }

    private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
    private void TaskForm_FormClosed(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

        private void createTaskButton_Click_1(object sender, EventArgs e)
        {
            CreateTaskForm c = new CreateTaskForm();
            c.StartPosition = FormStartPosition.Manual;
            c.ShowDialog();
            resetListView();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
            mainMenuForm.Width = this.Width;
            mainMenuForm.Height = this.Height;

            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            mainMenuForm.Show();
        }

        private void instructionsButton_Click_1(object sender, EventArgs e)
        {
            curTaskDescriptions.Enabled = false;
            curTasksSaveButton.Text = "Save Changes to: ";
            curTaskDescriptions.Text = "1) Select your desired [Sprint #] category using the dropdown box above.\n" +
                                       "2) Click on the [column tabs] to sort the listing order, click on the same tab again to reverse the order.\n" +
                                       "3) Click any of [the rows of the List] below to select and view and modify its Task Description.\n" +
                                       "4) You may modify the [Current Progress] of the task with the [Urgent, TO-DO, or Completed] radio buttons.\n" +
                                       "5) Click on [Save Changes to: ##] button to save the changes made to that ID. A timestamp will additionally be made to that task on when it was modified." +
                                       "\nNote: No Task shall ever be deleted, thus deleting tasks are not possible. Just mark it as complete when it is done.";
            curTasksSaveButton.Enabled = false;
            curTasksSaveButton.BackColor = System.Drawing.Color.Gray;
        }

        private void sortByUpOrDown_Click(object sender, EventArgs e)
        {

        }

        private void testLabel_Click(object sender, EventArgs e)
        {

        }

        private void setSprintNumBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
