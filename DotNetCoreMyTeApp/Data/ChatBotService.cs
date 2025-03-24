namespace DotNetCoreMyTeApp.Data
{
    public class ChatBotService
    {
        public Task<ChatBotModel> GetChatBotResponse(ChatBotModel aModel)
        {
            var response = new ChatBotModel
            {
                Request = aModel.Request,
                Response = $"You said: '{aModel.Request}'"
            };

            return Task.FromResult(response);
        }
    }
}