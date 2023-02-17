using System.Collections.ObjectModel;

namespace PMS.Model
{
    public class Project
    {
        public int Id { get; set; }
        public String Name { get; set; }
       // public Employee Employee { get; set; }
       // public int EmployeeId { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set;}
       // public Client Client{ get; set; }

       // public int ClientId { get; set; }
       // public Budget Budget { get; set; }
       // public int BudgetId { get; set; }
        //public int CurrencyId { get; set; }
        public DateTime ContractSignDate { get; set; }
        public DateTime LcOppeningDate { get; set;}

       // public Solutions Solutions { get; set; }
       // public int SolutionsId { get; set; }
        public int NumberOfMilestones { get; set; }
        public ICollection<Milestone> Milestones { get; set; }
        public Project()
        {
            Milestones = new Collection<Milestone>();

        }



    }
}
