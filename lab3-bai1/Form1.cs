using System.Net;
using System.Net.Sockets;
using System.Text;

namespace lab3_bai1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void receive()
		{
			UdpClient udp = new UdpClient(8088);
			while (true)
			{
				IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
				Byte[] receiveData = udp.Receive(ref iPEndPoint);
				string mess = Encoding.UTF8.GetString(receiveData);
				mess = iPEndPoint.Address.ToString() + ":" + mess;

				if (listView1.InvokeRequired)
				{
					listView1.Invoke((MethodInvoker)delegate
					{
						listView1.Items.Add(mess);
					});
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Thread thread = new Thread(receive);
			thread.Start();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
