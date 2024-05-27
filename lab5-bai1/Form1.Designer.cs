namespace lab5_bai1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			label1 = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			richTextBox1 = new RichTextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(64, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(267, 23);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(19, 15);
			label1.TabIndex = 1;
			label1.Text = "To";
			// 
			// textBox2
			// 
			textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox2.Location = new Point(64, 41);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(267, 23);
			textBox2.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 49);
			label2.Name = "label2";
			label2.Size = new Size(46, 15);
			label2.TabIndex = 1;
			label2.Text = "Subject";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 78);
			label3.Name = "label3";
			label3.Size = new Size(34, 15);
			label3.TabIndex = 1;
			label3.Text = "Body";
			// 
			// richTextBox1
			// 
			richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			richTextBox1.Location = new Point(64, 70);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(267, 125);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "";
			// 
			// button1
			// 
			button1.Location = new Point(256, 201);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Send";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(347, 238);
			Controls.Add(button1);
			Controls.Add(richTextBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private TextBox textBox2;
		private Label label2;
		private Label label3;
		private RichTextBox richTextBox1;
		private Button button1;
	}
}
