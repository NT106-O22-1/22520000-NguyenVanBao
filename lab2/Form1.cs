using System.Runtime.Serialization.Formatters.Binary;

namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text file|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
				StreamReader streamReader = new StreamReader(fileStream);
				richTextBox1.Text = streamReader.ReadLine();
				fileStream.Close();
				streamReader.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.Write(richTextBox1.Text);
				streamWriter.Close();
				fileStream.Close();
			}
		}
	}
}
