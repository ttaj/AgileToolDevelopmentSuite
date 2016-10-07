using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgileDevelopmentToolsSuite
{
    public partial class ProjectMangerForm : Form
    {
        public ProjectMangerForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (yesProfileButton.Checked == true)
            {
                SkillSetForm skillSetForm = new SkillSetForm();
                skillSetForm.Width = this.Width;
                skillSetForm.Height = this.Height;

                skillSetForm.StartPosition = FormStartPosition.Manual;
                skillSetForm.Location = new Point(this.Location.X, this.Location.Y);

                this.Hide();
                skillSetForm.Show();
            }
            else
            {

            }
        }

        private void ProjectMangerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("bye projectManager form");
            Application.Exit();
        }
    }
}
