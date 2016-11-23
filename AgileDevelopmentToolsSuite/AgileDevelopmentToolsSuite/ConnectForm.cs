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
	public partial class ConnectForm : Form
	{
		public ConnectForm()
		{
			InitializeComponent();
		}

		private void ConnectForm_Load(object sender, EventArgs e)
		{
				}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string IPStr = textBox1.Text;
			string portStr = textBox2.Text;
			IPAddress theAddress;
			int port;

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
			ConnectionInfo connInfo = new ConnectionInfo(IPStr, port);
			Connection newTCPConn;

			try
			{
				newTCPConn = TCPConnection.GetConnection(connInfo);

			}
			catch (Exception q)
			{
				MessageBox.Show("ERR: " + q.Message);
				return;
			}
			this.Hide();

			ChatForm chatForm = new ChatForm(newTCPConn);
			chatForm.Show();
		}
	}
}
