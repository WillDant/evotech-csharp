using Microsoft.EntityFrameworkCore;
using sprint_1.Domain.Entities;

namespace sprint_1.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<EnderecoEntity> Endereco { get; set; }
        public DbSet<ProcedimentoEntity> Procedimento { get; set; }
        public DbSet<RedeCredenciadaEntity> RedeCredenciada { get; set; }
    }
}
