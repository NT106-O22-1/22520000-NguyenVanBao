﻿namespace lab4_bai7
{
	partial class Login
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
			textBox2 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(88, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(88, 41);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '*';
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(59, 15);
			label1.TabIndex = 1;
			label1.Text = "username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 49);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "password";
			// 
			// button1
			// 
			button1.Location = new Point(194, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 52);
			button1.TabIndex = 2;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(289, 79);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Label label1;
		private Label label2;
		private Button button1;
	}
}