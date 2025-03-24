namespace DotNetCoreMyTeApp.Data
{
    public class MyTeModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Team { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Hours { get; set; }

        public List<string>? WorkType { get; set; }

        public string? UsersWorkType { get; set; }

        public List<string>? ProjectCodes { get; set; }

        public string? UsersProjectCode { get; set; }

        public List<string>? Descriptions { get; set; }

        public string? UsersDescription { get; set; }
    }
}