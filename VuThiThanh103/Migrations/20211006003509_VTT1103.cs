using Microsoft.EntityFrameworkCore.Migrations;

namespace VuThiThanh103.Migrations
{
    public partial class VTT1103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VTT1103",
                columns: table => new
                {
                    VTTId = table.Column<string>(type: "varchar(20)", nullable: false),
                    VTTName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    VTTGender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VTT1103", x => x.VTTId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VTT1103");
        }
    }
}
