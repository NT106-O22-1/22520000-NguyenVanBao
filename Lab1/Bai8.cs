﻿using System;
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
	public partial class Bai8 : Form
	{
		public Bai8()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listView1.Items.Add(new ListViewItem(textBox1.Text));
		}
	}
}
