using Test.net8.IService;
using Test.net8.Model;

namespace Test.net8.Service
{
    //依赖项有哪些
    public class UserService : IUserService
    {
         async Task<List<User>> IUserService.Query()
        {
            throw new NotImplementedException();
        }
    }
}
