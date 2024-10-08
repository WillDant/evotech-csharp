using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;

namespace sprint_1.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedeCredenciadaController : ControllerBase
    {
        private readonly IRedeCredenciadaApplicationService _redeCredenciadaApplicationService;

        public RedeCredenciadaController(IRedeCredenciadaApplicationService redeCredenciadaApplicationService)
        {
            _redeCredenciadaApplicationService = redeCredenciadaApplicationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var redes = _redeCredenciadaApplicationService.ObterTodosRedeCredenciada();
            return redes is null ? NoContent() : Ok(redes);
        }

        [HttpGet("{id_empresa}")]
        public IActionResult ObterPorId(int id_empresa)
        {
            var rede = _redeCredenciadaApplicationService.ObterRedeCredenciadaPorId(id_empresa);
            return rede is null ? NoContent() : Ok(rede);
        }

        [HttpPost]
        public IActionResult Post([FromBody] RedeCredenciadaDto entity)
        {
            var rede = _redeCredenciadaApplicationService.SalvarDadosRedeCredenciada(entity);
            return Ok(rede);
        }

        [HttpPut("{id_empresa}")]
        public IActionResult Put(int id_empresa, [FromBody] RedeCredenciadaDto entity)
        {
            var rede = _redeCredenciadaApplicationService.EditarDadosRedeCredenciada(id_empresa, entity);
            return Ok(rede);
        }

        [HttpDelete("{id_empresa}")]
        public IActionResult Delete(int id_empresa)
        {
            var rede = _redeCredenciadaApplicationService.DeletarDadosRedeCredenciada(id_empresa);
            return Ok(rede);
        }
    }
}