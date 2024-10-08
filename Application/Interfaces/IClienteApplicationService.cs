using sprint_1.Application.Dtos;
using sprint_1.Domain.Entities;

namespace sprint_1.Application.Interfaces
{
    public interface IClienteApplicationService
    {
        IEnumerable<ClienteEntity>? ObterTodosCliente();
        ClienteEntity? ObterClientePorId(int id_clie);
        ClienteEntity? SalvarDadosCliente(ClienteDto entity);
        ClienteEntity? EditarDadosCliente(int id_clie, ClienteDto entity);
        ClienteEntity? DeletarDadosCliente(int id_clie);
    }
}