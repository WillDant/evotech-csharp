
using Microsoft.EntityFrameworkCore;
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

            // Conexão com o banco de dados Oracle
            builder.Services.AddDbContext<ApplicationContext>(options => {
                
                options.UseOracle("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))) (CONNECT_DATA=(SERVER=DEDICATED)(SID=ORCL)));User Id=<rm552671>;Password=<051204>;");
        });
            //Configurando Repositório Cliente no asp.net injeção de dependência
            builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
