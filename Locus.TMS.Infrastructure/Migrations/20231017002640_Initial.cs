using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Locus.TMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tms");

            migrationBuilder.CreateTable(
                name: "vehicles",
                schema: "tms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarriageRate = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Loading_Body = table.Column<int>(type: "int", nullable: false),
                    Loading_Type = table.Column<int>(type: "int", nullable: false),
                    Loading_Length = table.Column<double>(type: "float", nullable: false),
                    Loading_Width = table.Column<double>(type: "float", nullable: false),
                    Loading_Height = table.Column<double>(type: "float", nullable: false),
                    Loading_HeightExtended = table.Column<double>(type: "float", nullable: false),
                    Loading_CargoVolume = table.Column<double>(type: "float", nullable: false),
                    Loading_MaxPayload = table.Column<double>(type: "float", nullable: false),
                    Loading_GVWR = table.Column<double>(type: "float", nullable: false),
                    Loading_PassengerVolume = table.Column<int>(type: "int", nullable: false),
                    Model_Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_Year = table.Column<int>(type: "int", nullable: false),
                    Model_TrimLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_OdometerReading = table.Column<int>(type: "int", nullable: false),
                    Model_OdometerReadingDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Model_Length = table.Column<double>(type: "float", nullable: false),
                    Model_Width = table.Column<double>(type: "float", nullable: false),
                    Model_Height = table.Column<double>(type: "float", nullable: false),
                    Model_HeightExtened = table.Column<double>(type: "float", nullable: false),
                    Fuel_Kind = table.Column<int>(type: "int", nullable: false),
                    Fuel_Quality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fuel_TankCapacity = table.Column<int>(type: "int", nullable: false),
                    Fuel_ConsumptionCity = table.Column<double>(type: "float", nullable: false),
                    Fuel_ConsumptionHighway = table.Column<double>(type: "float", nullable: false),
                    Fuel_ConsumptionCombined = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicles",
                schema: "tms");
        }
    }
}
