namespace Lab1
{
	partial class Bai4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			button1 = new Button();
			listView1 = new ListView();
			button2 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(175, 41);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(196, 23);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(296, 70);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// listView1
			// 
			listView1.Location = new Point(387, 41);
			listView1.Name = "listView1";
			listView1.Size = new Size(201, 97);
			listView1.TabIndex = 2;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.List;
			// 
			// button2
			// 
			button2.Location = new Point(296, 151);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Bai4
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(listView1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "Bai4";
			Text = "Bai4";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private ListView listView1;
		private Button button2;
	}
}