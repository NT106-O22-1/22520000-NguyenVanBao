using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class Bai5 : Form
	{
		class Phim
		{
			[JsonPropertyName("TenPhim")]
			public string TenPhim { get; set; }

			[JsonPropertyName("GiaVeChuan")]
			public int GiaVeChuan { get; set; }

			[JsonPropertyName("PhongChieu")]
			public int[] PhongChieu { get; set; }
		}
		public Bai5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
				List<Phim>? phims = JsonSerializer.Deserialize<List<Phim>>(fileStream);
				comboBox1.DataSource = phims;
				comboBox1.DisplayMember = "TenPhim";
			}
		}
	}
}
