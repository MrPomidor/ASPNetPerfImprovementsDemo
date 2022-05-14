using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Core31Api.Data
{
    public class AdventureWorks : DbContext
    {
        protected AdventureWorks()
        {
        }

        public AdventureWorks([NotNull] DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesOrderDetail>()
                .HasKey(nameof(SalesOrderDetail.SalesOrderID), nameof(SalesOrderDetail.SalesOrderDetailID));
        }
    }
}
