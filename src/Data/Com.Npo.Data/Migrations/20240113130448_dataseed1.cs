using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Com.Npo.Data.Migrations
{
    /// <inheritdoc />
    public partial class dataseed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TransactionType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "TransactionType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "TransactionType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "Regions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "Regions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "MemberType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "MemberType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "MemberShipType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "MemberShipType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "Memberships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "Memberships",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "CommitmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "CommitmentTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFromDate",
                table: "Address",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveToDate",
                table: "Address",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TransactionType");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "TransactionType");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "TransactionType");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "MemberType");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "MemberType");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "MemberShipType");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "MemberShipType");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "CommitmentTypes");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "CommitmentTypes");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "EffectiveFromDate",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "EffectiveToDate",
                table: "Address");
        }
    }
}
