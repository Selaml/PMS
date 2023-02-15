using System.Collections.ObjectModel;

namespace PMS.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PlannedStart { get; set; }
        public DateTime PlannedFinish { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualFinish { get; set; }
        public int Completion { get; set; }
        public string ScheduleHealth { get; set; }
       // public Milestone? Milestone { get; set; }
        public int MilestoneId { get; set; }
        public ICollection<SubTask> SubTasks { get; set; }
        public Tasks()
        {
            SubTasks = new Collection<SubTask>();

        }


    }
}
