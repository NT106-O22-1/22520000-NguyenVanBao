using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai1
{
	public partial class UDPClient : Form
	{
		public UDPClient()
		{
			InitializeComponent();
			Form1 form1 = new Form1();
			form1.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UdpClient udpClient = new UdpClient();
			Byte[] bytesSend = Encoding.UTF8.GetBytes("Xin chào!");
			udpClient.Send(bytesSend, bytesSend.Length, textBox1.Text, 8088);
		}

		private void UDPClient_Load(object sender, EventArgs e)
		{

		}
	}
}
