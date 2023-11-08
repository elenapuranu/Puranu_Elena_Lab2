﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puranu_Elena_Lab2.Migrations
{
    public partial class bookdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.AlterColumn<string>(
            name: "CategoryName",
            table: "Category",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: "",
            oldClrType: typeof(string),
            oldType: "nvarchar(max)",
            oldNullable: true);
        }
    }
}