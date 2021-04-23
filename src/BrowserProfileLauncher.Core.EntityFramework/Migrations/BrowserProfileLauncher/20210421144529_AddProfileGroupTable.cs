using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrowserProfileLauncher.Core.EntityFramework.Migrations.BrowserProfileLauncher
{
    public partial class AddProfileGroupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "BrowserProfiles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProfileGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrowserProfiles_GroupId",
                table: "BrowserProfiles",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrowserProfiles_ProfileGroups_GroupId",
                table: "BrowserProfiles",
                column: "GroupId",
                principalTable: "ProfileGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrowserProfiles_ProfileGroups_GroupId",
                table: "BrowserProfiles");

            migrationBuilder.DropTable(
                name: "ProfileGroups");

            migrationBuilder.DropIndex(
                name: "IX_BrowserProfiles_GroupId",
                table: "BrowserProfiles");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "BrowserProfiles");
        }
    }
}
