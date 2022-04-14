using InstituteManagementSystem.Authentication;
using InstituteManagementSystem.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InstituteManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //modelBuilder
        //    //    .Entity<StudentAdmissionDetails>()
        //    //    .Property(p => p.Gender)
        //    //    .HasConversion(
        //    //        v => v.ToString(),
        //    //        v => (Gender)Enum.Parse(typeof(Gender), v));
        //}
        //public DbSet<StudentAdmissionDetails> StudentAdmissionDetails { get; set; }
        //public DbSet<FeesDetails> FeesDetails { get; set; }
        //public DbSet<CourseDetails> CourseDetails { get; set; }
    }
}
