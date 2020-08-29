using devboost.Domain.Handles.Commands.Interfaces;
using devboost.Domain.Handles.Commands.Request;
using devboost.Domain.Model;
using devboost.Domain.Repository;
using System;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Commands
{
    public class ClienteHandler : IClienteHandler
    {
        readonly IClienteRepository _clienteRepository;
        readonly IUserRepository _userRepository;

        public ClienteHandler(IClienteRepository clienteRepository, IUserRepository userRepository)
        {
            _clienteRepository = clienteRepository;
            _userRepository = userRepository;
        }

        public async Task AddClienteAsync(ClienteRequest cliente, string userName)
        {
            var user = await _userRepository.GetUser(userName);

            if (user == null)
                throw new Exception("Não foi possível encontrar o usuário.");
            Cliente c = new Cliente(cliente.Nome, cliente.Email, cliente.Latitude, cliente.Longitude, cliente.Endereco)
            {
                User = user
            };
            if (!c.IsValid())
                throw new Exception("Dados do cliente inválido, os campos: Nome, Endereço, Latitude e Longitude são obrigatórios.");
            await _clienteRepository.AddAsync(c);
        }
    }
}
