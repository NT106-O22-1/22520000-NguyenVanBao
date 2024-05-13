using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Security.Policy;

namespace lab4_bai1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private string getHTML(string szURL)
		{
			// Create a request for the URL.
			WebRequest request = WebRequest.Create(szURL);
			// Get the response. 
			WebResponse response = request.GetResponse();
			// Get the stream containing content returned by the server. 
			Stream dataStream = response.GetResponseStream();
			// Open the stream using a StreamReader for easy access. 
			StreamReader reader = new StreamReader(dataStream);
			// Read the content. 
			string responseFromServer = reader.ReadToEnd();
			response.Close();
			return responseFromServer;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = getHTML(textBox1.Text);
		}
	}
}
