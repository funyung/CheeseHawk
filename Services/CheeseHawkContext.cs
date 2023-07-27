using Microsoft.EntityFrameworkCore;
using CheeseHawk.Models;

namespace CheeseHawk.Services
{
	public class CheeseHawkContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public string DbLocation { get; }

		public CheeseHawkContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbLocation = System.IO.Path.Join(path, "cheesehawk.db");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite($"Data Source={DbLocation}");
	}
}
