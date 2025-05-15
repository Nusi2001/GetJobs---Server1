namespace GetJobsBackend.DTO
{
    public class JobApplicationDTO
    {
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public int JobId { get; set; }
    }
}
