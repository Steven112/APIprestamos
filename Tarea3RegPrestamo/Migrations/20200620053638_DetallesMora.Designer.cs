﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea3RegPrestamo.DAL;

namespace Tarea3RegPrestamo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200620053638_DetallesMora")]
    partial class DetallesMora
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Tarea3RegPrestamo.Models.Mora", b =>
                {
                    b.Property<int>("MoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("MoraId");

                    b.ToTable("moras");
                });

            modelBuilder.Entity("Tarea3RegPrestamo.Models.MoraDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoraId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PrestamosId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("DetalleId");

                    b.HasIndex("MoraId");

                    b.HasIndex("PrestamosId");

                    b.ToTable("MoraDetalle");
                });

            modelBuilder.Entity("Tarea3RegPrestamo.Models.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Normbre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telofono")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.HasKey("PersonaId");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Tarea3RegPrestamo.Models.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balances")
                        .HasColumnType("TEXT");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaPrestamo")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrestamoId");

                    b.ToTable("prestamos");
                });

            modelBuilder.Entity("Tarea3RegPrestamo.Models.MoraDetalle", b =>
                {
                    b.HasOne("Tarea3RegPrestamo.Models.Mora", null)
                        .WithMany("moradetalles")
                        .HasForeignKey("MoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tarea3RegPrestamo.Models.Prestamos", "prestamos")
                        .WithMany()
                        .HasForeignKey("PrestamosId");
                });
#pragma warning restore 612, 618
        }
    }
}
