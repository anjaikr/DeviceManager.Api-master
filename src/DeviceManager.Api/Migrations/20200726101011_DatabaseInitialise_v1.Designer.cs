﻿// <auto-generated />
using System;
using DeviceManager.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeviceManager.Api.Migrations
{
    [DbContext(typeof(DeviceContext))]
    [Migration("20200726101011_DatabaseInitialise_v1")]
    partial class DatabaseInitialise_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeviceManager.Api.Data.Model.Device", b =>
                {
                    b.Property<Guid>("DeviceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceCode");

                    b.Property<Guid>("DeviceGroupId");

                    b.Property<string>("DeviceTitle");

                    b.HasKey("DeviceId");

                    b.HasIndex("DeviceGroupId");

                    b.ToTable("Devices");

                    b.HasData(
                        new { DeviceId = new Guid("1ee62dd5-d698-4e67-a260-f5a66f86f0df"), DeviceCode = "Surface568", DeviceGroupId = new Guid("843a92af-9174-49a3-a2e7-08f99919d6ca"), DeviceTitle = "Surface Tablet" },
                        new { DeviceId = new Guid("9b34ae90-f226-43df-8ad0-7cfdce2f16a7"), DeviceCode = "Xbox1234", DeviceGroupId = new Guid("843a92af-9174-49a3-a2e7-08f99919d6ca"), DeviceTitle = "X Box" }
                    );
                });

            modelBuilder.Entity("DeviceManager.Api.Data.Model.DeviceGroup", b =>
                {
                    b.Property<Guid>("DeviceGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<string>("OperatingSystem");

                    b.HasKey("DeviceGroupId");

                    b.ToTable("DeviceGroups");

                    b.HasData(
                        new { DeviceGroupId = new Guid("843a92af-9174-49a3-a2e7-08f99919d6ca"), Company = "Microsoft", OperatingSystem = "Windows 10" }
                    );
                });

            modelBuilder.Entity("DeviceManager.Api.Data.Model.Device", b =>
                {
                    b.HasOne("DeviceManager.Api.Data.Model.DeviceGroup", "DeviceGroup")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
