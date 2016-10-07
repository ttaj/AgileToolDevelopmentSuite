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
    public partial class DeveloperForm : Form
    {
        public DeveloperForm()
        {
            InitializeComponent();
        }

        private void yesProfileButton_CheckedChanged(object sender, EventArgs e)
        {
            profileLinkLabel.Visible = true;
            profileLinkBox.Visible = true;
        }

        private void noProfileButton_CheckedChanged(object sender, EventArgs e)
        {
            profileLinkLabel.Visible = false;
            profileLinkBox.Visible = false;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\natha\Documents\Visual Studio 2015\Projects\AgileDevelopmentToolsSuite\AgileDevelopmentToolsSuite\ADTSDatabase.mdf';Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            String insertLoginQuery = "INSERT INTO @database (@UsernameField, @PasswordField) VALUES (@Username, @Password)";
            SqlCommand command = new SqlCommand(insertLoginQuery, conn);

            command.Parameters.AddWithValue("@database", "dbo.Login");
            command.Parameters.AddWithValue("@UsernameField", "Username");
            command.Parameters.AddWithValue("@PasswordField", "Password");
            command.Parameters.AddWithValue("@Username", usernameBox.Text);
            command.Parameters.AddWithValue("@Password", passwordBox.Text);

            if (yesProfileButton.Checked == true)
            {
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();

                    this.Hide();
                    SkillSetForm skillSetForm = new SkillSetForm();
                    skillSetForm.Show();

                    conn.Close();
                }
                catch
                {
                    
                }
            }
            else
            {

            }
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {

        }

        private void DeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("bye developer Form");
            Application.Exit();
        }
    }
}
