using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;
using sprint_1.Infrastructure.Data.AppData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sprint_1.Infrastructure.Data.Repository
{
    public class ProcedimentoRepository : IProcedimentoRepository
    {
        private readonly ApplicationContext _context;

        public ProcedimentoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<ProcedimentoEntity>? ObterTodos()
        {
            var procedimentos = _context.Procedimento.ToList();
            return procedimentos.Any() ? procedimentos : null;
        }

        public ProcedimentoEntity? ObterPorId(int id_proc)
        {
            var procedimento = _context.Procedimento.Find(id_proc);
            return procedimento;
        }

        public ProcedimentoEntity? SalvarDados(ProcedimentoEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar o procedimento.");
            }
        }

        public ProcedimentoEntity? EditarDados(ProcedimentoEntity entity)
        {
            try
            {
                var procedimento = _context.Procedimento.Find(entity.id_proc);

                if (procedimento is not null)
                {
                    procedimento.nm_proc = entity.nm_proc;
                    procedimento.tp_proc = entity.tp_proc;
                    procedimento.custo_medio = entity.custo_medio;
                    procedimento.complexidade = entity.complexidade;

                    _context.Update(procedimento);
                    _context.SaveChanges();

                    return procedimento;
                }

                throw new Exception("Não foi possível localizar o procedimento.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public ProcedimentoEntity? DeletarDados(int id_proc)
        {
            try
            {
                var procedimento = _context.Procedimento.Find(id_proc);

                if (procedimento is not null)
                {
                    _context.Remove(procedimento);
                    _context.SaveChanges();

                    return procedimento;
                }

                throw new Exception("Não foi possível localizar o procedimento.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
