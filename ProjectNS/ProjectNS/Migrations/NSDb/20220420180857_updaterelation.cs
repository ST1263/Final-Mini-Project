using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectNS.Migrations.NSDb
{
    public partial class updaterelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecallInfoId",
                table: "RecallType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecallInfoId",
                table: "RecallCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RecallType_RecallInfoId",
                table: "RecallType",
                column: "RecallInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_RecallCategories_RecallInfoId",
                table: "RecallCategories",
                column: "RecallInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecallCategories_RecallInfo_RecallInfoId",
                table: "RecallCategories",
                column: "RecallInfoId",
                principalTable: "RecallInfo",
                principalColumn: "RecallInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecallType_RecallInfo_RecallInfoId",
                table: "RecallType",
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

            migrationBuilder.DropForeignKey(
                name: "FK_RecallType_RecallInfo_RecallInfoId",
                table: "RecallType");

            migrationBuilder.DropIndex(
                name: "IX_RecallType_RecallInfoId",
                table: "RecallType");

            migrationBuilder.DropIndex(
                name: "IX_RecallCategories_RecallInfoId",
                table: "RecallCategories");

            migrationBuilder.DropColumn(
                name: "RecallInfoId",
                table: "RecallType");

            migrationBuilder.DropColumn(
                name: "RecallInfoId",
                table: "RecallCategories");
        }
    }
}
