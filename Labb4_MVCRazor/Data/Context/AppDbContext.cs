using Labb4_MVCRazor.Data.EntityConfigurations;
using Labb4_MVCRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4_MVCRazor.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<ActiveBorrows> ActiveBorrows { get; set; }

        public DbSet<ReturnedBorrows> ReturnedBorrows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new BorrowHistoryConfiguration());
        }
    }
}
