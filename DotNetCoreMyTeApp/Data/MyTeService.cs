namespace DotNetCoreMyTeApp.Data
{
    public class MyTeService
    {
        public Task<MyTeModel> GetMyTeModel(MyTeModel aModel)
        {
            var response = new MyTeModel
            {
                Name = aModel.Name,
                Description = $"You said: '{aModel.Description}'"
            };

            return Task.FromResult(response);
        }
    }
}