using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sprint_1.Migrations
{
    /// <inheritdoc />
    public partial class intitdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    id_clie = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_clie = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dt_nasc = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    genero = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dt_cadastro = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cliente", x => x.id_clie);
                });

            migrationBuilder.CreateTable(
                name: "tb_endereco",
                columns: table => new
                {
                    id_end = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    cep = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    logradouro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    num_end = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    compl_end = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    bairro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    uf = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_endereco", x => x.id_end);
                });

            migrationBuilder.CreateTable(
                name: "tb_procedimento",
                columns: table => new
                {
                    id_proc = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    nm_proc = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    tp_proc = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    custo_medio = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    complexidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_procedimento", x => x.id_proc);
                });

            migrationBuilder.CreateTable(
                name: "tb_rede_credenciada",
                columns: table => new
                {
                    id_empresa = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    cnpj = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dt_cadastro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    nm_empresa = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    especialidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rede_credenciada", x => x.id_empresa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_cliente");

            migrationBuilder.DropTable(
                name: "tb_endereco");

            migrationBuilder.DropTable(
                name: "tb_procedimento");

            migrationBuilder.DropTable(
                name: "tb_rede_credenciada");
        }
    }
}
