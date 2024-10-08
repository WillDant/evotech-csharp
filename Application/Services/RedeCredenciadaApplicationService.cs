using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;
using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;

namespace sprint_1.Application.Services
{
    public class RedeCredenciadaApplicationService : IRedeCredenciadaApplicationService
    {
        private readonly IRedeCredenciadaRepository _redeCredenciadaRepository;

        public RedeCredenciadaApplicationService(IRedeCredenciadaRepository redeCredenciadaRepository)
        {
            _redeCredenciadaRepository = redeCredenciadaRepository;
        }

        public RedeCredenciadaEntity? DeletarDadosRedeCredenciada(int id_empresa)
        {
            return _redeCredenciadaRepository.DeletarDados(id_empresa);
        }

        public RedeCredenciadaEntity? EditarDadosRedeCredenciada(int id_empresa, RedeCredenciadaDto entity)
        {
            var redeCredenciada = new RedeCredenciadaEntity
            {
                id_empresa = id_empresa,
                cnpj = entity.Cnpj,
                dt_cadastro = entity.dt_cadastro,
                nm_empresa = entity.nm_empresa,
                especialidade = entity.especialidade,
                telefone = entity.telefone,
                email = entity.email
            };

            return _redeCredenciadaRepository.EditarDados(redeCredenciada);
        }

        public RedeCredenciadaEntity? ObterRedeCredenciadaPorId(int id_empresa)
        {
            return _redeCredenciadaRepository.ObterPorId(id_empresa);
        }

        public IEnumerable<RedeCredenciadaEntity>? ObterTodosRedeCredenciada()
        {
            return _redeCredenciadaRepository.ObterTodos();
        }

        public RedeCredenciadaEntity? SalvarDadosRedeCredenciada(RedeCredenciadaDto entity)
        {
            var redeCredenciada = new RedeCredenciadaEntity
            {
                id_empresa = entity.id_empresa,
                cnpj = entity.Cnpj,
                dt_cadastro = entity.dt_cadastro,
                nm_empresa = entity.nm_empresa,
                especialidade = entity.especialidade,
                telefone = entity.telefone,
                email = entity.email
            };

            return _redeCredenciadaRepository.SalvarDados(redeCredenciada);
        }
    }
}
