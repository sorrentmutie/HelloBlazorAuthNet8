﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelloBlazorAuthNet8.Migrations
{
    /// <inheritdoc />
    public partial class hello : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");
        }
    }
}
