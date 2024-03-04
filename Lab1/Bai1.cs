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
	public partial class Bai1 : Form
	{
		public Bai1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tbTong.Text = (int.Parse(tbSoThu1.Text) + int.Parse(tbSoThu2.Text)).ToString();
		}
	}
}
