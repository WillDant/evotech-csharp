using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;

namespace sprint_1.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedimentoController : ControllerBase
    {
        private readonly IProcedimentoApplicationService _procedimentoApplicationService;

        public ProcedimentoController(IProcedimentoApplicationService procedimentoApplicationService)
        {
            _procedimentoApplicationService = procedimentoApplicationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var procedimentos = _procedimentoApplicationService.ObterTodosProcedimento();
            return procedimentos is null ? NoContent() : Ok(procedimentos);
        }

        [HttpGet("{id_proc}")]
        public IActionResult ObterPorId(int id_proc)
        {
            var procedimento = _procedimentoApplicationService.ObterProcedimentoPorId(id_proc);
            return procedimento is null ? NoContent() : Ok(procedimento);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProcedimentoDto entity)
        {
            var procedimento = _procedimentoApplicationService.SalvarDadosProcedimento(entity);
            return Ok(procedimento);
        }

        [HttpPut("{id_proc}")]
        public IActionResult Put(int id_proc, [FromBody] ProcedimentoDto entity)
        {
            var procedimento = _procedimentoApplicationService.EditarDadosProcedimento(id_proc, entity);
            return Ok(procedimento);
        }

        [HttpDelete("{id_proc}")]
        public IActionResult Delete(int id_proc)
        {
            var procedimento = _procedimentoApplicationService.DeletarDadosProcedimento(id_proc);
            return Ok(procedimento);
        }
    }
}