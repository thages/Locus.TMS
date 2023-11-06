﻿// <auto-generated />
using System;
using Locus.TMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Locus.TMS.Infrastructure.Migrations
{
    [DbContext(typeof(TmsContext))]
    [Migration("20231102174710_Driver")]
    partial class Driver
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("tms")
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Locus.TMS.Domain.Contacts.Models.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DriverLicense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("drivers", "tms");
                });

            modelBuilder.Entity("Locus.TMS.Domain.Fleet.Models.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("CarriageRate")
                        .HasColumnType("float");

                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ContractorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<Guid>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("vehicles", "tms");
                });

            modelBuilder.Entity("Locus.TMS.Domain.Contacts.Models.Driver", b =>
                {
                    b.OwnsOne("Locus.TMS.Domain.Contacts.Models.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("DriverId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Additional")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<Guid>("CityId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("CountryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Number")
                                .HasColumnType("int");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<Guid>("StateId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("DriverId");

                            b1.ToTable("drivers", "tms");

                            b1.WithOwner()
                                .HasForeignKey("DriverId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("Locus.TMS.Domain.Fleet.Models.Vehicle", b =>
                {
                    b.OwnsOne("Locus.TMS.Domain.Fleet.Models.Fuel", "Fuel", b1 =>
                        {
                            b1.Property<Guid>("VehicleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("ConsumptionCity")
                                .HasColumnType("float");

                            b1.Property<double>("ConsumptionCombined")
                                .HasColumnType("float");

                            b1.Property<double>("ConsumptionHighway")
                                .HasColumnType("float");

                            b1.Property<int>("Kind")
                                .HasColumnType("int");

                            b1.Property<string>("Quality")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("TankCapacity")
                                .HasColumnType("int");

                            b1.HasKey("VehicleId");

                            b1.ToTable("vehicles", "tms");

                            b1.WithOwner()
                                .HasForeignKey("VehicleId");
                        });

                    b.OwnsOne("Locus.TMS.Domain.Fleet.Models.Loading", "Loading", b1 =>
                        {
                            b1.Property<Guid>("VehicleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Body")
                                .HasColumnType("int");

                            b1.Property<double>("CargoVolume")
                                .HasColumnType("float");

                            b1.Property<double>("GVWR")
                                .HasColumnType("float");

                            b1.Property<double>("Height")
                                .HasColumnType("float");

                            b1.Property<double>("HeightExtended")
                                .HasColumnType("float");

                            b1.Property<double>("Length")
                                .HasColumnType("float");

                            b1.Property<double>("MaxPayload")
                                .HasColumnType("float");

                            b1.Property<int>("PassengerVolume")
                                .HasColumnType("int");

                            b1.Property<int>("Type")
                                .HasColumnType("int");

                            b1.Property<double>("Width")
                                .HasColumnType("float");

                            b1.HasKey("VehicleId");

                            b1.ToTable("vehicles", "tms");

                            b1.WithOwner()
                                .HasForeignKey("VehicleId");
                        });

                    b.OwnsOne("Locus.TMS.Domain.Fleet.Models.Model", "Model", b1 =>
                        {
                            b1.Property<Guid>("VehicleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Height")
                                .HasColumnType("float");

                            b1.Property<double>("HeightExtened")
                                .HasColumnType("float");

                            b1.Property<double>("Length")
                                .HasColumnType("float");

                            b1.Property<string>("Make")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("OdometerReading")
                                .HasColumnType("int");

                            b1.Property<DateTimeOffset>("OdometerReadingDate")
                                .HasColumnType("datetimeoffset");

                            b1.Property<string>("TrimLevel")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("VIN")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Width")
                                .HasColumnType("float");

                            b1.Property<int>("Year")
                                .HasColumnType("int");

                            b1.HasKey("VehicleId");

                            b1.ToTable("vehicles", "tms");

                            b1.WithOwner()
                                .HasForeignKey("VehicleId");
                        });

                    b.Navigation("Fuel")
                        .IsRequired();

                    b.Navigation("Loading")
                        .IsRequired();

                    b.Navigation("Model")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
