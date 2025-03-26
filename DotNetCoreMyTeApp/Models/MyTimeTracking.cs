namespace DotNetCoreMyTeApp.Models
{
    public class MyTimeTracking
    {
        public int Id { get; set; } // This serves as the primary key
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? UserWorkType { get; set; }
        public string? UserDescription { get; set; }
        public string? UserProjectCode { get; set; }
        public decimal? UserHours { get; set; }
        public DateTime? UserRecordedDate { get; set; }
    }
}
