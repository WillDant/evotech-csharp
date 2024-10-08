using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;
using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;

namespace sprint_1.Application.Services
{
    public class ProcedimentoApplicationService : IProcedimentoApplicationService
    {
        private readonly IProcedimentoRepository _procedimentoRepository;

        public ProcedimentoApplicationService(IProcedimentoRepository procedimentoRepository)
        {
            _procedimentoRepository = procedimentoRepository;
        }

        public ProcedimentoEntity? DeletarDadosProcedimento(int id_proc)
        {
            return _procedimentoRepository.DeletarDados(id_proc);
        }

        public ProcedimentoEntity? EditarDadosProcedimento(int id_proc, ProcedimentoDto entity)
        {
            var procedimento = new ProcedimentoEntity
            {
                id_proc = id_proc,
                nm_proc = entity.nm_proc,
                tp_proc = entity.tp_proc,
                custo_medio = entity.custo_medio,
                complexidade = entity.complexidade
            };

            return _procedimentoRepository.EditarDados(procedimento);
        }

        public ProcedimentoEntity? ObterProcedimentoPorId(int id_proc)
        {
            return _procedimentoRepository.ObterPorId(id_proc);
        }

        public IEnumerable<ProcedimentoEntity>? ObterTodosProcedimento()
        {
            return _procedimentoRepository.ObterTodos();
        }

        public ProcedimentoEntity? SalvarDadosProcedimento(ProcedimentoDto entity)
        {
            var procedimento = new ProcedimentoEntity
            {
                nm_proc = entity.nm_proc,
                tp_proc = entity.tp_proc,
                custo_medio = entity.custo_medio,
                complexidade = entity.complexidade
            };

            return _procedimentoRepository.SalvarDados(procedimento);
        }
    }
}

