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
            //must find a way to get authentication from a current project manager and 

            if (yesProfileButton.Checked == true)
            {
                //add creation query
                //add form to enter on register creation
            }
            else
            {
                SkillSetForm skillSetForm = new SkillSetForm();
                skillSetForm.Width = this.Width;
                skillSetForm.Height = this.Height;

                skillSetForm.StartPosition = FormStartPosition.Manual;
                skillSetForm.Location = new Point(this.Location.X, this.Location.Y);

                this.Hide();
                skillSetForm.Show();
            }
        }
    }
}
