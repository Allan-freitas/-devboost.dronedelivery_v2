using devboost.Domain.Model;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Commands.Interfaces
{
    public interface IUserHandler
    {
        Task Insert(User user);
    }
}
