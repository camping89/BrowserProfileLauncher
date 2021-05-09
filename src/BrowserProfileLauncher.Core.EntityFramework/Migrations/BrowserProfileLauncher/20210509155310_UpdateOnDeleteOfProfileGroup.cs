using Microsoft.EntityFrameworkCore.Migrations;

namespace BrowserProfileLauncher.Core.EntityFramework.Migrations.BrowserProfileLauncher
{
    public partial class UpdateOnDeleteOfProfileGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrowserProfiles_ProfileGroups_GroupId",
                table: "BrowserProfiles");

            migrationBuilder.AddForeignKey(
                name: "FK_BrowserProfiles_ProfileGroups_GroupId",
                table: "BrowserProfiles",
                column: "GroupId",
                principalTable: "ProfileGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrowserProfiles_ProfileGroups_GroupId",
                table: "BrowserProfiles");

            migrationBuilder.AddForeignKey(
                name: "FK_BrowserProfiles_ProfileGroups_GroupId",
                table: "BrowserProfiles",
                column: "GroupId",
                principalTable: "ProfileGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
