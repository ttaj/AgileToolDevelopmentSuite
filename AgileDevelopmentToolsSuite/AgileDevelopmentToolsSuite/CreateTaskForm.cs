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

using AgileDevelopmentToolsSuite;

namespace AgileDevelopmentToolsSuite
{
  public partial class CreateTaskForm : Form
  {
    public CreateTaskForm()
    {
      InitializeComponent();

    }

    private void CreateTaskForm_Load(object sender, EventArgs e)
    {

    }

    private void taskNameTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    string importance = "To-Do";
    String userName = "[Not specified]";

    private void submitButton_Click(object sender, EventArgs e)
    {
      var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);


      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        MessageBox.Show("Task uploaded database! ");
        try
        {
          SqlCommand cmd = new SqlCommand("INSERT INTO [Tasks] ([TaskName] ,[UserAssigned], [DateSubmitted], [Importance], [TaskDescription], [ProjectGroup]) VALUES (@TaskName, @UserAssigned, @DateSubmitted, @Importance, @TaskDescription, @ProjectGroup)");
          cmd.Connection = db;
          cmd.Parameters.AddWithValue("@TaskName", taskNameTxtBox.Text);
          if(userDesigTxtBox.Text != "")
          cmd.Parameters.AddWithValue("@UserAssigned", userDesigTxtBox.Text);
          else
            cmd.Parameters.AddWithValue("@UserAssigned", userName);
          cmd.Parameters.AddWithValue("@Importance", importance);
          cmd.Parameters.AddWithValue("@DateSubmitted", DateTime.Now);
          cmd.Parameters.AddWithValue("@TaskDescription", taskDescTxtBox.Text);
          if (userDesigTxtBox.Text != "")
            cmd.Parameters.AddWithValue("@ProjectGroup", projectGroupTxt.Text);
          else
            cmd.Parameters.AddWithValue("@ProjectGroup", "[No Group]");
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
        MessageBox.Show("Connection unsuccessful, please try again. ");
        return;
      }

      this.Close();
    }

    private void curTasksRadioGroup_Enter(object sender, EventArgs e)
    {
      
    }

    private void curTasksRadio1_CheckedChanged(object sender, EventArgs e)
    {
      importance = "Urgent";
    }

    private void curTasksRadio2_CheckedChanged(object sender, EventArgs e)
    {
      importance = "To-Do";
    }

    private void curTasksRadio3_CheckedChanged(object sender, EventArgs e)
    {
      importance = "Completed";
    }

    private void taskDescTxtBox_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
