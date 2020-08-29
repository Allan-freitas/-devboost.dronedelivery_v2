using devboost.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace devboost.Domain.Repository
{
    public interface IClienteRepository
    {
        Task<Cliente> GetClienteByUserName(string username);

        Task AddAsync(Cliente cliente);

        Task<List<Cliente>> GetAll();
    }
}
