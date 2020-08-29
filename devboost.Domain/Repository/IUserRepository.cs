using devboost.Domain.Model;
using System.Threading.Tasks;

namespace devboost.Domain.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUser(string userName);

        Task Insert(User user);
    }    
}
