using devboost.Domain.Handles.Commands.Request;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Commands.Interfaces
{
    public interface IClienteHandler
    {
        Task AddClienteAsync(ClienteRequest cliente, string userName);
    }
}
