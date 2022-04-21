using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectNS.Migrations.NSDb
{
    public partial class changerelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecallType_RecallInfo_RecallInfoId",
                table: "RecallType");

            migrationBuilder.DropIndex(
                name: "IX_RecallType_RecallInfoId",
                table: "RecallType");

            migrationBuilder.DropColumn(
                name: "RecallInfoId",
                table: "RecallType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecallInfoId",
                table: "RecallType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecallType_RecallInfoId",
                table: "RecallType",
                column: "RecallInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecallType_RecallInfo_RecallInfoId",
                table: "RecallType",
                column: "RecallInfoId",
                principalTable: "RecallInfo",
                principalColumn: "RecallInfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
