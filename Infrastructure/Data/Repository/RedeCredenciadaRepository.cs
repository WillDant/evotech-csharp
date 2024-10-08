using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;
using sprint_1.Infrastructure.Data.AppData;
using Microsoft.EntityFrameworkCore;

namespace sprint_1.Infrastructure.Data.Repository
{
    public class RedeCredenciadaRepository : IRedeCredenciadaRepository
    {
        private readonly ApplicationContext _context;

        public RedeCredenciadaRepository(ApplicationContext context)
        {
            _context = context;
        }

        public RedeCredenciadaEntity? DeletarDados(int id_empresa)
        {
            try
            {
                var empresa = _context.RedeCredenciada.Find(id_empresa);

                if (empresa is not null)
                {
                    _context.Remove(empresa);
                    _context.SaveChanges();

                    return empresa;
                }

                throw new Exception("Não foi possível localizar a empresa.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public RedeCredenciadaEntity? EditarDados(RedeCredenciadaEntity entity)
        {
            try
            {
                var empresa = _context.RedeCredenciada.Find(entity.id_empresa);

                if (empresa is not null)
                {
                    empresa.cnpj = entity.cnpj;
                    empresa.dt_cadastro = entity.dt_cadastro;
                    empresa.nm_empresa = entity.nm_empresa;
                    empresa.especialidade = entity.especialidade;
                    empresa.telefone = entity.telefone;
                    empresa.email = entity.email;

                    _context.Update(empresa);
                    _context.SaveChanges();

                    return empresa;
                }

                throw new Exception("Não foi possível localizar a empresa.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public RedeCredenciadaEntity? ObterPorId(int id_empresa)
        {
            var empresa = _context.RedeCredenciada.Find(id_empresa);

            return empresa;
        }

        public IEnumerable<RedeCredenciadaEntity>? ObterTodos()
        {
            var empresas = _context.RedeCredenciada.ToList();

            return empresas.Any() ? empresas : null;
        }

        public RedeCredenciadaEntity? SalvarDados(RedeCredenciadaEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar a empresa.");
            }
        }
    }
}
