using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;
using sprint_1.Infrastructure.Data.AppData;

namespace sprint_1.Infrastructure.Data.Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ApplicationContext _context;

        public EnderecoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public EnderecoEntity? DeletarDados(int id_end)
        {
            try
            {
                var endereco = _context.Endereco.Find(id_end);

                if (endereco is not null)
                {
                    _context.Remove(endereco);
                    _context.SaveChanges();

                    return endereco;
                }

                throw new Exception("Não foi possível localizar o endereço.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public EnderecoEntity? EditarDados(EnderecoEntity entity)
        {
            try
            {
                var endereco = _context.Endereco.Find(entity.id_end);

                if (endereco is not null)
                {
                    endereco.cep = entity.cep;
                    endereco.logradouro = entity.logradouro;
                    endereco.num_end = entity.num_end;
                    endereco.compl_end = entity.compl_end;
                    endereco.bairro = entity.bairro;
                    endereco.cidade = entity.cidade;
                    endereco.uf = entity.uf;

                    _context.Update(endereco);
                    _context.SaveChanges();

                    return endereco;
                }

                throw new Exception("Não foi possível localizar o endereço.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public IEnumerable<EnderecoEntity>? ObterTodos()
        {
            return _context.Endereco;
        }

        public EnderecoEntity? ObterPorId(int id_end)
        {
            return _context.Endereco.Find(id_end);
        }

        public EnderecoEntity? SalvarDados(EnderecoEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
}
