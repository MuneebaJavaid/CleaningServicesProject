using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaafCleaningProject.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CDataModels",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "Varchar(50)", nullable: false),
                    CEmail = table.Column<string>(type: "Varchar(100)", nullable: false),
                    CPhone = table.Column<string>(type: "Varchar(15)", nullable: false),
                    CAddress = table.Column<string>(type: "Varchar(150)", nullable: false),
                    message = table.Column<string>(type: "Varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDataModels", x => x.CId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDataModels");
        }
    }
}
