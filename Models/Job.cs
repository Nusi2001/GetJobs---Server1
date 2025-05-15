namespace Server.Models
{
    public class Job
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Domain { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public decimal Salary { get; set; }

    }
}