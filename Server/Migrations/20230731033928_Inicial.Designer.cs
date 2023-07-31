﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrestigeFinancial.Server.DAL;

#nullable disable

namespace PrestigeFinancial.Server.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230731033928_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("cedula")
                        .IsRequired()
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
                        .HasColumnType("TEXT");

                    b.Property<int>("TiposTelefonoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("ClienteId");

                    b.ToTable("ClientesDetalle");
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

                    b.Property<string>("Deudor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaPrestamo")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Interes")
                        .HasColumnType("TEXT");

                    b.Property<double>("MontoCoutas")
                        .HasColumnType("REAL");

                    b.Property<double>("MontoSolicitado")
                        .HasColumnType("REAL");

                    b.Property<double>("MontoTotal")
                        .HasColumnType("REAL");

                    b.Property<double>("Restante")
                        .HasColumnType("REAL");

                    b.HasKey("PrestamoId");

                    b.HasIndex("ClienteId");

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

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Prestamos", b =>
                {
                    b.HasOne("PrestigeFinancial.Shared.Models.Clientes", null)
                        .WithMany("Prestamos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrestigeFinancial.Shared.Models.Clientes", b =>
                {
                    b.Navigation("ClientesDetalle");

                    b.Navigation("Prestamos");
                });
#pragma warning restore 612, 618
        }
    }
}
