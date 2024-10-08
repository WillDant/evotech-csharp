using System.ComponentModel.DataAnnotations;

namespace sprint_1.Application.Dtos
{
    public class RedeCredenciadaDto
    {
        [Required(ErrorMessage = "Campo ID da Empresa é obrigatório.")]
        public string id_empresa { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo CNPJ é obrigatório.")]
        [RegularExpression(@"\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}", ErrorMessage = "CNPJ deve estar no formato XX.XXX.XXX/XXXX-XX.")]
        public string Cnpj { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Data de Cadastro é obrigatório.")]
        public string dt_cadastro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Nome da Empresa é obrigatório.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "O campo Nome da Empresa deve ter entre 3 e 150 caracteres.")]
        public string nm_empresa { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Especialidade é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Especialidade deve ter no máximo 100 caracteres.")]
        public string epecialidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O campo Telefone deve ter no máximo 15 caracteres.")]
        public string telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O Email não é válido.")]
        public string email { get; set; } = string.Empty;
    }
}