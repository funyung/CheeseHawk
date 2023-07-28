using Microsoft.EntityFrameworkCore;
using CheeseHawk.Models;

namespace CheeseHawk
{
    public class CheeseHawkContext : DbContext
    {
        public DbSet<BaseModel> Records { get; set; }

		public CheeseHawkContext() : base()
        {
		}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=./cheesehawk.db;");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BaseModel>().UseTpcMappingStrategy();

            modelBuilder.Entity<UserContact>().ToTable("UserContact"/*,
				builder =>
				{
					builder.Property(user => user.Id).HasColumnName("userId");
				}*/);

			modelBuilder.Entity<PaymentRequest>().ToTable("PaymentRequests"/*,
				builder =>
				{
					builder.Property(user => user.Id).HasColumnName("paymentId");
				}*/);
		}
	}
}
