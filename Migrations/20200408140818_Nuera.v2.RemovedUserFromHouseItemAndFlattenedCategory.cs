using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Nuerav2RemovedUserFromHouseItemAndFlattenedCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseholdItems_Categories_CategoryId",
                table: "HouseholdItems");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseholdItems_Users_UserId",
                table: "HouseholdItems");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_HouseholdItems_CategoryId",
                table: "HouseholdItems");

            migrationBuilder.DropIndex(
                name: "IX_HouseholdItems_UserId",
                table: "HouseholdItems");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "HouseholdItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "HouseholdItems");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "HouseholdItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HouseholdItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "HouseholdItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "HouseholdItems");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "HouseholdItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "HouseholdItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseholdItems_CategoryId",
                table: "HouseholdItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseholdItems_UserId",
                table: "HouseholdItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseholdItems_Categories_CategoryId",
                table: "HouseholdItems",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseholdItems_Users_UserId",
                table: "HouseholdItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
