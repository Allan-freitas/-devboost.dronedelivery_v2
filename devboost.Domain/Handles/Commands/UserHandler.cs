using devboost.Domain.Handles.Commands.Interfaces;
using devboost.Domain.Model;
using devboost.Domain.Repository;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Commands
{
    public class UserHandler : IUserHandler
    {
        private readonly IUserRepository _userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Insert(User user)
        {
            await _userRepository.Insert(user);
        }
    }
}
