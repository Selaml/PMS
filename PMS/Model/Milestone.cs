using System.Collections.ObjectModel;

namespace PMS.Model
{
    public class Milestone
    {
        public int Id { get; set; }
        public string Title { get; set; }
      //  public Project Project { get; set; }
       // public int ProjectId { get; set; }

        public ICollection<Tasks> Tasks { get; set; }
        public Milestone()
        {
            Tasks = new Collection<Tasks>();

        }
    }
}
