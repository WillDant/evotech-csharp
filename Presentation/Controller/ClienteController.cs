using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;

namespace sprint_1.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteApplicationService _clienteApplicationService;

        public ClienteController(IClienteApplicationService clienteApplicationService)
        {
            _clienteApplicationService = clienteApplicationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _clienteApplicationService.ObterTodosCliente();
            return clientes is null ? NoContent() : Ok(clientes);
        }

        [HttpGet("{id_clie}")]
        public IActionResult ObterPorId(int id_clie)
        {
            var cliente = _clienteApplicationService.ObterClientePorId(id_clie);
            return cliente is null ? NoContent() : Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteDto entity)
        {
            var cliente = _clienteApplicationService.SalvarDadosCliente(entity);
            return Ok(cliente);
        }

        [HttpPut("{id_clie}")]
        public IActionResult Put(int id_clie, [FromBody] ClienteDto entity)
        {
            var cliente = _clienteApplicationService.EditarDadosCliente(id_clie, entity);
            return Ok(cliente);
        }

        [HttpDelete("{id_clie}")]
        public IActionResult Delete(int id_clie)
        {
            var cliente = _clienteApplicationService.DeletarDadosCliente(id_clie);
            return Ok(cliente);
        }
    }
}
