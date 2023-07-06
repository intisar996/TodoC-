using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoL.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "TodoLists",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "day",
                table: "TodoLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "TodoLists");

            migrationBuilder.DropColumn(
                name: "day",
                table: "TodoLists");
        }
    }
}
