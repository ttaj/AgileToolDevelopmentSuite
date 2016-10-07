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

                developerForm.Width = this.Width;
                developerForm.Height = this.Height;

                developerForm.StartPosition = FormStartPosition.Manual;
                developerForm.Location = new Point(this.Location.X, this.Location.Y);

                this.Hide();
                developerForm.Show();
            }
            else
            {
                ProjectMangerForm projectMangerForm = new ProjectMangerForm();

                projectMangerForm.Width = this.Width;
                projectMangerForm.Height = this.Height;

                projectMangerForm.StartPosition = FormStartPosition.Manual;
                projectMangerForm.Location = new Point(this.Location.X, this.Location.Y);

                projectMangerForm.Show();
                this.Hide();

            }
        }

        private void PositionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("bye position form");
            Application.Exit();
        }
    }
}
