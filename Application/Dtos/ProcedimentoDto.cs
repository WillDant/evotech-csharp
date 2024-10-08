using System.ComponentModel.DataAnnotations;

namespace sprint_1.Application.Dtos
{
    public class ProcedimentoDto
    {
        [Required(ErrorMessage = "Campo ID do Procedimento é obrigatório.")]
        public string id_proc { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Nome do Procedimento é obrigatório.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "O campo Nome do Procedimento deve ter entre 3 e 150 caracteres.")]
        public string nm_proc { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Tipo do Procedimento é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Tipo do Procedimento deve ter no máximo 50 caracteres.")]
        public string tp_proc { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Custo Médio é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O Custo Médio deve ser um valor positivo.")]
        public float custo_medio { get; set; }

        [Required(ErrorMessage = "Campo Complexidade é obrigatório.")]
        [StringLength(20, ErrorMessage = "O campo Complexidade deve ter no máximo 20 caracteres.")]
        public string complexidade { get; set; } = string.Empty;
    }
}