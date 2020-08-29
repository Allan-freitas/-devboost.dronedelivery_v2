using devboost.Domain.Handles.Queries.Interfaces;
using devboost.Domain.Model;
using devboost.Domain.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Queries
{
    public class ClienteQueryHandler : IClienteQueryHandler
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteQueryHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _clienteRepository.GetAll();
        }

        public async Task<Cliente> GetClienteByUserName(string username)
        {
            return await _clienteRepository.GetClienteByUserName(username);
        }
    }
}
