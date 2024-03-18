namespace lab2
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
			button1 = new Button();
			textBox1 = new TextBox();
			richTextBox1 = new RichTextBox();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(352, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Browse";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 13);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(334, 23);
			textBox1.TabIndex = 1;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(12, 42);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(415, 148);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "";
			// 
			// button2
			// 
			button2.Location = new Point(352, 196);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "Save as";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(439, 229);
			Controls.Add(button2);
			Controls.Add(richTextBox1);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private RichTextBox richTextBox1;
		private Button button2;
	}
}
