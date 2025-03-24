namespace DotNetCoreMyTeApp.Data
{
    public class MyTimeTracking
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Team { get; set; }
        public DateTime? UserRecordedDate { get; set; }
        public decimal? UserHours { get; set; }

        public List<string>? WorkTypes { get; set; }

        public string? UserWorkType { get; set; }

        public List<string>? ProjectCodes { get; set; }

        public string? UserProjectCode { get; set; }

        public List<string>? Descriptions { get; set; }

        public string? UserDescription { get; set; }
    }
}