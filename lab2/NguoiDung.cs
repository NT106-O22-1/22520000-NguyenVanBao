using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

public class NguoiDung
{
	[Key]
	public int IDND { get; set; }
	public string HoVaTen { get; set; }
	public int QuyenHan { get; set; }
	public virtual ObservableCollectionListSource<MonAn> MonAns { get; } = new();
}
