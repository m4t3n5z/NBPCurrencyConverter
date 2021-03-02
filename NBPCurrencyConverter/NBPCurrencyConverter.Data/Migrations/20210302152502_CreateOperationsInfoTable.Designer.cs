﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NBPCurrencyConverter.Data;

namespace NBPCurrencyConverter.Data.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20210302152502_CreateOperationsInfoTable")]
    partial class CreateOperationsInfoTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NBPCurrencyConverter.Data.Models.OperationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CurrencyCodeFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyCodeTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CurrencyMidFrom")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CurrencyMidTo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OperationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationsInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
