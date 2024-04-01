using Microsoft.EntityFrameworkCore;
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
	public partial class Bai6 : Form
	{
		private AnGiContext? dbContext;
		public Bai6()
		{
			InitializeComponent();
		}

		private void Bai6_Load(object sender, EventArgs e)
		{
			this.dbContext = new AnGiContext();
			this.dbContext.Database.EnsureCreated();
			this.dbContext.MonAns.Load();
			this.dataGridView1.DataSource = dbContext.MonAns.Local.ToBindingList();
		}

		private void Bai6_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.dbContext?.Dispose();
			this.dbContext = null;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.dbContext?.SaveChanges();
			dataGridView1.Refresh();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var rand = new Random();

			List<string> tenMonAn = new List<string>();
			var monAns = dbContext.MonAns;
			foreach ( var monAn in monAns )
			{
				tenMonAn.Add(monAn.TenMonAn);
			}

			int index = rand.Next(tenMonAn.Count);
			MessageBox.Show(tenMonAn[index].ToString());
		}
	}
}
