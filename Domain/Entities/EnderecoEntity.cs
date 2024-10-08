using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace sprint_1.Domain.Entities
{
    [Table("tb_endereco")]
    public class EnderecoEntity
    {
        [Key]
        public int id_end { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string num_end { get; set; }
        public string compl_end { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

    }
}
