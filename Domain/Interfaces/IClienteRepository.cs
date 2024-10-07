using sprint_1.Domain.Entities;

namespace sprint_1.Domain.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteEntity>? ObterTodos();
        ClienteEntity? ObterPorId(int id_clie);
        ClienteEntity? SalvarDados(ClienteEntity entity);
        ClienteEntity? EditarDados(ClienteEntity entity);
        ClienteEntity? DeletarDados(int id_clie);
    }
}
