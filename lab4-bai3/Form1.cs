using HtmlAgilityPack;

namespace lab4_bai3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			webView21.Source = new Uri(textBox1.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var web = new HtmlWeb();
			var htmlDoc = web.Load(textBox1.Text);

			var images = htmlDoc.DocumentNode.SelectNodes("//img");

			foreach ( var image in images )
			{
				var imageUrl = image.Attributes["src"].Value;
				if (!imageUrl.StartsWith("http"))
				{
					imageUrl = textBox1.Text + imageUrl;
				}

				MessageBox.Show(imageUrl);
				
			}
		}
	}
}
