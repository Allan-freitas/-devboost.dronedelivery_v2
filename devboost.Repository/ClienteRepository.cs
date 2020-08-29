using devboost.Domain.Model;
using devboost.Domain.Repository;
using devboost.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace devboost.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _dataContext.Cliente.AddAsync(cliente);
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _dataContext.Cliente.ToListAsync();
        }

        public async Task<Cliente> GetClienteByUserName(string username)
        {
            return await _dataContext.Cliente.FirstOrDefaultAsync(c => c.User.UserName.Equals(username));
        }
    }
}
