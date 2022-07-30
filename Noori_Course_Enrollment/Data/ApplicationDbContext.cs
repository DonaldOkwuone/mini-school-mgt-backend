using System;
using Microsoft.EntityFrameworkCore;
using Noori_Course_Enrollment.Model;

namespace Noori_Course_Enrollment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Noori_School> noori_schools { get; set; }
        public DbSet<Noori_Department> noori_departments { get; set; }
        public DbSet<Noori_Level> noori_levels { get; set; }
        public DbSet<Noori_Student> noori_students { get; set; }
        public DbSet<Noori_Course> noori_courses { get; set; }
        public DbSet<Noori_Student_Registration> Noori_Student_Registrations { get; set; }

    }
}

