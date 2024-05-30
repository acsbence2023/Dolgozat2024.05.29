using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReadModel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emberek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kor = table.Column<int>(type: "int", nullable: false),
                    Varos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Munka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erdeklodes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emberek", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emberek");
        }
    }
}
