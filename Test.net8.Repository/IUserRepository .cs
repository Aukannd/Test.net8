using Test.net8.Model;

namespace Test.net8.Repository
{
    public interface IUserRepository
    {
         Task<List<User>> Query();
    }

}
