using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace sprint_1.Domain.Entities
{
    [Table("tb_rede_credenciada")]
    public class RedeCredenciadaEntity
    {
        [Key]
        public string id_empresa { get; set; }
        public string cnpj { get; set; }
        public string dt_cadastro { get; set; }
        public string nm_empresa { get; set; }
        public string especialidade { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
