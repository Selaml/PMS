
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMS.Model;
namespace PMS.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(a => a.Id)
                 .IsRequired();

           // builder.Property(a => a.EmployeeId);
                    

            builder.Property(a => a.PlannedStartDate)
                    .IsRequired();
            builder.Property(a => a.PlannedEndDate)
                  .IsRequired();
           // builder.Property(a => a.ClientId)
                //  .IsRequired();

           // builder.Property(a => a.BudgetId)
//.IsRequired();
          
            builder.Property(a => a.ContractSignDate)
                  .IsRequired();
            builder.Property(a => a.LcOppeningDate)
                  .IsRequired();
          //  builder.Property(a => a.SolutionsId)
           //       .IsRequired();
            builder.Property(a => a.NumberOfMilestones)
                  .IsRequired();
            builder.Property(a => a.PlannedStartDate)
                  .IsRequired();

        }
    }
        
}
