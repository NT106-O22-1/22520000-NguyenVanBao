using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace lab5_bai1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var smtpClient = new SmtpClient();
				smtpClient.Connect("smtp.gmail.com", 465, true);
				smtpClient.Authenticate("nvbao4566@gmail.com", "fotq pdje olbb wiyv");

				var message = new MimeMessage();
				message.From.Add(new MailboxAddress("Bao", "nvbao4566@gmail.com"));
				message.To.Add(new MailboxAddress("", textBox1.Text));
				message.Subject = textBox2.Text;
				message.Body = new TextPart("html") // gửi ở dạng plain text, hoặc có thể thay 
				{
					Text = richTextBox1.Text
				};


				smtpClient.Send(message);
				MessageBox.Show("Da gui thanh cong");
			} catch (Exception ex)
			{
				MessageBox.Show("Sai tai khoan hoac mat khau");
			}
		}
	}
}
