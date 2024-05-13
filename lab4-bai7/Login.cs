using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_bai7
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		class Phim
		{
			[JsonPropertyName("tenphim")]
			public string TenPhim { get; set; }
		}

		private static HttpClient httpClient = new HttpClient()
		{
			BaseAddress = new Uri("https://nt106.uitiot.vn")
		};

		private async void button1_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text;
			string password = textBox2.Text;

			var formData = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string, string>("username", username),
				new KeyValuePair<string, string>("password", password),
			});

			HttpResponseMessage responseMessage = await httpClient.PostAsync(
				"/auth/token",
				formData
			);
			var response = await responseMessage.Content.ReadAsStringAsync();
			JObject keyValuePairs = JObject.Parse(response);

			if (responseMessage.StatusCode == HttpStatusCode.OK)
			{
				var access_token = keyValuePairs["access_token"].ToString();
				MessageBox.Show(access_token, "Access Token");
			} else
			{
				var err = keyValuePairs["detail"].ToString();
				MessageBox.Show(err, "Looix", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
