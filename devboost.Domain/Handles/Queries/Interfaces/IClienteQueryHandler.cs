using devboost.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Queries.Interfaces
{
    public interface IClienteQueryHandler
    {
        Task<Cliente> GetClienteByUserName(string username);

        Task<List<Cliente>> GetAll();
    }
}
