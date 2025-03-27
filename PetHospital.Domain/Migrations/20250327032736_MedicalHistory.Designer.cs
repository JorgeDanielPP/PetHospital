﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetHospital.Domain;

#nullable disable

namespace PetHospital.Domain.Migrations
{
    [DbContext(typeof(AppointmentsContext))]
    [Migration("20250327032736_MedicalHistory")]
    partial class MedicalHistory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetHospital.Domain.Entities.Appointments", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCita"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdPet")
                        .HasColumnType("int");

                    b.Property<int?>("IdVeterinario")
                        .HasColumnType("int");

                    b.Property<string>("MotivoCita")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCita");

                    b.HasIndex("IdCita")
                        .IsUnique();

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("PetHospital.Domain.Entities.MedicalHistory", b =>
                {
                    b.Property<int>("IdHistorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHistorial"));

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("HistorialVacunas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCita")
                        .HasColumnType("int");

                    b.Property<int>("IdPet")
                        .HasColumnType("int");

                    b.Property<string>("MedicamentosRecetados")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHistorial");

                    b.HasIndex("IdHistorial")
                        .IsUnique();

                    b.ToTable("MedicalHistory");
                });

            modelBuilder.Entity("PetHospital.Domain.Entities.VeterinaryDoctor", b =>
                {
                    b.Property<int>("IdVeterinario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVeterinario"));

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreVeterinario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVeterinario");

                    b.HasIndex("IdVeterinario")
                        .IsUnique();

                    b.ToTable("VeterinaryDoctor");
                });

            modelBuilder.Entity("PetHospital.PetHospital.Domain.Entities.Pets", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPet"));

                    b.Property<string>("CedulaPropietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("NombrePet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePropietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPet");

                    b.HasIndex("IdPet")
                        .IsUnique();

                    b.ToTable("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
