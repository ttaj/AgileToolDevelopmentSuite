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
                this.Hide();
                SkillSetForm skillSetForm = new SkillSetForm();
                skillSetForm.Show();
            }
            else
            {

            }
        }
    }
}
