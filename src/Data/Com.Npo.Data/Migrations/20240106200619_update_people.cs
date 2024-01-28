using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Com.Npo.Data.Migrations
{
    /// <inheritdoc />
    public partial class update_people : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAttributes_Attributes_AttributeId",
                table: "PersonAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonAttributes_People_PersonId",
                table: "PersonAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonAttributes",
                table: "PersonAttributes");

            migrationBuilder.RenameTable(
                name: "PersonAttributes",
                newName: "PeopleAttributes");

            migrationBuilder.RenameIndex(
                name: "IX_PersonAttributes_PersonId",
                table: "PeopleAttributes",
                newName: "IX_PeopleAttributes_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonAttributes_AttributeId",
                table: "PeopleAttributes",
                newName: "IX_PeopleAttributes_AttributeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeopleAttributes",
                table: "PeopleAttributes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAttributes_Attributes_AttributeId",
                table: "PeopleAttributes",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleAttributes_People_PersonId",
                table: "PeopleAttributes",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAttributes_Attributes_AttributeId",
                table: "PeopleAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleAttributes_People_PersonId",
                table: "PeopleAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeopleAttributes",
                table: "PeopleAttributes");

            migrationBuilder.RenameTable(
                name: "PeopleAttributes",
                newName: "PersonAttributes");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleAttributes_PersonId",
                table: "PersonAttributes",
                newName: "IX_PersonAttributes_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleAttributes_AttributeId",
                table: "PersonAttributes",
                newName: "IX_PersonAttributes_AttributeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonAttributes",
                table: "PersonAttributes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAttributes_Attributes_AttributeId",
                table: "PersonAttributes",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAttributes_People_PersonId",
                table: "PersonAttributes",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
