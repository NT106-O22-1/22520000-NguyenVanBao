using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class Bai7 : Form
	{
		public Bai7()
		{
			InitializeComponent();

			foreach(var drive in DriveInfo.GetDrives())
			{
				TreeNode treeNode = new TreeNode(drive.Name + drive.VolumeLabel);
				treeView1.Nodes.Add(treeNode);
			}
		}
	}
}
