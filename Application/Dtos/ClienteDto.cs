using System.ComponentModel.DataAnnotations;

namespace sprint_1.Application.Dtos
{
    public class ClienteDto
    {
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "O campo Nome deve ter no mínimo 5 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Data de Nascimento é obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Gênero é obrigatório.")]
        [StringLength(20, ErrorMessage = "O campo Gênero deve ter no máximo 20 caracteres.")]
        public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Endereço é obrigatório.")]
        public string Endereco { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O campo Telefone deve ter no máximo 15 caracteres.")]
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O Email não é válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Data de Cadastro é obrigatório.")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo Senha é obrigatório.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "O campo Senha deve ter no mínimo 6 caracteres.")]
        public string Senha { get; set; } = string.Empty;
    }
}
