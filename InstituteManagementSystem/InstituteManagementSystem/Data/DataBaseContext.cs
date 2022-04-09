using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace InstituteManagementSystem.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<StudentAdmissionDetails> StudentAdmissionDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder
            //    .Entity<StudentAdmissionDetails>()
            //    .Property(p => p.Gender)
            //    .HasConversion(
            //        v => v.ToString(),
            //        v => (Gender)Enum.Parse(typeof(Gender), v));
            //modelBuilder
            //    .Entity<StudentAdmissionVM>()
            //    .Property(p => p.Sex)
            //    .HasConversion(
            //        v => v.ToString(),
            //        v => (Sex)Enum.Parse(typeof(Sex), v));
        }
    }
}