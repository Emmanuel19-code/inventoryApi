﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inventoryApi.Migrations
{
    /// <inheritdoc />
    public partial class addingTotalSoldToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalSold",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSold",
                table: "Products");
        }
    }
}
