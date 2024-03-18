namespace lab2
{
	partial class Bai7
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
			treeView1 = new TreeView();
			SuspendLayout();
			// 
			// treeView1
			// 
			treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			treeView1.Location = new Point(12, 12);
			treeView1.Name = "treeView1";
			treeView1.Size = new Size(121, 239);
			treeView1.TabIndex = 0;
			// 
			// Bai7
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(349, 263);
			Controls.Add(treeView1);
			Name = "Bai7";
			Text = "Bai7";
			ResumeLayout(false);
		}

		#endregion

		private TreeView treeView1;
	}
}