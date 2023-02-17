using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMS.Model;

namespace PMS.Configurations
{
    public class Milestoneconfiguration : IEntityTypeConfiguration<Milestone>
    {
        public void Configure(EntityTypeBuilder<Milestone> builder)
        {
            builder.Property(a => a.Id)
             .IsRequired();
            builder.Property(a => a.ProjectId)
             .IsRequired();
        }
    }
}
