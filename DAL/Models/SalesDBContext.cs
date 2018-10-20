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

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //Esto ira luego en una JSON
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SalesDB;User ID=sa;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
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
