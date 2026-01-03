namespace JobTracker.API.DTOs
{
    public class JobApplicationDto
    {
        public string JobTitle { get; set; } = null!;
        public string Company { get; set; } = null!;
        public DateTime AppliedOn { get; set; }
        public string Status { get; set; } = "Pending"; 
        public int UserId { get; set; }
    }
}
