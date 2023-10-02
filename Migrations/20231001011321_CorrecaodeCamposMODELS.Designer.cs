﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aplicacaoLoja.Models;

#nullable disable

namespace aplicacaoLoja.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231001011321_CorrecaodeCamposMODELS")]
    partial class CorrecaodeCamposMODELS
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("aplicacaoLoja.Models.Fornecedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("Fornecedores");
                });
#pragma warning restore 612, 618
        }
    }
}
