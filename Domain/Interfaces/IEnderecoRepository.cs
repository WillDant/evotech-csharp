using sprint_1.Domain.Entities;

namespace sprint_1.Domain.Interfaces
{
    public interface IEnderecoRepository
    {
        IEnumerable<EnderecoEntity>? ObterTodos();
        EnderecoEntity? ObterPorId(int id_end);
        EnderecoEntity? SalvarDados(EnderecoEntity entity);
        EnderecoEntity? EditarDados(EnderecoEntity entity);
        EnderecoEntity? DeletarDados(int id_end);
    }
}