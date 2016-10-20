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
    public TaskForm()
    {
      InitializeComponent();
      resetListView();


      this.curTasksComboBox.SelectedIndex = 1;
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
      
    }

    private void curTasksSaveButton_Click(object sender, EventArgs e)
    {
      resetListView();
    }

    private void TaskForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'aDTSDLoginInfoDataSet.Tasks' table. You can move, or remove it, as needed.
      this.tasksTableAdapter.Fill(this.aDTSDLoginInfoDataSet.Tasks);

      

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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
    
    

  }

  private void createTaskButton_Click(object sender, EventArgs e)
    {
      CreateTaskForm c = new CreateTaskForm();
      c.StartPosition = FormStartPosition.Manual;
      c.ShowDialog();
    }

    public void resetListView()
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
          string listTasksCmd = "SELECT TaskName, UserAssigned, DateSubmitted, Importance, TaskDescription FROM [Tasks] ORDER BY DateSubmitted";

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
            String[] colFields = { reader.GetString(0), reader.GetString(1), reader.GetDateTime(2).ToString(), reader.GetString(3), reader.GetString(4) };


            listTasks.Add(colFields);

            index++;
          }
          //listView1.Text = index + " results";
          //listView1.DataSource = listItems;
          //this.curTasksListBox.DataSource = ds.Tables[0];
          //this.curTasksListBox.DisplayMember = "Username";



          // Clear the ListView control
          listView1.Items.Clear();


          // Set the view to show details.
          listView1.View = View.Details;
          listView1.Columns.Add("Task Name", 90, HorizontalAlignment.Left);           //Add columns
          listView1.Columns.Add("User Assigned", 90, HorizontalAlignment.Left);
          listView1.Columns.Add("Date Submitted", 90, HorizontalAlignment.Left);
          listView1.Columns.Add("Importance", 80, HorizontalAlignment.Left);

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


  }
}
