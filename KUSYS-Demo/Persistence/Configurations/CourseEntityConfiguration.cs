using KUSYS_Demo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KUSYS_Demo.Persistence.Configurations
{
    public class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(new List<Course>()
        {
            new(){ CourseId="CSI101",CourseName="Introduction to Computer Science"},
            new(){ CourseId="CSI102",CourseName="Algorithms"},
            new(){ CourseId="MAT101",CourseName="Calculus"},
            new(){ CourseId="PHY101",CourseName="Physics"},
        });
        }
    }
}
