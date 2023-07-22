using Microsoft.EntityFrameworkCore;
using CheeseHawk.Models;

namespace CheeseHawk.Services
{
	public class CheeseHawkContext : DbContext
	{
		public DbSet<UserContact> Contacts { get; set; }
		public DbSet<User> Users { get; set; }
		public string DbPath { get; set; }

		public CheeseHawkContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "cheesehawk.db");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite($"Data Source={DbPath}");
	}
}
