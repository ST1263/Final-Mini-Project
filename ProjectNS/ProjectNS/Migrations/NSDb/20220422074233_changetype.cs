using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectNS.Migrations.NSDb
{
    public partial class changetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegulatoryMandate",
                table: "RecallInfo");

            migrationBuilder.RenameColumn(
                name: "SupplierVoluntary",
                table: "RecallInfo",
                newName: "SupplierVoluntaryRegulatoryMandate");

            migrationBuilder.AlterColumn<bool>(
                name: "MarkAsUrgent",
                table: "RecallInfo",
                type: "bit",
                maxLength: 30,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CustomizeedContent",
                table: "RecallInfo",
                type: "bit",
                maxLength: 30,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SupplierVoluntaryRegulatoryMandate",
                table: "RecallInfo",
                newName: "SupplierVoluntary");

            migrationBuilder.AlterColumn<string>(
                name: "MarkAsUrgent",
                table: "RecallInfo",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "CustomizeedContent",
                table: "RecallInfo",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "RegulatoryMandate",
                table: "RecallInfo",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);
        }
    }
}
