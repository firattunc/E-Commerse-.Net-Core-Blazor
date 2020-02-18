using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorProject.Backend.Migrations
{
    public partial class updateUserAddress_UserForeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AbpUsers_UserId",
                table: "UserAddresses");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "UserAddresses",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AbpUsers_UserId",
                table: "UserAddresses",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AbpUsers_UserId",
                table: "UserAddresses");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "UserAddresses",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AbpUsers_UserId",
                table: "UserAddresses",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
