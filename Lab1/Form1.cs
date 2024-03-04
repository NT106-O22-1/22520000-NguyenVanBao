namespace Lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Bai1 bai1 = new Bai1();
			bai1.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Bai4 bai4 = new Bai4();
			bai4.ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Bai8 bai8 = new Bai8();
			bai8.ShowDialog();
		}
	}
}
