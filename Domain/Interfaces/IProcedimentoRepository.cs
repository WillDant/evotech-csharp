using sprint_1.Domain.Entities;

namespace sprint_1.Domain.Interfaces
{
    public interface IProcedimentoRepository
    {
        IEnumerable<ProcedimentoEntity>? ObterTodos();
        ProcedimentoEntity? ObterPorId(int id_proc);
        ProcedimentoEntity? SalvarDados(ProcedimentoEntity entity);
        ProcedimentoEntity? EditarDados(ProcedimentoEntity entity);
        ProcedimentoEntity? DeletarDados(int id_proc);
    }
}
