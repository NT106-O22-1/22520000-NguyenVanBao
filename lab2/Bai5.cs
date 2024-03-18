using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class Bai5 : Form
	{
		class Phim
		{
			public string TenPhim { get; set; }
			public int GiaVeChuan { get; set; }
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
				List<Phim> phims = JsonSerializer.Deserialize<List<Phim>>(fileStream);
			}
		}
	}
}
