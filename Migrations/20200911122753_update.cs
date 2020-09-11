using Microsoft.EntityFrameworkCore.Migrations;

namespace ShooterServiceDemo.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "ShootingRecords",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShootingRecords_UserID",
                table: "ShootingRecords",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShootingRecords_Users_UserID",
                table: "ShootingRecords",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShootingRecords_Users_UserID",
                table: "ShootingRecords");

            migrationBuilder.DropIndex(
                name: "IX_ShootingRecords_UserID",
                table: "ShootingRecords");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ShootingRecords");
        }
    }
}
