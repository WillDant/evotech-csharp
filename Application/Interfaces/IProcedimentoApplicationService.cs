using sprint_1.Application.Dtos;
using sprint_1.Domain.Entities;

namespace sprint_1.Application.Interfaces
{
    public interface IProcedimentoApplicationService
    {
        IEnumerable<ProcedimentoEntity>? ObterTodosProcedimento();
        ProcedimentoEntity? ObterProcedimentoPorId(int id_proc);
        ProcedimentoEntity? SalvarDadosProcedimento(ProcedimentoDto entity);
        ProcedimentoEntity? EditarDadosProcedimento(int id_proc, ProcedimentoDto entity);
        ProcedimentoEntity? DeletarDadosProcedimento(int id_proc);
    }
}
