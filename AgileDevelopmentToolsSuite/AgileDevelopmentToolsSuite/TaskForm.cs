using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AgileDevelopmentToolsSuite
{
  public partial class TaskForm : Form
  {
    static int selectedItem = 0; //Global variable
    static char importance = 'T'; //Global variable
    static int sortBy = 0; //Global variable, 0 = date issued, 1 = importance, 2 = taskname, 3 = ID, 4 = Date modified, 5 = User Assigned

    public TaskForm()
    {
      InitializeComponent();
    

      listView1.FullRowSelect = true;
      curTasksSaveButton.BackColor = System.Drawing.Color.Gray;
      curTasksSaveButton.Enabled = false;

      this.curTasksComboBox.SelectedIndex = 0;
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
      this.Hide();
      MainMenuForm menuForm = new MainMenuForm();
      menuForm.Show();
      
    }

    private void curTasksComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      sortBy = curTasksComboBox.SelectedIndex;

      resetListView();

    }

    private void curTasksSaveButton_Click(object sender, EventArgs e)
    {
      curTasksSaveButton.BackColor = System.Drawing.Color.LimeGreen;

      if(curTasksRadio1.Checked)  //URGENT CHECKED
      {
        importance = 'U';
      }
      else if(curTasksRadio2.Checked) //TODO
      {
        importance = 'T';
      }
      else   //COMPLETED
      {
        importance = 'C';
      }

      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDLoginInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        MessageBox.Show("Changes successfully saved!");
        try
        {

          DataSet ds = new DataSet();

          string saveChanges = @"UPDATE [Tasks] SET 
                            Importance = '" + importance + @"', 
                            DateModified = '"+ DateTime.Now +@"',
                            TaskDescription = '" + curTaskDescriptions.Text + @"'
                            WHERE ID = " + selectedItem + "";

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;

          cmd.CommandText = saveChanges;
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
      this.tasksTableAdapter.Fill(this.aDTSDLoginInfoDataSet.Tasks);

      



    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

      //Get the value of the listview
      if(listView1.SelectedItems.Count > 0 )  //Make sure we do not crash as the count cannot be <= 0 aka null
      {
        curTasksSaveButton.Enabled = true;
        ListViewItem item = listView1.SelectedItems[0];
        //MessageBox.Show(item.SubItems[4].ToString());
        curTaskDescriptions.Text = item.SubItems[5].Text; //Get task descriptions

        selectedIDLbl.Text = "Selected FORM ID: " + item.SubItems[0].Text;
        curTasksSaveButton.Text = "Save Changes to: " + item.SubItems[0].Text;
        selectedItem = Int32.Parse(item.SubItems[0].Text);
        importance = Char.Parse(item.SubItems[4].Text);



        if (item.SubItems[4].Text == "U")  //Listview to modify the radio buttons.
        {
          curTasksRadio1.PerformClick();
        }
        else if(item.SubItems[4].Text == "T") //TODO
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
      
      /*
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
          string listTasksCmd = "SELECT TaskName, TaskDescription FROM [Tasks] WHERE TaskName = '" + listView1.SelectedItems[0].SubItems[1].Text + "'";

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;

          cmd.CommandText = listTasksCmd;
          var reader = cmd.ExecuteReader();

          List<string[]> listTasks = new List<string[]>(); // Use list to generate a display for the listbox (to carry info)

          int index = 0;
          while (reader.Read()) //Iterate through all the values of listed values from query
          {
            // Concatenate years with the number of crimes occurence that year by Group By
            //Math round(number, # of decimals)

            curTaskDescriptions.Text = reader.GetString(2);
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
    
    */

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

          if(sortBy == 0) //DateSubmitted
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY DateSubmitted Asc";
          }
          else if(sortBy == 100) //DateSubmitted rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY DateSubmitted Desc";
          }
          else if(sortBy == 1) //Importance
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY Importance Desc";
          }
          else if (sortBy == -1) //Importance rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY Importance Asc";
          }
          else if(sortBy == 2) //TaskName
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY TaskName Asc";
          }
          else if (sortBy == -2) //TaskName rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY TaskName Desc";
          }
          else if(sortBy == 3) //ID
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY ID Asc";
          }
          else if (sortBy == -3) //ID rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY ID Desc";
          }
          else if(sortBy == 4) //Date Modified
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY DateModified Asc";
          }
          else if (sortBy == -4) //Date Modified rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY DateModified Desc";
          }
          else if(sortBy == 5) //User Assigned
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY UserAssigned Asc";
          }
          else if (sortBy == -5) //User Assigned rev
          {
            listTasksCmd = "SELECT ID, TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription, DateModified FROM [Tasks] ORDER BY UserAssigned Desc";
          }

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = db;


          cmd.CommandText = listTasksCmd;
          var reader = cmd.ExecuteReader();

          List<string[]> listTasks = new List<string[]>(); // Use list to generate a display for the listbox (to carry info)

          int index = 0;
          while (reader.Read()) //Iterate through all the values of listed values from query
          {
            // Concatenate years with the number of crimes occurence that year by Group By
            //Math round(number, # of decimals)
            String dateModifyTemp;
            if(reader.IsDBNull(6))
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

    int toggle = -1;
    private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
    {
      //sortBy: 0 = date issued, 1 = importance, 2 = taskname, 3 = ID, 4 = Date modified, 5 = User Assigned
      if (e.Column == 0) 
      {
        curTasksComboBox.SelectedIndex = 3;
        if (sortBy == -3)
          sortBy = 3;
        else if (sortBy == 3)
          sortBy = -3;
      }
      else if(e.Column == 1)
      {
        curTasksComboBox.SelectedIndex = 2;
        if (sortBy == -2)
          sortBy = 2;
        else if (sortBy == 2)
          sortBy = -2;
      }
      else if (e.Column == 2)
      {
        curTasksComboBox.SelectedIndex = 5;
        if (sortBy == -5)
          sortBy = 5;
        else if (sortBy == 5)
          sortBy = -5;
      }
      else if (e.Column == 3)
      {
        curTasksComboBox.SelectedIndex = 0;
        if(sortBy == 0)
        {
          sortBy = 100;
        }
        else if(sortBy == 100)
        {
          sortBy = 0;
        }
        
      }
      else if (e.Column == 4)
      {
        curTasksComboBox.SelectedIndex = 1;
        if (sortBy == -1)
          sortBy = 1;
        else if (sortBy == 1)
          sortBy = -1;
      }
      else
      {
        curTasksComboBox.SelectedIndex = 4;
        if (sortBy == -4)
          sortBy = 4;
        else if (sortBy == 4)
          sortBy = -4;
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
      curTaskDescriptions.Text = "1) Click on the [Sort By: Combobox] to select sorting order (or click on column tabs).\n" +
                                 "2) Click any of [the rows of the List] below to select and view and modify its Task Description.\n" +
                                 "3) You may modify the [Current Progress] of the task with the [Urgent, TO-DO, or Completed] radio buttons.\n" +
                                 "4) Click on [Save Changes to: ##] to save the changes made to that ID. A timestamp will additionally be made to that task on when it was modified."+
                                 "\nNote: No Task shall ever be deleted, thus deleting tasks are not possible. Just mark it as complete when it is done.";
      curTasksSaveButton.Enabled = false;
      curTasksSaveButton.BackColor = System.Drawing.Color.Gray;
    }     
  }
}
