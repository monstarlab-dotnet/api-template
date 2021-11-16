﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monstarlab.Templates.API.Infrastructure.Data.Migrations
{
    public partial class MigrateToMonstarlabEFPackage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.Sql($"UPDATE Departments SET Created = '{DateTime.Now.AddMinutes(-1):yyyy-MM-dd HH:mm:ss.fff}', Updated = '{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}'");

            migrationBuilder.Sql($"UPDATE Employees SET Created = '{DateTime.Now.AddMinutes(-1):yyyy-MM-dd HH:mm:ss.fff}', Updated = '{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Departments");
        }
    }
}
