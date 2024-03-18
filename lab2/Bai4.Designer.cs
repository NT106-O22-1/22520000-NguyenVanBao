namespace lab2
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
			tbHoTen = new TextBox();
			label1 = new Label();
			tbMssv = new TextBox();
			label2 = new Label();
			tbSDT = new TextBox();
			label3 = new Label();
			button1 = new Button();
			richTextBox1 = new RichTextBox();
			button2 = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// tbHoTen
			// 
			tbHoTen.Location = new Point(75, 9);
			tbHoTen.Name = "tbHoTen";
			tbHoTen.Size = new Size(100, 23);
			tbHoTen.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 17);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 1;
			label1.Text = "Ho ten";
			// 
			// tbMssv
			// 
			tbMssv.Location = new Point(75, 38);
			tbMssv.Name = "tbMssv";
			tbMssv.Size = new Size(100, 23);
			tbMssv.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 46);
			label2.Name = "label2";
			label2.Size = new Size(37, 15);
			label2.TabIndex = 1;
			label2.Text = "MSSV";
			// 
			// tbSDT
			// 
			tbSDT.Location = new Point(75, 67);
			tbSDT.Name = "tbSDT";
			tbSDT.Size = new Size(100, 23);
			tbSDT.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 75);
			label3.Name = "label3";
			label3.Size = new Size(26, 15);
			label3.TabIndex = 1;
			label3.Text = "SDT";
			// 
			// button1
			// 
			button1.Location = new Point(100, 96);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "Nhap";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(181, 9);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(142, 236);
			richTextBox1.TabIndex = 3;
			richTextBox1.Text = "";
			// 
			// button2
			// 
			button2.Location = new Point(100, 215);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 4;
			button2.Text = "Luu";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(329, 8);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 5;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			// 
			// Bai4
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(575, 250);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(richTextBox1);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbSDT);
			Controls.Add(tbMssv);
			Controls.Add(tbHoTen);
			Name = "Bai4";
			Text = "Bai4";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbHoTen;
		private Label label1;
		private TextBox tbMssv;
		private Label label2;
		private TextBox tbSDT;
		private Label label3;
		private Button button1;
		private RichTextBox richTextBox1;
		private Button button2;
		private Button button3;
	}
}