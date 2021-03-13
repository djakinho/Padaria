﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Padaria.Data;

namespace Padaria.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210312204248_Adds Usuario_PerfilUsuario")]
    partial class AddsUsuario_PerfilUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Padaria.Domain.Model.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("Padaria.Domain.Model.PerfilUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("PerfilUsuario");
                });

            modelBuilder.Entity("Padaria.Domain.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("PerfilId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Padaria.Domain.Model.Usuario", b =>
                {
                    b.HasOne("Padaria.Domain.Model.PerfilUsuario", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");
                });
#pragma warning restore 612, 618
        }
    }
}