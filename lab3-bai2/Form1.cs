using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace lab3_bai2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ReceiveData(Socket clientSocket)
		{
			int bytesReceive = 0;
			byte[] receive = new byte[1];
			if (listView1.InvokeRequired)
			{
				listView1.Invoke((MethodInvoker)delegate
				{
					listView1.Items.Add("New Client Connected");
				});
			}
			while (clientSocket.Connected)
			{
				string text = "";
				do
				{
					bytesReceive = clientSocket.Receive(receive);
					text += Encoding.UTF8.GetString(receive);
				} while (text[text.Length - 1] != '\n');

				if (listView1.InvokeRequired)
				{
					listView1.Invoke((MethodInvoker)delegate
					{
						listView1.Items.Add(text);
					});
				}
			}
		}

		private void StartListen()
		{
			
			Socket listenerSocket = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Stream,
				ProtocolType.Tcp
			);
			IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

			listenerSocket.Bind(iPEndPoint);
			listenerSocket.Listen(5);

			while (true)
			{
				var clientSocket = listenerSocket.Accept();
				Thread thread = new Thread(() => ReceiveData(clientSocket));
				thread.Start();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Thread thread = new Thread(StartListen);
			thread.Start();
		}
	}
}
