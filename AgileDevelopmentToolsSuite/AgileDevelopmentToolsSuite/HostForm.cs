using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.Connections.TCP;
using System.Net;

namespace AgileDevelopmentToolsSuite
{
	public partial class HostForm : Form
	{
		String curUser;
		public HostForm(String name)
		{
			this.curUser = name;
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

			string IPStr = textBox2.Text;
			IPAddress theAddress;


			try
			{
				theAddress = IPAddress.Parse(IPStr);
			}
			catch (Exception)
			{
				MessageBox.Show("ERR: Please check if the IP is correctly typed.");
				return;
			}
			if (portStr.Length == 0 || int.TryParse(portStr, out port) == false)
			{
				MessageBox.Show("ERR: Please check if the port is correctly typed.");
				return;
			}
			this.Hide();
			ChatForm chatForm = new ChatForm(IPStr, port, curUser);
			chatForm.Show();
		}

		private void HostForm_Load(object sender, EventArgs e)
		{

		}

        private void HostForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
