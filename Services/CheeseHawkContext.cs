using Microsoft.EntityFrameworkCore;
using CheeseHawk.Models;

namespace CheeseHawk.Services
{
	public class CheeseHawkContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public CheeseHawkContext()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite("Data Source=./cheesehawk.db;");
	}
}
