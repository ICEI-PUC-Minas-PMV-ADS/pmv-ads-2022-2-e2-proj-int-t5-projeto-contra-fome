﻿// <auto-generated />
using System;
using API_mySQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_mySQL.Migrations
{
    [DbContext(typeof(APIDbContext))]
    partial class APIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API_mySQL.Models.Cadastro", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CEP")
                        .HasColumnType("int")
                        .HasColumnName("CEP");

                    b.Property<int?>("CNPJ")
                        .HasColumnType("int")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext")
                        .HasColumnName("Cidade");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext")
                        .HasColumnName("Endereco");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext")
                        .HasColumnName("Estado");

                    b.Property<string>("Fundacao")
                        .HasColumnType("longtext")
                        .HasColumnName("Fundacao");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("longtext")
                        .HasColumnName("NomeFantasia");

                    b.Property<string>("Pais")
                        .HasColumnType("longtext")
                        .HasColumnName("Pais");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("longtext")
                        .HasColumnName("RazaoSocial");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext")
                        .HasColumnName("Senha");

                    b.Property<int?>("Telefone")
                        .HasColumnType("int")
                        .HasColumnName("Telefone");

                    b.HasKey("Codigo");

                    b.ToTable("cadastro");
                });

            modelBuilder.Entity("API_mySQL.Models.CadastroCampanha", b =>
                {
                    b.Property<int>("idCampanha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CadastroCodigo")
                        .HasColumnType("int");

                    b.Property<bool?>("CartaoDeCredito")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("CartaoDeCredito");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext")
                        .HasColumnName("Cidade");

                    b.Property<string>("DescricaoDaCampanha")
                        .HasColumnType("longtext")
                        .HasColumnName("DescricaoDaCampanha");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext")
                        .HasColumnName("Endereco");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext")
                        .HasColumnName("Estado");

                    b.Property<string>("NomeDaCampanha")
                        .HasColumnType("longtext")
                        .HasColumnName("NomeDaCampanha");

                    b.Property<string>("NomeDaOng")
                        .HasColumnType("longtext")
                        .HasColumnName("NomeDaOng");

                    b.Property<string>("Pais")
                        .HasColumnType("longtext")
                        .HasColumnName("Pais");

                    b.Property<bool?>("Pix")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Pix");

                    b.Property<bool?>("ReceberFisico")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ReceberFisico");

                    b.Property<int?>("Telefone")
                        .HasColumnType("int")
                        .HasColumnName("Telefone");

                    b.HasKey("idCampanha");

                    b.HasIndex("CadastroCodigo");

                    b.ToTable("cadastroCampanha");
                });

            modelBuilder.Entity("API_mySQL.Models.Doacao", b =>
                {
                    b.Property<int>("idDoacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CadastroCampanhaidCampanha")
                        .HasColumnType("int");

                    b.Property<int?>("Valor")
                        .HasColumnType("int")
                        .HasColumnName("Valor");

                    b.Property<int>("idCampanha")
                        .HasColumnType("int");

                    b.Property<int?>("tipoDoacao")
                        .HasColumnType("int")
                        .HasColumnName("tipoDoacao");

                    b.HasKey("idDoacao");

                    b.HasIndex("CadastroCampanhaidCampanha");

                    b.ToTable("Doacao");
                });

            modelBuilder.Entity("API_mySQL.Models.CadastroCampanha", b =>
                {
                    b.HasOne("API_mySQL.Models.Cadastro", null)
                        .WithMany("CadastroCampanhas")
                        .HasForeignKey("CadastroCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_mySQL.Models.Doacao", b =>
                {
                    b.HasOne("API_mySQL.Models.CadastroCampanha", null)
                        .WithMany("Doacao")
                        .HasForeignKey("CadastroCampanhaidCampanha");
                });

            modelBuilder.Entity("API_mySQL.Models.Cadastro", b =>
                {
                    b.Navigation("CadastroCampanhas");
                });

            modelBuilder.Entity("API_mySQL.Models.CadastroCampanha", b =>
                {
                    b.Navigation("Doacao");
                });
#pragma warning restore 612, 618
        }
    }
}
