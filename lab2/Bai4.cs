using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class Bai4 : Form
	{
		public Bai4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += string.Format("{0};{1};{2}", tbHoTen.Text, tbMssv.Text, tbSDT.Text) + Environment.NewLine;

		}
	}
}
