﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bianca.Models;

#nullable disable

namespace bianca.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231213215018_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("bianca.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("bianca.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<int>("NotaDeVenda_Id")
                        .HasColumnType("int");

                    b.Property<int>("Percentual")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("bianca.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("bianca.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("Cliente_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<int>("Pagamento_Id")
                        .HasColumnType("int");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("TransportadoraId")
                        .HasColumnType("int");

                    b.Property<int>("Transportadora_Id")
                        .HasColumnType("int");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.Property<int>("Vendedor_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PagamentoId");

                    b.HasIndex("TransportadoraId");

                    b.HasIndex("VendedorId");

                    b.ToTable("NotaDeVenda");
                });

            modelBuilder.Entity("bianca.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("bianca.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Item_Id")
                        .HasColumnType("int");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("Marca_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("bianca.Models.TipoPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<int>("NotaDeVenda_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("TipoPagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoPagamento");
                });

            modelBuilder.Entity("bianca.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Transportadora");
                });

            modelBuilder.Entity("bianca.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("bianca.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("bianca.Models.TipoPagamento");

                    b.Property<string>("Bandeira")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCartao")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("bianca.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("bianca.Models.TipoPagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("bianca.Models.Item", b =>
                {
                    b.HasOne("bianca.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Itens")
                        .HasForeignKey("NotaDeVendaId");

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("bianca.Models.NotaDeVenda", b =>
                {
                    b.HasOne("bianca.Models.Cliente", "Cliente")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("ClienteId");

                    b.HasOne("bianca.Models.Pagamento", "Pagamento")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("PagamentoId");

                    b.HasOne("bianca.Models.Transportadora", "Transportadora")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("TransportadoraId");

                    b.HasOne("bianca.Models.Vendedor", "Vendedor")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("VendedorId");

                    b.Navigation("Cliente");

                    b.Navigation("Pagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("bianca.Models.Produto", b =>
                {
                    b.HasOne("bianca.Models.Item", "Item")
                        .WithMany("Produtos")
                        .HasForeignKey("ItemId");

                    b.HasOne("bianca.Models.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("MarcaId");

                    b.Navigation("Item");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("bianca.Models.TipoPagamento", b =>
                {
                    b.HasOne("bianca.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("TiposPagamento")
                        .HasForeignKey("NotaDeVendaId");

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("bianca.Models.Cliente", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("bianca.Models.Item", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("bianca.Models.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("bianca.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Itens");

                    b.Navigation("TiposPagamento");
                });

            modelBuilder.Entity("bianca.Models.Pagamento", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("bianca.Models.Transportadora", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("bianca.Models.Vendedor", b =>
                {
                    b.Navigation("NotasDeVenda");
                });
#pragma warning restore 612, 618
        }
    }
}
