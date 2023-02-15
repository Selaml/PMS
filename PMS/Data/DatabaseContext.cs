using Microsoft.EntityFrameworkCore;
using PMS.Configurations;
using PMS.Model;

namespace PMS.Data
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
        //public DbSet<Todo> Todos { get; set; }
        //public DbSet<Project> Projects { get; set; }
       public DbSet<Tasks> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        //  public DbSet<Budget> Budgets { get; set; }
        // public DbSet<Client> Clients { get; set; }
        //  public DbSet<Employee> Employees { get; set; }
        //  public DbSet<Member> Members { get; set; }
        public DbSet<Milestone> Milestones{ get; set; }
      //  public DbSet<Solutions> Solutions { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          //  builder.ApplyConfiguration(new ProjectConfiguration());
            builder.ApplyConfiguration(new TaskConfiguration());
        }
    }
}