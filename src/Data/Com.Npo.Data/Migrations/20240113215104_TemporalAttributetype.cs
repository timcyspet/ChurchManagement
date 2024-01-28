using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Com.Npo.Data.Migrations
{
    /// <inheritdoc />
    public partial class TemporalAttributetype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "AttributeTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "AttributeTypes",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "AttributeTypes");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "AttributeTypes");
        }
    }
}
