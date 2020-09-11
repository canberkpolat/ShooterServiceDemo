using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShooterServiceDemo.Migrations
{
    public partial class ShooterServiceDemoContextsRepositoryContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShootingRecords",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ShooterID = table.Column<int>(nullable: false),
                    DeadID = table.Column<int>(nullable: false),
                    HitZoneID = table.Column<int>(nullable: false),
                    ShootingTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShootingRecords", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShootingRecords");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
