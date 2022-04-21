using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectNS.Migrations.NSDb
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FDAClassification",
                columns: table => new
                {
                    FDAClassificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FdaClassificationName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDAClassification", x => x.FDAClassificationId);
                });

            migrationBuilder.CreateTable(
                name: "RecallCategories",
                columns: table => new
                {
                    RecallCategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecallCategoriesName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecallCategories", x => x.RecallCategoriesId);
                });

            migrationBuilder.CreateTable(
                name: "RecallInfo",
                columns: table => new
                {
                    RecallInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecallId = table.Column<int>(type: "int", nullable: false),
                    RecallName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RecallType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RecallDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZNumber = table.Column<int>(type: "int", nullable: false),
                    FDAClassification = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RecallCategories = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RecallStatus = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MarkAsUrgent = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CustomizeedContent = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SupplierVoluntary = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RegulatoryMandate = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SupportingMaterial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecallInfo", x => x.RecallInfoId);
                });

            migrationBuilder.CreateTable(
                name: "RecallType",
                columns: table => new
                {
                    RecallTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecallTypeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecallType", x => x.RecallTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FDAClassification");

            migrationBuilder.DropTable(
                name: "RecallCategories");

            migrationBuilder.DropTable(
                name: "RecallInfo");

            migrationBuilder.DropTable(
                name: "RecallType");
        }
    }
}
