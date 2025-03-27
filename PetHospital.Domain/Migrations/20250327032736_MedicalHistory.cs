using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHospital.Domain.Migrations
{
    /// <inheritdoc />
    public partial class MedicalHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalHistory",
                columns: table => new
                {
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPet = table.Column<int>(type: "int", nullable: false),
                    IdCita = table.Column<int>(type: "int", nullable: false),
                    HistorialVacunas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicamentosRecetados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistory", x => x.IdHistorial);
                });

            migrationBuilder.CreateTable(
                name: "VeterinaryDoctor",
                columns: table => new
                {
                    IdVeterinario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVeterinario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeterinaryDoctor", x => x.IdVeterinario);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistory_IdHistorial",
                table: "MedicalHistory",
                column: "IdHistorial",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeterinaryDoctor_IdVeterinario",
                table: "VeterinaryDoctor",
                column: "IdVeterinario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalHistory");

            migrationBuilder.DropTable(
                name: "VeterinaryDoctor");
        }
    }
}
