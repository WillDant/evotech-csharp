using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;

namespace sprint_1.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoApplicationService _enderecoApplicationService;

        public EnderecoController(IEnderecoApplicationService enderecoApplicationService)
        {
            _enderecoApplicationService = enderecoApplicationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var enderecos = _enderecoApplicationService.ObterTodosEnderecos();
            return enderecos is null ? NoContent() : Ok(enderecos);
        }

        [HttpGet("{id_end}")]
        public IActionResult ObterPorId(int id_end)
        {
            var endereco = _enderecoApplicationService.ObterEnderecoPorId(id_end);
            return endereco is null ? NoContent() : Ok(endereco);
        }

        [HttpPost]
        public IActionResult Post([FromBody] EnderecoDto entity)
        {
            var endereco = _enderecoApplicationService.SalvarDadosEndereco(entity);
            return Ok(endereco);
        }

        [HttpPut("{id_end}")]
        public IActionResult Put(int id_end, [FromBody] EnderecoDto entity)
        {
            var endereco = _enderecoApplicationService.EditarDadosEndereco(id_end, entity);
            return Ok(endereco);
        }

        [HttpDelete("{id_end}")]
        public IActionResult Delete(int id_end)
        {
            var endereco = _enderecoApplicationService.DeletarDadosEndereco(id_end);
            return Ok(endereco);
        }
    }
}
