using AsPNetCoreWebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsPNetCoreWebApplication1.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public StudentDbContext()
        {
            
        }
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options) 
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //if (!optionsBuilder.IsConfigured)
        //{
        //    optionsBuilder.UseSqlServer("server=WIN11; Database = School; Integrated Security = true; trusted_connection=true; Persist Security Info = False; Encrypt = False");

        //}
        //} wind
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne(s => s.Grade).WithMany(g => g.Students).HasForeignKey(s => s.GradeId);
        }
    }
}
