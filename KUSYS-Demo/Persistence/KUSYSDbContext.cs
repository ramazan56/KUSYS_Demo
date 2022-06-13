using KUSYS_Demo.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KUSYS_Demo.Persistence
{
    public class KUSYSDbContext:DbContext
    {
        public KUSYSDbContext(DbContextOptions<KUSYSDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
