using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectNS.Migrations.NSDb
{
    public partial class updater : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecallCategories_RecallInfo_RecallInfoId",
                table: "RecallCategories");

            migrationBuilder.AlterColumn<int>(
                name: "RecallInfoId",
                table: "RecallCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_RecallCategories_RecallInfo_RecallInfoId",
                table: "RecallCategories",
                column: "RecallInfoId",
                principalTable: "RecallInfo",
                principalColumn: "RecallInfoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecallCategories_RecallInfo_RecallInfoId",
                table: "RecallCategories");

            migrationBuilder.AlterColumn<int>(
                name: "RecallInfoId",
                table: "RecallCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RecallCategories_RecallInfo_RecallInfoId",
                table: "RecallCategories",
                column: "RecallInfoId",
                principalTable: "RecallInfo",
                principalColumn: "RecallInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
