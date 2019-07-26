﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaseStudy.Migrations
{
    public partial class TrayAdditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(9, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrayItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrayId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrayItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrayItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrayItems_Trays_TrayId",
                        column: x => x.TrayId,
                        principalTable: "Trays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrayItems_ProductId",
                table: "TrayItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TrayItems_TrayId",
                table: "TrayItems",
                column: "TrayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrayItems");

            migrationBuilder.DropTable(
                name: "Trays");
        }
    }
}
