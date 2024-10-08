using System.ComponentModel.DataAnnotations;

namespace sprint_1.Application.Dtos
{
    public class EnderecoDto
    {
        [Required(ErrorMessage = "Campo CEP é obrigatório.")]
        [StringLength(10, ErrorMessage = "O campo CEP deve ter no máximo 10 caracteres.")]
        public string Cep { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Logradouro é obrigatório.")]
        [StringLength(150, ErrorMessage = "O campo Logradouro deve ter no máximo 150 caracteres.")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Número é obrigatório.")]
        [StringLength(10, ErrorMessage = "O campo Número deve ter no máximo 10 caracteres.")]
        public string Numero { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "O campo Complemento deve ter no máximo 100 caracteres.")]
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "Campo Bairro é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Bairro deve ter no máximo 100 caracteres.")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Cidade é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo UF é obrigatório.")]
        [StringLength(2, ErrorMessage = "O campo UF deve ter exatamente 2 caracteres.")]
        public string Uf { get; set; } = string.Empty;
    }
}