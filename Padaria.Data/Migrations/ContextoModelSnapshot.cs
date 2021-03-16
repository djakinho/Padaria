﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Padaria.Data;

namespace Padaria.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Padaria.Domain.Model.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("InscricaoEstatual")
                        .IsRequired()
                        .HasColumnType("varchar(9)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Padaria.Domain.Model.MateriaPrima", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("IdUnidadeMedida")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float(24)");

                    b.HasKey("Id");

                    b.HasIndex("IdUnidadeMedida");

                    b.ToTable("MateriaPrima");
                });

            modelBuilder.Entity("Padaria.Domain.Model.MateriaPrimaProduto", b =>
                {
                    b.Property<int>("IdMateriaPrima")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("IdMateriaPrima", "IdProduto");

                    b.HasIndex("IdProduto");

                    b.ToTable("MateriaPrimaProduto");
                });

            modelBuilder.Entity("Padaria.Domain.Model.MateriaPrimaReceita", b =>
                {
                    b.Property<int>("IdMateriaPrima")
                        .HasColumnType("int");

                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("IdMateriaPrima", "IdReceita");

                    b.HasIndex("IdReceita");

                    b.ToTable("MateriaPrimaReceita");
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

            modelBuilder.Entity("Padaria.Domain.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoProducao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UnidadeMedida")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("IdReceita")
                        .IsUnique();

                    b.HasIndex("IdTipoProducao");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Padaria.Domain.Model.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModoPreparo")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("Padaria.Domain.Model.TipoProducao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoProducao");
                });

            modelBuilder.Entity("Padaria.Domain.Model.UnidadeMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("UnidadeMedida");
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

                    b.Property<int>("IdPerfilUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdPerfilUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Padaria.Domain.Model.MateriaPrima", b =>
                {
                    b.HasOne("Padaria.Domain.Model.UnidadeMedida", "UnidadeMedida")
                        .WithMany("MateriaPrima")
                        .HasForeignKey("IdUnidadeMedida")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Padaria.Domain.Model.MateriaPrimaProduto", b =>
                {
                    b.HasOne("Padaria.Domain.Model.MateriaPrima", "MateriaPrima")
                        .WithMany("MateriaPrimaProduto")
                        .HasForeignKey("IdMateriaPrima")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Padaria.Domain.Model.Produto", "Produto")
                        .WithMany("MateriaPrimaProduto")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Padaria.Domain.Model.MateriaPrimaReceita", b =>
                {
                    b.HasOne("Padaria.Domain.Model.MateriaPrima", "MateriaPrima")
                        .WithMany("MateriaPrimaReceita")
                        .HasForeignKey("IdMateriaPrima")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Padaria.Domain.Model.Receita", "Receita")
                        .WithMany("MateriaPrimaReceita")
                        .HasForeignKey("IdReceita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Padaria.Domain.Model.Produto", b =>
                {
                    b.HasOne("Padaria.Domain.Model.Receita", "Receita")
                        .WithOne("Produto")
                        .HasForeignKey("Padaria.Domain.Model.Produto", "IdReceita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Padaria.Domain.Model.TipoProducao", "TipoProducao")
                        .WithMany("Produtos")
                        .HasForeignKey("IdTipoProducao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Padaria.Domain.Model.Usuario", b =>
                {
                    b.HasOne("Padaria.Domain.Model.PerfilUsuario", "Perfil")
                        .WithMany("Usuario")
                        .HasForeignKey("IdPerfilUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
