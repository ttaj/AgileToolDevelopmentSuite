using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.Connections.TCP;
using ProtoBuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
	public partial class ChatForm : Form
	{
		private int port;
		private string ip;
		private bool isHost = false;
		private string name;
		private Connection newTCPConn;
		ArrayList clientList;
		clientInfoServ host;
		clientInfo chost;
		clientInfo cinfo;

		public ChatForm()
		{
			InitializeComponent();
			clientList = new ArrayList();
		}

		//server
		public ChatForm(int port)
		{
			clientList = new ArrayList();
			InitializeComponent();

			this.port = port;
			this.ip = "192.168.1.123";
			isHost = true;

			// [ttaj] Setup the server, if the object being sent is a string then run the function PrintIncMsg
			NetworkComms.AppendGlobalIncomingPacketHandler<clientInfo>("ClientInfo", addClient);
			NetworkComms.AppendGlobalIncomingPacketHandler<messageHolder>("Message", addMessage);

			// [ttaj] Start the server.
			TCPConnection.StartListening(ConnectionType.TCP, new System.Net.IPEndPoint(IPAddress.Parse(ip), port));
			host = new clientInfoServ("Host", null, "H");
			chost = new clientInfo("Host", "H");
			ChatLog.Items.Add("Server successfully started!");

			clientList.Add(host);
			Users.Items.Add(host.name);
			Rank.Items.Add(host.rank);

		}

		private void addMessage(PacketHeader packetHeader, Connection connection, messageHolder incomingObject)
		{

			ChatLog.Invoke(new MethodInvoker(delegate ()
			{
				ChatLog.Items.Add(incomingObject.message);
			}));

			foreach (clientInfoServ cinfo in clientList)
			{
				Connection conn = cinfo.conn;
				if (conn == null || conn.Equals(conn)) continue;
				conn.SendObject("Message", incomingObject);
			}
		}

		public void addUser(clientInfoServ user)
		{
			clientList.Add(user);

			Users.Invoke(new MethodInvoker(delegate ()
			{
				Users.Items.Add(user.name);
			}));

			Rank.Invoke(new MethodInvoker(delegate ()
			{
				Rank.Items.Add(user.rank);
			}));


			NotifyServer(user.conn, user.name + " has connected.");
		}

		[ProtoContract]
		public class messageHolder
		{
			[ProtoMember(1)]
			public string message { get; private set; }

			protected messageHolder() { }
			public messageHolder(string message)
			{
				this.message = message;
			}
		}

		private void NotifyServer(Connection conn, string v)
		{
			ChatLog.Invoke(new MethodInvoker(delegate ()
			{
				ChatLog.Items.Add(v);
			}));
			messageHolder toSend = new messageHolder(v);

			foreach(clientInfoServ cinfo in clientList)
			{
				Connection connection = cinfo.conn;
				if (connection == null || connection.Equals(conn)) continue;
				connection.SendObject("Message", toSend);
			}
		}

		private void addClient(PacketHeader packetHeader, Connection connection, clientInfo incomingObject)
		{
			clientInfoServ toAdd = new clientInfoServ(incomingObject.name, connection);
			//MessageBox.Show("Name: " + incomingObject.name);
			addUser(toAdd);
			try
			{
				TCPConnection.GetConnection(connection.ConnectionInfo).SendObject("ClientInfo", chost);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}		
		}

		[ProtoContract]
		public class clientInfo
		{
			[ProtoMember(1)]
			public String name { get; private set; }
			[ProtoMember(2)]
			public String rank { get; private set; } //g stands for guest.
			protected clientInfo() { }
			public clientInfo(String name)
			{
				this.name = name; // todo: set name to sql name and not ip
				this.rank = "G";
			}
			public clientInfo(String name, String rank)
			{
				this.name = name; // todo: set name to sql name and not ip
				this.rank = rank;
			}
		}

		[ProtoContract]
		public class clientInfoServ
		{
			[ProtoMember(1)]
			public String name { get; private set; }
			[ProtoMember(2)]
			public String rank { get; private set; }  //g stands for guest.
			[ProtoMember(3)]
			public Connection conn { get; private set; }

			// needed for proto
			protected clientInfoServ() { }
			public clientInfoServ(String name, Connection conn)
			{
				this.name = name; // todo: set name to sql name and not ip
				this.conn = conn;
				this.rank = "G";
			}

			public clientInfoServ(String name, Connection conn, String rank)
			{
				this.name = name; // todo: set name to sql name and not ip
				this.conn = conn;
				this.rank = rank;
			}
		}

		private void c_addClient(PacketHeader packetHeader, Connection connection, clientInfo incomingObject)
		{
			foreach (clientInfoServ cinfo in clientList)
			{
				Connection conn = cinfo.conn;
				if (connection == null || connection.Equals(conn)) continue;
				connection.SendObject("Message", incomingObject);
			}

			Rank.Invoke(new MethodInvoker(delegate ()
			{
				Rank.Items.Add(incomingObject.rank);
			}));

			Users.Invoke(new MethodInvoker(delegate ()
			{
				Users.Items.Add(incomingObject.name);
			}));

		}

		// client
		public ChatForm(Connection newTCPConn)
		{
			NetworkComms.AppendGlobalIncomingPacketHandler<messageHolder>("Message", addMessage);
			NetworkComms.AppendGlobalIncomingPacketHandler<clientInfo>("ClientInfo", c_addClient);

			clientList = new ArrayList();
			this.newTCPConn = newTCPConn;

			InitializeComponent();
			isHost = false;
			cinfo = new clientInfo("Anonymous");

			try
			{
				newTCPConn.SendObject("ClientInfo", cinfo);
			}
			catch (Exception e)
			{
				MessageBox.Show("ERR: " + e.Message);
				return;
			}

			String msg = "Connection successful.";
			ChatLog.Items.Add(msg);
			Users.Items.Add(cinfo.name);
			Rank.Items.Add("G");
		}

		private void PrintConnectedMsg(PacketHeader packetHeader, Connection connection, Connection incomingObject)
		{
			String msg = connection.ToString() + " has connected.";
			ChatLog.Items.Add(msg);
			//Users.Items.Add(msg);
		}

		// Print msg via ip for now.
		private void PrintIncMsg(PacketHeader packetHeader, Connection connection, string incomingObject)
		{
			String msg = connection.ToString() + ": " + incomingObject + "";
			ChatLog.Items.Add(msg);

			List<Connection> l = NetworkComms.GetExistingConnection();
			foreach (Connection i in l)
			{
				if(i != connection)
					i.SendObject(textBox1.Text);
			}

		}

		private void ChatForm_Load(object sender, EventArgs e)
		{
		}

		private void ChatForm_Closing(object sender, EventArgs e)
		{
			// [ttaj] Turn off server/client once done.
			NetworkComms.Shutdown();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ChatLog_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Users_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			sendMsg();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				sendMsg();
			}
		}

		private void sendMsg()
		{
			if (textBox1.Text.Length == 0) return;


			if (isHost == true)
			{
				messageHolder toSend = new messageHolder(host.name + ": " + textBox1.Text);
				ChatLog.Items.Add(host.name + ": " + textBox1.Text);
				List<ConnectionInfo> l = NetworkComms.AllConnectionInfo();

				foreach (ConnectionInfo i in l)
				{
						TCPConnection.GetConnection(i).SendObject("Message", toSend);
				}
			}
			else
			{
				messageHolder toSend = new messageHolder(cinfo.name + ": " + textBox1.Text);
				ChatLog.Items.Add(cinfo.name + ": " + textBox1.Text);
				newTCPConn.SendObject("Message", toSend);
			}
			textBox1.Clear();
		}

		private void Rank_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
