using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Bai4 : Form
	{
		public Bai4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			string input = textBox1.Text;

			listView1.Items.Add(new ListViewItem(input));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}
	}
}
