﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Locadora_de_Jogos___João_Martelli.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240913193135_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Dominio.Aluguel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AluguelID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("ClienteID");

                    b.Property<DateTime>("DataAluguel")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataAluguel");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataDevolucao");

                    b.Property<int>("JogoId")
                        .HasColumnType("int")
                        .HasColumnName("JogoID");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("JogoId");

                    b.ToTable("Alugueis", (string)null);
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("Dominio.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("JogoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("bit")
                        .HasColumnName("Disponibilidade");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Genero");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Nome");

                    b.Property<string>("Plataforma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Plataforma");

                    b.HasKey("Id");

                    b.ToTable("Jogos", (string)null);
                });

            modelBuilder.Entity("Dominio.Aluguel", b =>
                {
                    b.HasOne("Dominio.Cliente", "Cliente")
                        .WithMany("Alugueis")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Jogo", "Jogo")
                        .WithMany("Alugueis")
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Jogo");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.Navigation("Alugueis");
                });

            modelBuilder.Entity("Dominio.Jogo", b =>
                {
                    b.Navigation("Alugueis");
                });
#pragma warning restore 612, 618
        }
    }
}
