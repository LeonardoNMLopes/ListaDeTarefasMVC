﻿// <auto-generated />
using System;
using ListaDeTarefasMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListaDeTarefasMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240720154800_CriandoBanco")]
    partial class CriandoBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ListaDeTarefasMVC.Models.Categoria", b =>
                {
                    b.Property<string>("CategoriaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = "trabalho",
                            Nome = "Trabalho"
                        },
                        new
                        {
                            CategoriaId = "casa",
                            Nome = "Casa"
                        },
                        new
                        {
                            CategoriaId = "faculdade",
                            Nome = "faculdade"
                        },
                        new
                        {
                            CategoriaId = "compras",
                            Nome = "Compras"
                        },
                        new
                        {
                            CategoriaId = "academia",
                            Nome = "Academia"
                        });
                });

            modelBuilder.Entity("ListaDeTarefasMVC.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "aberto",
                            Nome = "Aberto"
                        },
                        new
                        {
                            StatusId = "completo",
                            Nome = "Completo"
                        });
                });

            modelBuilder.Entity("ListaDeTarefasMVC.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DataDeVencimento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("ListaDeTarefasMVC.Models.Tarefa", b =>
                {
                    b.HasOne("ListaDeTarefasMVC.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ListaDeTarefasMVC.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
