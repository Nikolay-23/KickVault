using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KickVault.Migrations
{
    /// <inheritdoc />
    public partial class AddedReleaseDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId1",
                table: "UserItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_ItemId1",
                table: "UserItems",
                column: "ItemId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Items_ItemId1",
                table: "UserItems",
                column: "ItemId1",
                principalTable: "Items",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Items_ItemId1",
                table: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_ItemId1",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "ItemId1",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Items");
        }
    }
}
