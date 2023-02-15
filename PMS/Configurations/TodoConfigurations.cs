/*
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMS.Model;

namespace PMS.Configurations
{
    public class TodoConfigurations : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.Property(a => a.Id)
                 .IsRequired();
                
            builder.Property(a => a.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(a => a.Discription)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(a => a.DueDate)
                    .IsRequired();
                    

                    
            builder.Property(a => a.Is_done)
                .HasDefaultValue(false);
                  
                    
         
           
        }
    }
}
*/