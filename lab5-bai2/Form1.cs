using MailKit;
using MailKit.Net.Imap;
using System.Collections.Generic;

namespace lab5_bai2
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
				var imapClient = new ImapClient();
				imapClient.Connect("imap.gmail.com", 993, true);
				imapClient.Authenticate(textBox1.Text, textBox2.Text);

				var inbox = imapClient.Inbox;
				inbox.Open(FolderAccess.ReadOnly);

				for (int i = inbox.Count - 1; i >= 0; i--)
				{
					var message = inbox.GetMessage(i);
				}
			} catch (Exception ex)
			{

			}


		}
	}
}
