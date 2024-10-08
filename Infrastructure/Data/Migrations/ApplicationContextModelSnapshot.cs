﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using sprint_1.Infrastructure.Data.AppData;

#nullable disable

namespace sprint_1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("sprint_1.Domain.Entities.ClienteEntity", b =>
                {
                    b.Property<int>("id_clie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_clie"));

                    b.Property<DateTime>("dt_cadastro")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("dt_nasc")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("nm_clie")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_clie");

                    b.ToTable("tb_cliente");
                });

            modelBuilder.Entity("sprint_1.Domain.Entities.EnderecoEntity", b =>
                {
                    b.Property<string>("id_end")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("compl_end")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("logradouro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("num_end")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("uf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_end");

                    b.ToTable("tb_endereco");
                });

            modelBuilder.Entity("sprint_1.Domain.Entities.ProcedimentoEntity", b =>
                {
                    b.Property<string>("id_proc")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("complexidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<float>("custo_medio")
                        .HasColumnType("BINARY_FLOAT");

                    b.Property<string>("nm_proc")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("tp_proc")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_proc");

                    b.ToTable("tb_procedimento");
                });

            modelBuilder.Entity("sprint_1.Domain.Entities.RedeCredenciadaEntity", b =>
                {
                    b.Property<string>("id_empresa")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("dt_cadastro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("especialidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("nm_empresa")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_empresa");

                    b.ToTable("tb_rede_credenciada");
                });
#pragma warning restore 612, 618
        }
    }
}
