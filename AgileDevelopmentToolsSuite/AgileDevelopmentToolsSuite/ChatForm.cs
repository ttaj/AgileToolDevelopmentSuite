using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.Connections.TCP;
using ProtoBuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class ChatForm : Form
	{
		private int port;
		private string ip;
		private bool isHost = false;
		private Connection newTCPConn;
		ArrayList s_clientList;
		ArrayList c_clientList;
		int s_idTick = 0;
		int c_listTick = 0;
		clientInfo you;

		public ChatForm()
		{
			InitializeComponent();
		}

		//server - todo: add a textbox for ip.
		public ChatForm(String incip, int port, string name)
		{
			s_clientList = new ArrayList();
			InitializeComponent();

			this.port = port;
			this.ip = incip;
			isHost = true;

			// [ttaj] Setup the server, if the object being sent is a string then run the function PrintIncMsg
			NetworkComms.AppendGlobalIncomingPacketHandler<clientInfo>("ClientInfo", s_addClient);
			NetworkComms.AppendGlobalIncomingPacketHandler<messageHolder>("Message", s_addMessage);

			// [ttaj] Start the server.
			TCPConnection.StartListening(ConnectionType.TCP, new System.Net.IPEndPoint(IPAddress.Parse(ip), port));
			clientInfoServ host = new clientInfoServ(name, null, "Host", 0);
			s_idTick++;

			ChatLog.Items.Add("Server successfully started!");

			s_clientList.Add(host);
			Users.Items.Add(host.name);
			Rank.Items.Add(host.rank);

			you = new clientInfo(host, 0);
		}

		private void s_addMessage(PacketHeader packetHeader, Connection connection, messageHolder incomingObject)
		{

			
			ChatLog.Invoke(new MethodInvoker(delegate ()
			{
				ChatLog.Items.Add(incomingObject.message);
			}));

			//int count = 0;
			// If the id is 0, which is always the host, then dont send the msg.
			foreach (clientInfoServ cinfo in s_clientList)
			{
				Connection conn = cinfo.conn;
				if (conn.Equals(connection) || cinfo.id == 0) continue;
				conn.SendObject("Message", incomingObject);
				//count++;
			}
			//MessageBox.Show("s_addmessage: " + count);
		}

		private void c_addMessage(PacketHeader packetHeader, Connection connection, messageHolder incomingObject)
		{
			ChatLog.Invoke(new MethodInvoker(delegate ()
			{
				ChatLog.Items.Add(incomingObject.message);
			}));
		}

		// Heavy work of server to notify all users of this guys connection
		public void s_addUser(clientInfoServ user, Connection connection)
		{

			// Send user every person in the server currently.
			try
			{
				foreach (clientInfoServ x in s_clientList)
				{
					clientInfo toSend = new clientInfo(x, 0);
					connection.SendObject("ClientInfo", toSend);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERR: " + ex.Message + "; SIZE: " + s_clientList.Count);
			}

			// Add this guy to server list.
			s_clientList.Add(user);

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
			messageHolder toSend = new messageHolder(v);

			foreach(clientInfoServ cinfo in s_clientList)
			{
				Connection connection = cinfo.conn;
				if (connection == null || connection.Equals(conn)) continue;
				connection.SendObject("Message", toSend);
			}
		}

		public int generateServerID()
		{
			s_idTick++;
			return s_idTick;
		}

		// Adds client to server list.
		private void s_addClient(PacketHeader packetHeader, Connection connection, clientInfo incomingObject)
		{
			clientInfoServ toAdd = new clientInfoServ(incomingObject.name, connection, incomingObject.rank, generateServerID());
			s_addUser(toAdd, connection);
		}

		[ProtoContract]
		public class clientInfo
		{
			[ProtoMember(1)]
			public String name { get; private set; }
			[ProtoMember(2)]
			public String rank { get; private set; } //g stands for guest.
			[ProtoMember(3)]
			public int listPos { get; private set; }
			[ProtoMember(4)]
			public int id { get; private set; }
			protected clientInfo() { }

			public clientInfo(clientInfoServ info, int listPos)
			{
				this.name = info.name;
				this.rank = info.rank;
				this.id = info.id;
				this.listPos = listPos;
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
			[ProtoMember(4)]
			public int id { get; private set; }


			// needed for proto
			protected clientInfoServ() { }
			public clientInfoServ(String name, Connection conn, String rank, int id)
			{
				this.name = name; // todo: set name to sql name and not ip
				this.conn = conn;
				this.rank = rank;
				this.id = id;
			}
		}

		public int generateListPos()
		{
			c_listTick++;
			return c_listTick;
		}

		public int c_getListPos()
		{
			return c_clientList.Count;	
		}

		// Adds the received user to the client.
		private void c_addClient(PacketHeader packetHeader, Connection connection, clientInfoServ incomingObject)
		{
			// First we add him to the list...
			clientInfo toAdd = new clientInfo(incomingObject, c_getListPos());

			// Now we're good, so add him to the listbox.
			Rank.Invoke(new MethodInvoker(delegate ()
			{
				Rank.Items.Add(incomingObject.rank);
			}));

			Users.Invoke(new MethodInvoker(delegate ()
			{
				Users.Items.Add(incomingObject.name);
			}));

		}
		private void c_addClient(PacketHeader packetHeader, Connection connection, clientInfo incomingObject)
		{
			// First we check if we already have someone with that id...
			foreach (clientInfo x in c_clientList)
			{
				if (x.id == incomingObject.id) return;
			}

			// We add him to the list...
			c_clientList.Add(incomingObject);

			// Now we're good, so add him to the listbox.
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
		public ChatForm(String name, Connection newTCPConn)
		{
			NetworkComms.AppendGlobalIncomingPacketHandler<messageHolder>("Message", c_addMessage);
			NetworkComms.AppendGlobalIncomingPacketHandler<clientInfoServ>("clientInfoServ", c_addClient);
			NetworkComms.AppendGlobalIncomingPacketHandler<clientInfo>("ClientInfo", c_addClient);

			c_clientList = new ArrayList();
			this.newTCPConn = newTCPConn;

			InitializeComponent();
			isHost = false;

			clientInfoServ toGen = new clientInfoServ(name, this.newTCPConn, "Guest", 0);
			clientInfo cinfo = new clientInfo(toGen, c_listTick);
			you = cinfo;
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

			Users.Items.Add(you.name);
			Rank.Items.Add(you.rank);

		}

		private void PrintConnectedMsg(PacketHeader packetHeader, Connection connection, Connection incomingObject)
		{
			String msg = connection.ToString() + " has connected.";
			ChatLog.Items.Add(msg);
			//Users.Items.Add(msg);
		}

		// Print msg via ip for now.
		/* Deprecated.
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
		*/

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
				messageHolder toSend = new messageHolder(you.name + ": " + textBox1.Text);
				ChatLog.Items.Add(you.name + ": " + textBox1.Text);
				//int count = 0;
				foreach (clientInfoServ x in s_clientList)
				{
					if (x.id == 0 || x.conn == null) continue;
						x.conn.SendObject("Message", toSend);
					//count++;
				}
				//MessageBox.Show("sendMsg: " + count);
			}
			else
			{
				messageHolder toSend = new messageHolder(you.name + ": " + textBox1.Text);
				ChatLog.Items.Add(you.name + ": " + textBox1.Text);
				newTCPConn.SendObject("Message", toSend);
			}
			textBox1.Clear();
		}

		private void Rank_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
