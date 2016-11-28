using System;
using System.Drawing;
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

      //check if user registering for developer position or project manager
      if (positionBox.SelectedItem.Equals("Developer"))
      {
        this.Hide();
        DeveloperForm developerForm = new DeveloperForm();
        developerForm.Width = this.Width;
        developerForm.Height = this.Height;

        developerForm.StartPosition = FormStartPosition.Manual;
        developerForm.Location = new Point(this.Location.X, this.Location.Y);

        developerForm.Closed += (s, args) => this.Close();
        developerForm.Show();
      }
      else
      {
        this.Hide();
        ProjectMangerForm projectMangerForm = new ProjectMangerForm();
        projectMangerForm.Width = this.Width;
        projectMangerForm.Height = this.Height;

        projectMangerForm.StartPosition = FormStartPosition.Manual;
        projectMangerForm.Location = new Point(this.Location.X, this.Location.Y);

        projectMangerForm.Closed += (s, args) => this.Close();
        projectMangerForm.Show();
      }
    }

    private void PositionForm_Load(object sender, EventArgs e)
    {

    }
  }
}
