namespace lab2
{
	partial class Bai6
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
			components = new System.ComponentModel.Container();
			dataGridView1 = new DataGridView();
			iDMNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			tenMonAnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			hinhAnhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			iDNDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nguoiDungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			monAnBindingSource = new BindingSource(components);
			button1 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)monAnBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDMNDataGridViewTextBoxColumn, tenMonAnDataGridViewTextBoxColumn, hinhAnhDataGridViewTextBoxColumn, iDNDDataGridViewTextBoxColumn, nguoiDungDataGridViewTextBoxColumn });
			dataGridView1.DataSource = monAnBindingSource;
			dataGridView1.Location = new Point(403, 26);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(345, 271);
			dataGridView1.TabIndex = 0;
			// 
			// iDMNDataGridViewTextBoxColumn
			// 
			iDMNDataGridViewTextBoxColumn.DataPropertyName = "IDMN";
			iDMNDataGridViewTextBoxColumn.HeaderText = "IDMN";
			iDMNDataGridViewTextBoxColumn.Name = "iDMNDataGridViewTextBoxColumn";
			// 
			// tenMonAnDataGridViewTextBoxColumn
			// 
			tenMonAnDataGridViewTextBoxColumn.DataPropertyName = "TenMonAn";
			tenMonAnDataGridViewTextBoxColumn.HeaderText = "TenMonAn";
			tenMonAnDataGridViewTextBoxColumn.Name = "tenMonAnDataGridViewTextBoxColumn";
			// 
			// hinhAnhDataGridViewTextBoxColumn
			// 
			hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
			hinhAnhDataGridViewTextBoxColumn.HeaderText = "HinhAnh";
			hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
			// 
			// iDNDDataGridViewTextBoxColumn
			// 
			iDNDDataGridViewTextBoxColumn.DataPropertyName = "IDND";
			iDNDDataGridViewTextBoxColumn.HeaderText = "IDND";
			iDNDDataGridViewTextBoxColumn.Name = "iDNDDataGridViewTextBoxColumn";
			iDNDDataGridViewTextBoxColumn.Visible = false;
			// 
			// nguoiDungDataGridViewTextBoxColumn
			// 
			nguoiDungDataGridViewTextBoxColumn.DataPropertyName = "NguoiDung";
			nguoiDungDataGridViewTextBoxColumn.HeaderText = "NguoiDung";
			nguoiDungDataGridViewTextBoxColumn.Name = "nguoiDungDataGridViewTextBoxColumn";
			nguoiDungDataGridViewTextBoxColumn.Visible = false;
			// 
			// monAnBindingSource
			// 
			monAnBindingSource.DataSource = typeof(MonAn);
			// 
			// button1
			// 
			button1.Location = new Point(673, 303);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(12, 26);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "Random";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Bai6
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(760, 338);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Name = "Bai6";
			Text = "Bai6";
			FormClosing += Bai6_FormClosing;
			Load += Bai6_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)monAnBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private BindingSource monAnBindingSource;
		private DataGridViewTextBoxColumn iDMNDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn tenMonAnDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn iDNDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nguoiDungDataGridViewTextBoxColumn;
		private Button button1;
		private Button button2;
	}
}