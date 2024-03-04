namespace Lab1
{
	partial class Bai1
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			tbSoThu1 = new TextBox();
			tbSoThu2 = new TextBox();
			button1 = new Button();
			tbTong = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(46, 16);
			label1.Name = "label1";
			label1.Size = new Size(160, 15);
			label1.TabIndex = 0;
			label1.Text = "TÍNH TỔNG HAI SỐ NGUYÊN";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 48);
			label2.Name = "label2";
			label2.Size = new Size(50, 15);
			label2.TabIndex = 1;
			label2.Text = "Số thứ 1";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 81);
			label3.Name = "label3";
			label3.Size = new Size(50, 15);
			label3.TabIndex = 1;
			label3.Text = "Số thứ 2";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 144);
			label4.Name = "label4";
			label4.Size = new Size(34, 15);
			label4.TabIndex = 1;
			label4.Text = "Tổng";
			// 
			// tbSoThu1
			// 
			tbSoThu1.Location = new Point(72, 45);
			tbSoThu1.Name = "tbSoThu1";
			tbSoThu1.Size = new Size(172, 23);
			tbSoThu1.TabIndex = 1;
			// 
			// tbSoThu2
			// 
			tbSoThu2.Location = new Point(72, 74);
			tbSoThu2.Name = "tbSoThu2";
			tbSoThu2.Size = new Size(172, 23);
			tbSoThu2.TabIndex = 2;
			// 
			// button1
			// 
			button1.Location = new Point(72, 103);
			button1.Name = "button1";
			button1.Size = new Size(172, 23);
			button1.TabIndex = 3;
			button1.Text = "Tính";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// tbTong
			// 
			tbTong.Location = new Point(72, 136);
			tbTong.Name = "tbTong";
			tbTong.ReadOnly = true;
			tbTong.Size = new Size(170, 23);
			tbTong.TabIndex = 4;
			// 
			// Bai1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(254, 173);
			Controls.Add(tbTong);
			Controls.Add(button1);
			Controls.Add(tbSoThu2);
			Controls.Add(tbSoThu1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Bai1";
			Text = "Bai1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox tbSoThu1;
		private TextBox tbSoThu2;
		private Button button1;
		private TextBox tbTong;
	}
}