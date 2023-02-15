using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMS.Model;

namespace PMS.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
           builder.Property(a => a.Id)
              .IsRequired();
          //  builder.Property(a => a.PlannedStart)
                  // .IsRequired();
           // builder.Property(a => a.PlannedFinish)
                 // .IsRequired();

        }
    }
}
