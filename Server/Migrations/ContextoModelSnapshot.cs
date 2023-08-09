﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrestigeFinancial.Server.DAL;

#nullable disable

namespace PrestigeFinancial.Server.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.ClientesDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int>("TiposTelefonoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("ClienteId");

                    b.ToTable("ClientesDetalle");
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Garantes", b =>
                {
                    b.Property<int>("GaranteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.HasKey("GaranteId");

                    b.ToTable("Garantes");
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Pagos", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadCoutasPagadas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PagoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.PagosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidadpagos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PagoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ValorPagado")
                        .HasColumnType("REAL");

                    b.HasKey("DetalleId");

                    b.HasIndex("PagoId");

                    b.ToTable("PagosDetalle");
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Coutas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CoutasOriginal")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaPrestamo")
                        .HasColumnType("TEXT");

                    b.Property<int>("GaranteId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Interes")
                        .HasColumnType("TEXT");

                    b.Property<double>("MontoCoutas")
                        .HasColumnType("REAL");

                    b.Property<double>("MontoInteres")
                        .HasColumnType("REAL");

                    b.Property<double>("MontoSolicitado")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoPrestamo")
                        .HasColumnType("TEXT");

                    b.Property<int>("TiposPrestamoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrestamoId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.TiposPrestamos", b =>
                {
                    b.Property<int>("TiposPrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionPrestamo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TiposPrestamoId");

                    b.ToTable("TiposPrestamos");

                    b.HasData(
                        new
                        {
                            TiposPrestamoId = 1,
                            DescripcionPrestamo = "Personal"
                        },
                        new
                        {
                            TiposPrestamoId = 2,
                            DescripcionPrestamo = "Automotriz"
                        },
                        new
                        {
                            TiposPrestamoId = 3,
                            DescripcionPrestamo = "Hipotecario"
                        });
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.TiposTelefonos", b =>
                {
                    b.Property<int>("TiposTelefonoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TiposTelefonoId");

                    b.ToTable("TiposTelefonos");

                    b.HasData(
                        new
                        {
                            TiposTelefonoId = 1,
                            Descripcion = "Celular"
                        },
                        new
                        {
                            TiposTelefonoId = 2,
                            Descripcion = "Residencial"
                        },
                        new
                        {
                            TiposTelefonoId = 3,
                            Descripcion = "Oficina"
                        });
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.ClientesDetalle", b =>
                {
                    b.HasOne("PrestigeFinancial.Shared.Models.Clientes", null)
                        .WithMany("ClientesDetalle")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.PagosDetalle", b =>
                {
                    b.HasOne("PrestigeFinancial.Shared.Models.Pagos", null)
                        .WithMany("PagosDetalle")
                        .HasForeignKey("PagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Clientes", b =>
                {
                    b.Navigation("ClientesDetalle");
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Pagos", b =>
                {
                    b.Navigation("PagosDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
