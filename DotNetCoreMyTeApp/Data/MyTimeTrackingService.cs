namespace DotNetCoreMyTeApp.Data
{
    public class MyTimeTrackingService
    {
        public Task<MyTimeTracking> GetMyTeDataByUserForInput(string aUser)
        {
            MyTimeTracking response = new MyTimeTracking
            {
                UserRecordedDate = DateTime.Now,
                Name = "Charles",
                Email = "Charles.Smith.Fake@gmail.com",
                Team = "Development",
                UserID = "charles01",
                WorkTypes = new List<string> { "Maintenance", "Capcity" },
                ProjectCodes = new List<string> { "Project1", "Project2", "Project3", "Project4" },
                Descriptions = new List<string> { "Coding", "Testing", "Deploying" }
            };
            return Task.FromResult(response);
        }
    }
}