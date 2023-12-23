using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Locus.TMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "tms",
                table: "drivers");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                schema: "tms",
                table: "vehicles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "tms",
                table: "vehicles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CarrierId",
                schema: "tms",
                table: "drivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                schema: "tms",
                table: "drivers",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "tms",
                table: "drivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "carriers",
                schema: "tms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Number = table.Column<int>(type: "int", nullable: false),
                    Address_Additional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsible_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsible_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsible_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carriers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                schema: "tms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonType = table.Column<int>(type: "int", nullable: false),
                    Address_CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Number = table.Column<int>(type: "int", nullable: false),
                    Address_Additional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loads",
                schema: "tms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoadStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadReferenceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commodity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeclaredValue = table.Column<double>(type: "float", nullable: false),
                    LoadCapacity = table.Column<int>(type: "int", nullable: false),
                    LoadCondition = table.Column<int>(type: "int", nullable: false),
                    EquipamentInformation__EquipamentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipamentInformation_Temperature = table.Column<double>(type: "float", nullable: false),
                    EquipamentInformation_ContainerNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipamentInformation_LastFreeDay = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EquipamentSize_Length = table.Column<double>(type: "float", nullable: false),
                    EquipamentSize_Width = table.Column<double>(type: "float", nullable: false),
                    EquipamentSize_Height = table.Column<double>(type: "float", nullable: false),
                    EquipamentSize_WeightGross = table.Column<double>(type: "float", nullable: false),
                    EquipamentSize_WeightNet = table.Column<double>(type: "float", nullable: false),
                    EquipamentSize_Cubature = table.Column<double>(type: "float", nullable: false),
                    EquipamentSize_LoadingMetre = table.Column<double>(type: "float", nullable: false),
                    EquipamentSize_Quantity = table.Column<int>(type: "int", nullable: false),
                    PublicNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrivateNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostingNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loads", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carriers",
                schema: "tms");

            migrationBuilder.DropTable(
                name: "customers",
                schema: "tms");

            migrationBuilder.DropTable(
                name: "loads",
                schema: "tms");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "tms",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "tms",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "CarrierId",
                schema: "tms",
                table: "drivers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "tms",
                table: "drivers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "tms",
                table: "drivers");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "tms",
                table: "drivers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
