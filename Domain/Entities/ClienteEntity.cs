using System.Globalization;

namespace sprint_1.Domain.Entities
{
    public class ClienteEntity
    {
        public int id_clie { get; set; }
        public string nm_clie { get; set; }
        public DateTime dt_nasc { get; set; }
        public string genero { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public DateTime dt_cadastro { get; set; }
        public string senha { get; set; }

    }
}
