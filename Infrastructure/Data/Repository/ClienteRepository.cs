using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;
using sprint_1.Infrastructure.Data.AppData;

namespace sprint_1.Infrastructure.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationContext _context;

        public ClienteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public ClienteEntity? DeletarDados(int id_clie)
        {
            try
            {
                var cliente = _context.Cliente.Find(id_clie);

                if (cliente is not null)
                {
                    _context.Remove(cliente);
                    _context.SaveChanges();

                    return cliente;
                }

                throw new Exception("Não foi possível localizar o cliente.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public ClienteEntity? EditarDados(ClienteEntity entity)
        {
            try
            {
                var cliente = _context.Cliente.Find(entity.id_clie);

                if (cliente is not null)
                {
                    cliente.nm_clie = entity.nm_clie;
                    cliente.dt_nasc = entity.dt_nasc;
                    cliente.genero = entity.genero;
                    cliente.endereco = entity.endereco;
                    cliente.telefone = entity.telefone;
                    cliente.email = entity.email;
                    cliente.dt_cadastro = entity.dt_cadastro;
                    cliente.senha = entity.senha;

                    _context.Update(cliente);
                    _context.SaveChanges();

                    return cliente;
                }

                throw new Exception("Não foi possível localizar o cliente.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public ClienteEntity? ObterPorId(int id_clie)
        {
            var cliente = _context.Cliente.Find(id_clie);
            return cliente;
        }

        public IEnumerable<ClienteEntity>? ObterTodos()
        {
            var clientes = _context.Cliente.ToList();
            return clientes.Any() ? clientes : null;
        }

        public ClienteEntity? SalvarDados(ClienteEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar o cliente.");
            }
        }
    }
}