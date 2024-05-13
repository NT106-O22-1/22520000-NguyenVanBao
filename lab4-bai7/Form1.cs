using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using System.Net;

namespace lab4_bai7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public static readonly HttpClient httpClient = new HttpClient
		{
			BaseAddress = new Uri(@"https://nt106.uitiot.vn")
		};

		private class Pagination
		{
			public int current { get; set; }
			public int pageSize { get; set; }
		}
				

		private async void button1_Click(object sender, EventArgs e)
		{
			string uri = "api/v1/monan/all";
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer {access token}");

			Pagination pagination = new Pagination
			{
				current = 1,
				pageSize = 50
			};
			using HttpResponseMessage response = await httpClient.PostAsJsonAsync(
				uri,
				pagination
			);

			var res = await response.Content.ReadAsStringAsync();
			JObject keyValuePairs = JObject.Parse(res);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				MessageBox.Show(keyValuePairs["detail"].ToString());
			}
			else
			{
				JToken paginationRes = keyValuePairs["pagination"];
				int total = paginationRes.Value<int>("total");
				double totalPage = Math.Ceiling((float)total / (float)pagination.pageSize);

				var monans = keyValuePairs["data"];
			}
		}
	}
}
