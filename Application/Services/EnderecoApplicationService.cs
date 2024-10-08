using sprint_1.Application.Dtos;
using sprint_1.Application.Interfaces;
using sprint_1.Domain.Entities;
using sprint_1.Domain.Interfaces;

namespace sprint_1.Application.Services
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoApplicationService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public EnderecoEntity? DeletarDadosEndereco(int id_end)
        {
            return _enderecoRepository.DeletarDados(id_end);
        }

        public EnderecoEntity? EditarDadosEndereco(int id_end, EnderecoDto entity)
        {
            var endereco = new EnderecoEntity
            {
                id_end = id_end,
                cep = entity.cep,
                logradouro = entity.logradouro,
                num_end = entity.num_end,
                compl_end = entity.compl_end,
                bairro = entity.bairro,
                cidade = entity.cidade,
                uf = entity.uf
            };

            return _enderecoRepository.EditarDados(endereco);
        }

        public EnderecoEntity? ObterEnderecoPorId(int id_end)
        {
            return _enderecoRepository.ObterPorId(id_end);
        }

        public IEnumerable<EnderecoEntity>? ObterTodosEnderecos()
        {
            return _enderecoRepository.ObterTodos();
        }

        public EnderecoEntity? SalvarDadosEndereco(EnderecoDto entity)
        {
            var endereco = new EnderecoEntity
            {
                cep = entity.cep,
                logradouro = entity.logradouro,
                num_end = entity.num_end,
                compl_end = entity.compl_end,
                bairro = entity.bairro,
                cidade = entity.cidade,
                uf = entity.uf
            };

            return _enderecoRepository.SalvarDados(endereco);
        }
    }
}