using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneSimulasyonu.UI.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "Hasta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "Hasta",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
