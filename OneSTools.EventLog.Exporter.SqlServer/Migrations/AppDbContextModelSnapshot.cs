﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneSTools.EventLog.Exporter.SqlServer;

namespace OneSTools.EventLog.Exporter.SqlServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OneSTools.EventLog.EventLogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddPort")
                        .HasColumnType("int");

                    b.Property<string>("Application")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Computer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Connection")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataPresentation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataUuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Event")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainPort")
                        .HasColumnType("int");

                    b.Property<string>("Metadata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetadataUuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Server")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Session")
                        .HasColumnType("int");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionNumber")
                        .HasColumnType("int");

                    b.Property<string>("TransactionStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUuid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EventLogItems");
                });

            modelBuilder.Entity("OneSTools.EventLog.Exporter.Core.EventLogPosition", b =>
                {
                    b.Property<string>("LgpFileName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("LgpFilePosition")
                        .HasColumnType("bigint");

                    b.HasKey("LgpFileName");

                    b.ToTable("EventLogPositions");
                });
#pragma warning restore 612, 618
        }
    }
}
