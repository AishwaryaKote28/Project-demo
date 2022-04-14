using InstituteManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<StudentAdmissionDetails> StudentAdmissionDetails { get; set; }
        public DbSet<FeesDetails> FeesDetails { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }

    }
   
}
