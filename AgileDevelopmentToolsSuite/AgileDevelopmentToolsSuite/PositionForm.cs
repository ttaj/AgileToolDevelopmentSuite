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
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();

            if(positionBox.SelectedItem.Equals("Developer"))
            {
                DeveloperForm developerForm = new DeveloperForm();
                developerForm.Show();
            }
            else
            {
                ProjectMangerForm projectMangerForm = new ProjectMangerForm();
                projectMangerForm.Show();
            }
        }
    }
}
