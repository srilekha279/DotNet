using BasicAuthWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BasicAuthWebApi
{
    public class UserDbContext:DbContext
    {
        public UserDbContext()
        {
            
        }
        public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
        {
            
        }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                //entity.ToTable("Users"); // Optional: rename table
                entity.HasKey(u => u.Id); // Explicit primary key

                entity.Property(u => u.Email)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(u => u.FullName)
                      .HasColumnName("Name"); // Rename column

                entity.HasIndex(u => u.Email)
                      .IsUnique(); // Unique constraint
            });
        }

    }
}
