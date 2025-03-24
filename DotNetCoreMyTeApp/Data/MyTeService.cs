namespace DotNetCoreMyTeApp.Data
{
    public class MyTeService
    {
        public Task<List<MyTeModel>> GetMyTeDataByUser(MyTeModel aModel)
        {
            List<MyTeModel> response = new List<MyTeModel>
            {
                new MyTeModel
                {
                    Date = aModel.Date,
                    Hours = aModel.Hours,
                    WorkType = aModel.WorkType,
                    ProjectCode = aModel.ProjectCode,
                    Description = $"You said: '{aModel.Description}'"
                }
            };
            return Task.FromResult(response);
        }
    }
}