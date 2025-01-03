﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pagamento_Angular.Database;

#nullable disable

namespace Pagamento_Angular.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241229144737_Primeira-Tabela")]
    partial class PrimeiraTabela
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pagamento_Angular.Models.PagamentoDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoSeguranca")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("DataExpiracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("NomeCartao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumeroCartao")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("PagamentoDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
