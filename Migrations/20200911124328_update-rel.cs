using Microsoft.EntityFrameworkCore.Migrations;

namespace ShooterServiceDemo.Migrations
{
    public partial class updaterel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<long>(
                name: "ShooterID",
                table: "ShootingRecords",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "DeadID",
                table: "ShootingRecords",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingRecords_ShooterID",
                table: "ShootingRecords",
                column: "ShooterID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShootingRecords_Users_ShooterID",
                table: "ShootingRecords",
                column: "ShooterID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShootingRecords_Users_ShooterID",
                table: "ShootingRecords");

            migrationBuilder.DropIndex(
                name: "IX_ShootingRecords_ShooterID",
                table: "ShootingRecords");

            migrationBuilder.AlterColumn<int>(
                name: "ShooterID",
                table: "ShootingRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "DeadID",
                table: "ShootingRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "ShootingRecords",
                type: "bigint",
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
    }
}
