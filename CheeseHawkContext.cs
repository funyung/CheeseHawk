using Microsoft.EntityFrameworkCore;
using CheeseHawk.Models;

namespace CheeseHawk
{
    public class CheeseHawkContext : DbContext
    {
        public DbSet<UserContact> Users { get; set; }

        public DbSet<PaymentRequest> PaymentRequests { get; set; }


		public CheeseHawkContext() : base()
        {
		}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=./cheesehawk.db;");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<UserContact>().ToTable("Users");
            //modelBuilder.Entity<PaymentRequest>().ToTable("PaymentRequests");
		}
	}
}
