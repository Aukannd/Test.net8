using Test.net8.Model;

namespace Test.net8.IService
{
    public interface IUserService
    {
        public Task<List<User>> Query();
    }
}
