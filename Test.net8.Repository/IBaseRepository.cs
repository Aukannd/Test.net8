using Test.net8.Model;

namespace Test.net8.Repository
{
    public interface IBaserepository
    {
         Task<List<User>> Query();
    }

}
