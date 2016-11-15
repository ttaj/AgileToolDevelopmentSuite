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
	public partial class HostForm : Form
	{
		public HostForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string portStr = textBox1.Text;
			int port;
			if (portStr.Length == 0 || int.TryParse(portStr, out port) == false)
			{
				MessageBox.Show("ERR: Please check if the port is correct.");
				return;
			}

			this.Hide();
			ChatForm chatForm = new ChatForm(port);
			chatForm.Show();
		}

		private void HostForm_Load(object sender, EventArgs e)
		{

		}
	}
}
