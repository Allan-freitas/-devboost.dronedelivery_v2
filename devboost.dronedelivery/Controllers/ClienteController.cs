using devboost.Domain.Handles.Commands.Interfaces;
using devboost.Domain.Handles.Commands.Request;
using devboost.Domain.Handles.Queries.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace devboost.dronedelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        readonly IClienteQueryHandler _clienteQueryHandler;
        readonly IClienteHandler _clienteHandler;

        public ClienteController(IClienteQueryHandler clienteQueryHandler, IClienteHandler clienteHandler)
        {
            _clienteQueryHandler = clienteQueryHandler;
            _clienteHandler = clienteHandler;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _clienteQueryHandler.GetAll();
            return Ok(result);
        }

        [HttpPost("adicionarcliente")]
        public async Task<ActionResult> AdicionarCliente([FromBody] ClienteRequest clienteRequest)
        {
            try
            {
                var userName = User.Identity.Name;
                await _clienteHandler.AddClienteAsync(clienteRequest, userName);
                return Ok("Cliente cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
