
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using sprint_1.Application.Interfaces;
using sprint_1.Application.Services;
using sprint_1.Domain.Interfaces;
using sprint_1.Infrastructure.Data.AppData;
using sprint_1.Infrastructure.Data.Repository;

namespace sprint_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Conex�o com o banco de dados Oracle
            builder.Services.AddDbContext<ApplicationContext>(options =>
            {

                options.UseOracle("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))) (CONNECT_DATA=(SERVER=DEDICATED)(SID=ORCL)));User Id=<rm552671>;Password=<051204>;");
            });
            //Configurando Reposit�rio Cliente no asp.net inje��o de depend�ncia
            builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

            //Configurando Reposit�rio Endereco no asp.net inje��o de depend�ncia
            builder.Services.AddTransient<IEnderecoRepository, EnderecoRepository>();

            //Configurando Reposit�rio Procedimento no asp.net inje��o de depend�ncia
            builder.Services.AddTransient<IProcedimentoRepository, ProcedimentoRepository>();

            // Configurando Reposit�rio RedeCredenciada no asp.net inje��o de depend�ncia
            builder.Services.AddTransient<IRedeCredenciadaRepository, RedeCredenciadaRepository>();

            //Adicionando a interface e classe concreta no framework de injec�o de dependencia
            builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
            builder.Services.AddTransient<IClienteApplicationService, ClienteApplicationService>();

            builder.Services.AddControllers();


            builder.Services.AddEndpointsApiExplorer();

            //Configurando e habilitando a documenta��o no swagger 
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Api Cliente",
                    Version = "v1",
                    Description = "API para cadastro de clientes"
                });
                c.EnableAnnotations(); // Habilitar anota��es no Swagger
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
