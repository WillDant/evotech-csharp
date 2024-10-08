using sprint_1.Application.Dtos;
using sprint_1.Domain.Entities;

namespace sprint_1.Application.Interfaces
{
    public interface IRedeCredenciadaApplicationService
    {
        IEnumerable<RedeCredenciadaEntity>? ObterTodosRedeCredenciada();
        RedeCredenciadaEntity? ObterRedeCredenciadaPorId(int id_empresa);
        RedeCredenciadaEntity? SalvarDadosRedeCredenciada(RedeCredenciadaDto entity);
        RedeCredenciadaEntity? EditarDadosRedeCredenciada(int id_empresa, RedeCredenciadaDto entity);
        RedeCredenciadaEntity? DeletarDadosRedeCredenciada(int id_empresa);
    }
}
