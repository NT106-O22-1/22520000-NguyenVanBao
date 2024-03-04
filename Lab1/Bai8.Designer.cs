namespace Lab1
{
	partial class Bai8
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
			listView1 = new ListView();
			label1 = new Label();
			button1 = new Button();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// listView1
			// 
			listView1.Location = new Point(201, 30);
			listView1.Name = "listView1";
			listView1.Size = new Size(159, 97);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(201, 12);
			label1.Name = "label1";
			label1.Size = new Size(106, 15);
			label1.TabIndex = 1;
			label1.Text = "Danh sách món ăn";
			// 
			// button1
			// 
			button1.Location = new Point(74, 59);
			button1.Name = "button1";
			button1.Size = new Size(121, 23);
			button1.TabIndex = 2;
			button1.Text = "Thêm món ăn";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(183, 23);
			textBox1.TabIndex = 3;
			// 
			// Bai8
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(374, 235);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(listView1);
			Name = "Bai8";
			Text = "Bai8";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView listView1;
		private Label label1;
		private Button button1;
		private TextBox textBox1;
	}
}