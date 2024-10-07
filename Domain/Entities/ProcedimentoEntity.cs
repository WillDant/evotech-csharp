using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace sprint_1.Domain.Entities
{
    [Table("tb_procedimento")]
    public class ProcedimentoEntity
    {
        [Key]
        public string id_proc { get; set; }
        public string nm_proc  { get; set; }
        public  string tp_proc { get; set; }
        public float custo_medio { get; set; }
        public string complexidade { get; set; }

    }
}
