using sprint_1.Application.Dtos;
using sprint_1.Domain.Entities;

namespace sprint_1.Application.Interfaces
{
    public interface IEnderecoApplicationService
    {
        IEnumerable<EnderecoEntity>? ObterTodosEnderecos();
        EnderecoEntity? ObterEnderecoPorId(int id_end);
        EnderecoEntity? SalvarDadosEndereco(EnderecoDto entity);
        EnderecoEntity? EditarDadosEndereco(int id_end, EnderecoDto entity);
        EnderecoEntity? DeletarDadosEndereco(int id_end);
    }
}
