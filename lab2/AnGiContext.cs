using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
	internal class AnGiContext:DbContext
	{
		public DbSet<MonAn> MonAns { get; set; }
		public DbSet<NguoiDung> NguoiDungs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlite("Data Source=homnayangi.db");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MonAn>().HasData(
				new MonAn{ IDMN = 1, TenMonAn = "Phở" }
			);
			modelBuilder.Entity<NguoiDung>().HasData(
				new NguoiDung { IDND = 1, HoVaTen = "Nguyen Van Bao", QuyenHan = 1 }
			);
		}
	}
}
