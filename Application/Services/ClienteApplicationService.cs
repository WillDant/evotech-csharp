using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;
using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;

namespace sprint_1.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteApplicationService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ClienteEntity? DeletarDadosCliente(int id_clie)
        {
            return _clienteRepository.DeletarDados(id_clie);
        }

        public ClienteEntity? EditarDadosCliente(int id_clie, ClienteDto entity)
        {
            var cliente = new ClienteEntity
            {
                id_clie = id_clie,
                nm_clie = entity.nome_clie,
                dt_nasc = entity.dt_nasc,
                genero = entity.genero,
                endereco = entity.endereco,
                telefone = entity.Telefone,
                email = entity.email,
                dt_cadastro = entity.dt_cadastro,
                senha = entity.senha
            };

            return _clienteRepository.EditarDados(cliente);
        }

        public ClienteEntity? ObterClientePorId(int id_clie)
        {
            return _clienteRepository.ObterPorId(id_clie);
        }

        public IEnumerable<ClienteEntity>? ObterTodosCliente()
        {
            return _clienteRepository.ObterTodos();
        }

        public ClienteEntity? SalvarDadosCliente(ClienteDto entity)
        {
            var cliente = new ClienteEntity
            {
                nm_clie = entity.nome_clie,
                dt_nasc = entity.dt_nasc,
                genero = entity.genero,
                endereco = entity.endereco,
                telefone = entity.Telefone,
                email = entity.email,
                dt_cadastro = entity.dt_cadastro,
                senha = entity.senha
            };

            return _clienteRepository.SalvarDados(cliente);
        }
    }
}
