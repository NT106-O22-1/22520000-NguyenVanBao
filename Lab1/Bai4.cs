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
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					CheckBox cb = new CheckBox();
					cb.Text = string.Format("{0} {1}", i, j);
					cb.Name = string.Format("cb_{0}_{1}", i, j);
					cb.Location = new Point((i+1)*50, (j+1)*50);
					groupBox1.Controls.Add(cb);
				}
			}
		}

	}
}
