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
			comboBox1 = new ComboBox();
			label1 = new Label();
			groupBox1 = new GroupBox();
			SuspendLayout();
			// 
			// comboBox1
			// 
			comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Phim A", "Phim B", "Phim C", "Phim D" });
			comboBox1.Location = new Point(85, 9);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(261, 23);
			comboBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 17);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 1;
			label1.Text = "Chọn phim";
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Location = new Point(12, 38);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(334, 229);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Chọn ghế";
			// 
			// Bai4
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(358, 279);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(comboBox1);
			Name = "Bai4";
			Text = "Bai4";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBox1;
		private Label label1;
		private GroupBox groupBox1;
	}
}