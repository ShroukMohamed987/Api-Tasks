namespace Lab2.DAL.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<Develpoer> develpoers { get; set; } = new HashSet<Develpoer>();

    }
}
