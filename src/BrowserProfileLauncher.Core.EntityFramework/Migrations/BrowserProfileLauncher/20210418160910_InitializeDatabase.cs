using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrowserProfileLauncher.Core.EntityFramework.Migrations.BrowserProfileLauncher
{
    public partial class InitializeDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrowserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProxyIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProxyPort = table.Column<int>(type: "int", nullable: false),
                    ProxyProtocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProxyUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProxyPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrowserProfiles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrowserProfiles");
        }
    }
}
