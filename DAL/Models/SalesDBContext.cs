using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace DAL.Models
{
    public partial class SalesDBContext : DbContext
    {
        public SalesDBContext()
        {
            
        }

        public SalesDBContext(DbContextOptions<SalesDBContext> options)
            : base(options)
        {
           
        }

        public SalesDBContext(DbContextOptions options)
            : base(options)
        {
        }


        public virtual DbSet<Entities.Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Products>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });
        }
    }
}
