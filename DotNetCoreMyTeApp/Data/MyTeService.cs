namespace DotNetCoreMyTeApp.Data
{
    public class MyTeService
    {
        public Task<MyTeModel> GetMyTeDataByUserForInput(string aUser)
        {
            MyTeModel response = new MyTeModel
            {
                Date = DateTime.Now,
                Name = "Charles",
                Email = "Charles.Smith.Fake@gmail.com",
                Team = "Development",
                WorkTypes = new List<string> { "Maintenance", "Capcity" },
                ProjectCodes = new List<string> { "Project1", "Project2", "Project3", "Project4" },
                Descriptions = new List<string> { "Coding", "Testing", "Deploying" }
            };
            return Task.FromResult(response);
        }
    }
}