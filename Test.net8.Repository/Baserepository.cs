using System.Text.Json.Serialization;
using Test.net8.Model;
using Newtonsoft.Json;

namespace Test.net8.Repository
{
    public class Baserepository : IUserRepository
    {
        async Task<List<User>> IUserRepository.Query()
        {
            await Task.CompletedTask;
            var data = "[{\"Id\":18,\"Name\":\"namename\"}]";
            return JsonConvert.DeserializeObject<List<User>>(data)
                ?? new List<User>();
            //模拟一个动作
            //throw new NotImplementedException();
        }
    }
}
