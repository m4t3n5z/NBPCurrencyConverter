﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBPCurrencyConverter.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationsConvertInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCodeFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyCodeTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyMidFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyMidTo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsConvertInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationsRetrivesCurrencyInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsRetrivesCurrencyInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationsConvertInfo");

            migrationBuilder.DropTable(
                name: "OperationsRetrivesCurrencyInfo");
        }
    }
}
