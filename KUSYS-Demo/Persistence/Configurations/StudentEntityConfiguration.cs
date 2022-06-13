using KUSYS_Demo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KUSYS_Demo.Persistence.Configurations
{
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(new List<Student>()
        {
            new( 1,"CSI101", "Ramazan", "Bayazit", DateTime.Now),
            new( 2,"CSI102", "Rıdvan", "Abay", DateTime.Now),
            new( 3,"MAT101", "Mert", "Artan", DateTime.Now),
            new( 4, "PHY101", "Recep", "Çil", DateTime.Now)
        });
        }
    }
}
