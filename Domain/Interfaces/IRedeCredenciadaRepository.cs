using sprint_1.Domain.Entities;

namespace sprint_1.Domain.Interfaces
{
    public interface IRedeCredenciadaRepository
    {
        IEnumerable<RedeCredenciadaEntity>? ObterTodos();
        RedeCredenciadaEntity? ObterPorId(int id_empresa);
        RedeCredenciadaEntity? SalvarDados(RedeCredenciadaEntity entity);
        RedeCredenciadaEntity? EditarDados(RedeCredenciadaEntity entity);
        RedeCredenciadaEntity? DeletarDados(int id_empresa);
    }
}
